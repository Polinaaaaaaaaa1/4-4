using System.Collections.Generic;
namespace lasthw.Models
{
    public class BlogEntity
    {
        public string Article { get; set; }
        public string Text { get; set; }
        public List<string> TagsList { get; set; }
        public string ImagePath { get; set; }
    }
    
}
