using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyClone.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubTitle { get; set; }
        public string BackgroundImage { get; set; }
        public string CardImage { get; set; }
        public string TitleImage { get; set; }
        public string Type { get; set; }
        //public int? CreatedById { get; set; }
        //public virtual User CreatedBy { get; set; }
    }
}
