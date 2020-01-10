using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebPodcast.Models;
using WebPodcast.ViewModel;

namespace WebPodcast.Controllers
{
    public class HomeController : Controller
    {

        PodcastContext db;
        private readonly IWebHostEnvironment hostingEnvironment;

        public HomeController(PodcastContext context, IWebHostEnvironment hostingEnvironment)
        {
            db = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View(db.Authors.ToList());
        }


        [Route("{name}")]
        public IActionResult PodcastsShow(string name)
        {
            ViewData["Title"] = name;
            List<Author> author = db.Authors.Where(p => p.Name == name).ToList();
            IQueryable<Podcast> podcasts = db.Podcasts.Include(p => p.Author).Where(p => p.Author.Name == name);

            PodcastList podcastList = new PodcastList
            {
                AuthorId = author[0].Id,
                Name = author[0].Name,
                Description = author[0].Description,
                Image = author[0].Image,
                Podcasts = podcasts,
                Audio = "~/music/Disgusting men/pod.mp3"
            };
            return View(podcastList);
        }


        public IActionResult AddAuthor()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAuthor([Bind("Id,Name,Description,Image")] Author authors)
        {
            if (ModelState.IsValid)
            {
                db.Add(authors);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authors);
        }

        public async Task<IActionResult> AuthorEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await db.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AuthorEdit(int id, [Bind("Id,Name,Description,Image")] Author authors)
        {
            if (id != authors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(authors);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorExists(authors.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(authors);
        }

        public async Task<IActionResult> AuthorDelete(int id)
        {
            var authors = await db.Authors.FindAsync(id);
            db.Authors.Remove(authors);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult AddPodcast(int id, string authorName)
        {
            ViewData["AuthorId"] = id;
            ViewData["authorName"] = authorName;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(100_000_000)]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> AddPodcast(int id, PodcastEditList model)
        {  
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Audio != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "music/1");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Audio.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Audio.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                string path = "/music/1/" + uniqueFileName;
                Podcast podcast = new Podcast
                {
                    AuthorID = id,
                    Name = model.Name,
                    Description = model.Description,
                    Audio = path,
                    RecordingDate = model.RecordingDate
                };

                db.Add(podcast);
                await db.SaveChangesAsync();
                var authorName = db.Authors.Where(p => p.Id == podcast.AuthorID).ToList()[0].Name;
                return RedirectToAction("PodcastsShow", new { name = authorName });
            }
            return View(model);
        }


        public async Task<IActionResult> PodcastEdit(int id, string authorId)
        {
            ViewData["Id"] = id;
            ViewData["AuthorName"] = authorId;
            var podcast = await db.Podcasts.FindAsync(id);
            if (podcast == null)
            {
                return NotFound();
            }
            
            PodcastEditList model = new PodcastEditList
            {
                RecordingDate = podcast.RecordingDate,
                Name = podcast.Name,
                AuthorID = podcast.AuthorID,
                Description = podcast.Description
            };

            return View(model);
        }

        public async Task<IActionResult> PodcastDelete(int id, string authorName)
        {
            var podcasts = await db.Podcasts.FindAsync(id);
            db.Podcasts.Remove(podcasts);
            await db.SaveChangesAsync();
            return RedirectToAction("PodcastsShow", new { name = authorName });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(100_000_000)]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> PodcastEdit(int id, PodcastEditList model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                string path = null;
                if (model.Audio != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "music/1");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Audio.FileName;
                    path = "/music/1/" + uniqueFileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Audio.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                else path = GetAudioPath(id);

                Podcast podcast = new Podcast
                {
                    Id = id,
                    AuthorID = model.AuthorID,
                    Name = model.Name,
                    Description = model.Description,
                    Audio = path,
                    RecordingDate = model.RecordingDate
                };

                try
                {
                    db.Update(podcast);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PodcastExists(podcast.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var authorName = db.Authors.Where(p => p.Id == podcast.AuthorID).ToList()[0].Name;
                return RedirectToAction("PodcastsShow", new { name = authorName });
            }
            return View(model);
        }

        private bool AuthorExists(int id)
        {
            return db.Authors.Any(e => e.Id == id);
        }

        private string GetAudioPath(int id)
        {
            var podcast = db.Podcasts.Where(p => p.Id == id).ToList();
            db.Entry<Podcast>(podcast[0]).State = EntityState.Detached;
            return podcast[0].Audio;
        }


        private bool PodcastExists(int id)
        {
            return db.Podcasts.Any(e => e.Id == id);
        }
    }
}
