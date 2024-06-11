using HealthNotificationWpf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace HealthNotificationWpf.Controls
{
    public class NotificationController
    {
        public DataContext _context = new();

        public NotificationController()
        {
        }
        public int GetListCount()
        {
            var notifCount = _context
                .Notifications
                .Where(x => x.UrlActive == true)
                .Count();

            return notifCount;
        }
        public int getInterval()
        {
            var intervalGetInitial = _context
                .NotificationIntervals
                .Select(x => x.IntervalTime)
                .FirstOrDefault();

            if(intervalGetInitial <= 10)
            {
                return 11;
            }
            return Convert.ToInt32(intervalGetInitial);
        }
        public List<string> GetListNotification()
        {
            var notifList = _context
                .Notifications
                .Where(x => x.UrlActive == true)
                .Select(x => x.NotificationText)
                .ToList();

            return notifList;
        }
        public List<string> GetListNotifUrl()
        {
            var notifUrlList = _context
                .Notifications
                .Where(x => x.UrlActive == true)
                .Select(x => x.NotificationUrl)
                .ToList();

            return notifUrlList;
        }
        public string GetNotifText(int count)
        {
            var notifTextList = GetListNotification();
            var notifText = notifTextList[count].ToString();

            return notifText;
        }
        public string? GetNotifUrl(int count)
        {
            var notifUrlList = GetListNotifUrl();
            string notifUrl;
            if (notifUrlList[count] != null)
            {
                return notifUrl = notifUrlList[count].ToString();
            }
            return notifUrl = string.Empty;
        }
    }
}
