using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPodcast.Models;

namespace WebPodcast
{
    public static class SampleData
    {
        public static void Initialize(PodcastContext context)
        {
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Disgusting men",
                        Description = "Это еженедельный подкаст с disgustingmen.com. Мы говорим о кинематографе, музыке, светской жизни, путешествиях и видеоиграх.",
                        Image = "http://drive.google.com/uc?export=view&id=1ya_nPmBefspSlzxTGf1pQ-3Viyby75tw"

                    }

                );
                context.SaveChanges();
            }
        }
    }
}
