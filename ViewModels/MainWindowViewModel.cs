using lasthw.Models;
using System.Collections.Generic;
using System;

namespace lasthw.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            BlogEntities = new List<BlogEntity>
    {
        new BlogEntity { Article = "Article 1", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed aliquam, nunc ut tincidunt convallis, metus nisl accumsan ligula, non venenatis orci ipsum et elit. Maecenas bibendum euismod enim, eu molestie nunc sollicitudin a. Vivamus in ipsum varius, euismod felis vitae, placerat leo. Nullam fermentum lacus eget ipsum laoreet pharetra. Aenean non lacinia ante. Aliquam erat volutpat. Praesent ac suscipit arcu, a iaculis neque. Nulla bibendum, ex sed tempus viverra, velit purus fermentum orci, et pretium velit arcu at ex. Pellentesque ac tellus eget libero interdum porttitor ut at tellus.", TagsList = new List<string> { "Tag1.1", "Tag2.1" }, ImagePath = "immagge.jpg" },
        new BlogEntity { Article = "Article 2", Text = "Sed pretium, mi a gravida mattis, libero diam tristique est, vel laoreet nulla tortor et magna. Sed dapibus eu eros non fermentum. Nam dapibus velit ac orci rhoncus, eget interdum neque laoreet. Pellentesque at lacinia ex, non vestibulum tellus. Nunc eget justo nec ante tristique scelerisque in id lectus. In mattis leo vitae nibh varius, et fermentum nunc volutpat. Vestibulum eu accumsan est.", TagsList = new List<string> { "Tag1.2", "Tag2.2" }, ImagePath = "image2.jpg" },
        new BlogEntity { Article = "Article 3", Text = "Vestibulum ac fermentum justo. Donec est dui, auctor nec eros et, viverra feugiat odio. Nunc nec sagittis leo, ut suscipit lacus. Phasellus quis ligula blandit, auctor lorem et, vulputate magna. Vivamus mollis mauris in mauris finibus posuere. In hac habitasse platea dictumst. Duis ullamcorper pellentesque pretium. Nulla pharetra feugiat purus, ac vestibulum massa tempor at. Mauris varius, lacus vel semper tempor, magna arcu commodo arcu, vitae tempus arcu urna eget est.", TagsList = new List<string> { "Tag1.3", "Tag2.3" }, ImagePath = "image3.jpg" }
    };

            NewsEntities = new List<NewsEntity>
    {
        new NewsEntity { Text = "Donec cursus arcu at justo rhoncus, varius rhoncus tortor iaculis. Praesent porta porta urna, et varius turpis tristique et. Sed mattis pharetra augue, sed porttitor nisl. ", PublishDate = DateTime.Now },
        new NewsEntity { Text = "Nulla iaculis nunc et diam bibendum convallis. Vestibulum blandit placerat ipsum. Morbi eu massa venenatis, scelerisque orci eget, luctus diam.", PublishDate = DateTime.Now },
        new NewsEntity { Text = " Vivamus quis magna faucibus leo sollicitudin lobortis. Curabitur at ex lorem. Mauris eu scelerisque sem, scelerisque pharetra turpis.", PublishDate = DateTime.Now }
    };
        }


        public List<BlogEntity> BlogEntities { get; set; }
        public List<NewsEntity> NewsEntities { get; set; }
    }
}
