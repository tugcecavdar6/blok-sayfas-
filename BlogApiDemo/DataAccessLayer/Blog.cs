using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string Blogicerik { get; set; }
        public string BlogkucukImg { get; set; }
        public string BlogImg { get; set; }
        public DateTime BlogTarih { get; set; }
        public bool BlogDurum { get; set; }
        public int kategoriID { get; set; }
        public Category Category { get; set; }
        public int yazarID { get; set; }
        public Yazar yazar { get; set; }
        public List<Yorumlar> yorumlars { get; set; }
    }
}
