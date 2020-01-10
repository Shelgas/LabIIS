using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebPodcast.Models
{
    public class PodcastContext : DbContext
    {
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Author> Authors { get; set; }


        public PodcastContext(DbContextOptions<PodcastContext> options)
            : base(options)
        {
           Database.EnsureCreated();
        }
    }
}
