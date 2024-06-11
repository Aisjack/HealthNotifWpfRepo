using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNotificationWpf.Models
{
    public class Notification
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string NotificationText { get; set; }
        [MaxLength(500)]
        public string? NotificationUrl { get; set; }
        public bool? UrlActive { get; set; }
    }
}
