using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Message
    {
        [Key]
        public int MesajId { get; set; }
        public string Gonderen { get; set; }
        public string Alici { get; set; }
        public string Konu { get; set; }
        public string MesajDetay { get; set; }
        public DateTime MesajTarih { get; set; }
        public bool MesajDurum { get; set; }
    }
}
