using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Yazar
    {
        [Key]
        public int yazarID { get; set; }
        public string yazarAd { get; set; }
        public string yazarHakkinda { get; set; }
        public string yazarImg { get; set; }
        public string yazarMail { get; set; }
        public string yazarSifre { get; set; }
        public bool yazarDurum { get; set; }
        public List<Blog> blogs { get; set; }
        public virtual ICollection<Message2> WriterSender { get; set; }
        public virtual ICollection<Message2> WriterRecevier { get; set; }
    }
}
