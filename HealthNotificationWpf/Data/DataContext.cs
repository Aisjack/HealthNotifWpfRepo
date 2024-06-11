using HealthNotificationWpf.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthNotificationWpf.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationInterval> NotificationIntervals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=vxivdcdevdb01;Initial Catalog=NotificationAppWpf.Data;User Id=Test0001_user;Password=123456;Encrypt=False");
    }
}
