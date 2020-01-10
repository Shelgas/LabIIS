using System;
using System.Collections.Generic;
using WebPodcast.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebPodcast.ViewModel
{
    public class PodcastEditList
    {
        public string Name { get; set; }

        [Required]
        public DateTime RecordingDate { get; set; }

        public int AuthorID { get; set; }

      
        public IFormFile Audio { get; set; }

        public string Description { get; set; }
    }
}
