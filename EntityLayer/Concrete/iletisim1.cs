using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class iletisim1
    {
        [Key]
        public int iletisimID { get; set; }
        public string iletisimKullaniciAd { get; set; }
        public string iletisimMail { get; set; }
        public string iletisimBaslik { get; set; }
        public string iletisimMesaj { get; set; }
        public DateTime iletisimTarih { get; set; }
        public bool iletisimDurum { get; set; }
    }
}
