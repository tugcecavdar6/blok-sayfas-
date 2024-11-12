using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string NotificationTuru { get; set; }
        public string NotificationTurSembolu { get; set; }
        public string NotificationDetay { get; set; }
        public DateTime NotificationTarih { get; set; }
        public bool NotificationDurum { get; set; }
        public string NotificationRengi { get; set; }
    }
}
