using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPodcast.Models
{
    public class Podcast
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public DateTime RecordingDate { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }

        [Required]
        public string Audio { get; set; }

        public string Description { get; set; }
    }
}
