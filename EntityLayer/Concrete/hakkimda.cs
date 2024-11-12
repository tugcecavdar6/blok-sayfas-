using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class hakkimda
    {
        [Key]
        public int hakkimdaID { get; set; }
        public string hakkimdaDetay1 { get; set; }
        public string hakkimdaDetay2 { get; set; }
        public string hakkimdaImg1 { get; set; }
        public string hakkimdaImg2 { get; set; }
        public string hakkimdaHaritaLokasyon { get; set; }
        public bool hakkimdaDurum { get; set; }
    }
}
