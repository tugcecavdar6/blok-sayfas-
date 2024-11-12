using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class yorumlar
    {
        [Key]
        public int yorumID { get; set; }
        public string yorumAd { get; set; }
        public string yorumBaslik { get; set; }
        public string yorumicerik { get; set; }
        public DateTime yorumDate { get; set; }
        public int BlogScore { get; set; }
        public bool yorumDurum { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
