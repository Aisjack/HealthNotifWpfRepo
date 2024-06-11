using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace HealthNotificationWpf
{
    /// <summary>
    /// Interaction logic for NotificationForm.xaml
    /// </summary>
    public partial class NotificationForm : Window
    {
        public NotificationForm(string content, string url)
        {
            InitializeComponent();
            txtNotificationForm.Text = content.ToString();
            txtNotificationFormUrl.Text = url.ToString();
            DispatcherTimer timer = new();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width - 5;
            this.Top = desktopWorkingArea.Bottom - this.Height - 5;
            this.Topmost = true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var destinationurl = txtNotificationFormUrl.Text.ToString();
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void Exit_MouseEnter(object sender, MouseEventArgs e)
        {
            var image = sender as Image;
            var widthAnimate = new DoubleAnimation() { To = 23, Duration = TimeSpan.FromSeconds(0.3) };
            var heightAnimate = new DoubleAnimation() { To = 23, Duration = TimeSpan.FromSeconds(0.3) };

            image.BeginAnimation(Button.WidthProperty, widthAnimate);
            image.BeginAnimation(Button.HeightProperty, heightAnimate);
        }

        private void Exit_MouseLeave(object sender, MouseEventArgs e)
        {
            var image = sender as Image;
            var widthAnimate = new DoubleAnimation() { To = 20, Duration = TimeSpan.FromSeconds(0.3) };
            var heightAnimate = new DoubleAnimation() { To = 20, Duration = TimeSpan.FromSeconds(0.3) };

            image.BeginAnimation(Button.WidthProperty, widthAnimate);
            image.BeginAnimation(Button.HeightProperty, heightAnimate);
        }

        private void txtBlockLoaded(object sender, RoutedEventArgs e)
        {
            var txtBlock = sender as TextBlock;
            //var heightAnimate = new DoubleAnimation() { To = 120, Duration = TimeSpan.FromSeconds(1.5), BeginTime = TimeSpan.FromSeconds(0.4) };
            //var widthAnimate = new DoubleAnimation() { To = 300, Duration = TimeSpan.FromSeconds(1.5), BeginTime = TimeSpan.FromSeconds(0.4) };
            var opacityAnimate = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(7), BeginTime = TimeSpan.FromSeconds(0.7) };
            //txtBlock.BeginAnimation(Button.HeightProperty, heightAnimate);
            //txtBlock.BeginAnimation(Button.WidthProperty, widthAnimate);
            txtBlock.BeginAnimation(Button.OpacityProperty, opacityAnimate);
        }

        //private void buttonLoaded(object sender, RoutedEventArgs e)
        //{
        //    var button = sender as Button;
        //    var heightAnimate = new DoubleAnimation() { To = 200, Duration = TimeSpan.FromSeconds(1.7) };
        //    button.BeginAnimation(Button.HeightProperty, heightAnimate);
        //}

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void VixieFace_Loaded(object sender, RoutedEventArgs e)
        {
            var vixieLogo = sender as Image;
            var vixieAnimate = new DoubleAnimation() { To = 183, Duration = TimeSpan.FromSeconds(0.3) };
            vixieLogo.BeginAnimation(Image.HeightProperty, vixieAnimate);
            vixieLogo.BeginAnimation(Image.WidthProperty, vixieAnimate);
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var opacityAnimate = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(7), BeginTime = TimeSpan.FromSeconds(0.7) };
            button.BeginAnimation(Button.OpacityProperty, opacityAnimate);
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            var opacityAnimate = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(7), BeginTime = TimeSpan.FromSeconds(0.2) };
            label.BeginAnimation(Label.OpacityProperty, opacityAnimate);
        }
    }
}
