using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HealthNotificationWpf
{
    /// <summary>
    /// Interaction logic for TestDesign.xaml
    /// </summary>
    public partial class TestDesign : Window
    {
        public string? formUrl;
        eventsNotify modelValue = new();

        public TestDesign(string content, string url)
        {
            InitializeComponent();

            if(url != string.Empty)
            {
                modelValue.HeightValue = 23;
            }
            else
            {
                modelValue.HeightValue = 0;
            }

            modelValue.OpacityValue = 0;
            DataContext = modelValue;

            string[] Sentences = content.Split('@');
            //string FormattedContent = String.Join("&amp;#10;", Sentences);
            //txtNotifMain.Text = FormattedContent.ToString();

            var sb = new System.Text.StringBuilder();
            foreach(var item in Sentences)
            {
                sb.Append($"{item}{Environment.NewLine}");
            }

            txtNotifMain.Text = sb.ToString();

            formUrl = url.ToString();

            DispatcherTimer timer = new();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void VixieFace_Loaded(object sender, RoutedEventArgs e)
        {
            var vixieLogo = sender as Button;
            var vixieAnimate = new DoubleAnimation() { To = 150, Duration = TimeSpan.FromSeconds(0.3) };
            vixieLogo.BeginAnimation(Button.HeightProperty, vixieAnimate);
            vixieLogo.BeginAnimation(Button.WidthProperty, vixieAnimate);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var destinationurl = formUrl;
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
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
            //var txtBlock = sender as TextBlock;
            //var opacityAnimate = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(15), BeginTime = TimeSpan.FromSeconds(1) };
            //txtBlock.BeginAnimation(TextBlock.OpacityProperty, opacityAnimate);
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var opacityAnimate = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(15), BeginTime = TimeSpan.FromSeconds(1) };
            button.BeginAnimation(Button.OpacityProperty, opacityAnimate);
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            var opacityAnimate = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(15), BeginTime = TimeSpan.FromSeconds(1) };
            label.BeginAnimation(Label.OpacityProperty, opacityAnimate);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var window = sender as Window;
            var sizeAnimation = new DoubleAnimation() { To = 0, Duration = TimeSpan.FromSeconds(20) };
            window.BeginAnimation(Window.WidthProperty, sizeAnimation);
            window.BeginAnimation(Window.HeightProperty, sizeAnimation);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            var window = sender as Window;
            var sizeAnimation = new DoubleAnimation() { To = 0, Duration = TimeSpan.FromSeconds(20) };
            window.BeginAnimation(Window.WidthProperty, sizeAnimation);
            window.BeginAnimation(Window.HeightProperty, sizeAnimation);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(modelValue.OpacityValue == 0)
            {
                modelValue.OpacityValue = 100;
            }
            else
            {
                modelValue.OpacityValue = 0;
            }

        }
    }
}
