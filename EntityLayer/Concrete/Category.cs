using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int kategoriID { get; set; }
        public string kategoriAd { get; set; }
        public string kategoricerik { get; set; }
        public bool kategoridurum { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}







