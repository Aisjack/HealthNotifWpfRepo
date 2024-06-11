using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HealthAppAdminPortal.Models;

namespace HealthAppAdminPortal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationInterval> NotificationIntervals { get; set; }
    }
}
