using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Models
{
    public class AddProfileImage
    {
        public int yazarID { get; set; }
        public string yazarAd { get; set; }
        public string yazarHakkinda { get; set; }
        public IFormFile yazarImg { get; set; }
        public string yazarMail { get; set; }
        public string yazarSifre { get; set; }
        public string yazarYenisifre { get; set; }
        public bool yazarDurum { get; set; }
    }
}
