using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebPodcast.Models;

namespace WebPodcast.ViewModel
{
    public class PodcastList
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Audio { get; set; }
        public string Description { get; set; }
        public IEnumerable<Podcast> Podcasts { get; set; }
    }
}


