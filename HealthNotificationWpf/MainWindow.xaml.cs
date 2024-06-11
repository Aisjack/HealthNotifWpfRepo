using HealthNotificationWpf.Controls;
using System;
using System.Windows;
using System.Windows.Threading;

namespace HealthNotificationWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NotificationController _control = new();
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(_control.getInterval());
            timer.Tick += timer_Tick;
            timer.Start();

        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            if (count < _control.GetListCount())
            {
                var notifResultText = _control.GetNotifText(count);
                var notifResultUrl = _control.GetNotifUrl(count);
                txtBlkInitialTest.Text = notifResultText;
                TestDesign frm = new TestDesign(notifResultText, notifResultUrl);
                frm.Show();
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TaskBarIco.IconSource = null;
            TaskBarIco.ToolTipText = null;
            TaskBarIco.Visibility = Visibility.Hidden;
            TaskBarIco.Dispose();
            this.Close();
            App.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TaskBarIco.Visibility = Visibility.Visible;
            this.ShowInTaskbar = false;
            this.Hide();
        }
    }
}
