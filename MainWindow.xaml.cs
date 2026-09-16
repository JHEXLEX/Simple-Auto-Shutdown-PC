using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace AutoCloseTimer
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private int _remainingSeconds = 0;

        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += Timer_Tick;
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void OpenLinkedIn(object sender, RoutedEventArgs e) => OpenUrl("https://www.linkedin.com/in/ömer-genç/");
        private void OpenInstagram(object sender, RoutedEventArgs e) => OpenUrl("https://www.instagram.com/hayyam.iniko/");
        private void OpenKick(object sender, RoutedEventArgs e) => OpenUrl("https://kick.com/hayyam-iniko");
        private void OpenGithub(object sender, RoutedEventArgs e) => OpenUrl("https://github.com/JHEXLEX");

        private void Quick15(object sender, RoutedEventArgs e) => SetTime(0, 15, 0);
        private void Quick30(object sender, RoutedEventArgs e) => SetTime(0, 30, 0);
        private void Quick60(object sender, RoutedEventArgs e) => SetTime(1, 0, 0);
        private void Quick120(object sender, RoutedEventArgs e) => SetTime(2, 0, 0);

        private void SetTime(int h, int m, int s)
        {
            txtHours.Text = h.ToString();
            txtMinutes.Text = m.ToString();
            txtSeconds.Text = s.ToString();
        }

        private void StartTimer(object sender, RoutedEventArgs e)
        {
            if (_timer.IsEnabled) return;

            int.TryParse(txtHours.Text, out int h);
            int.TryParse(txtMinutes.Text, out int m);
            int.TryParse(txtSeconds.Text, out int s);

            _remainingSeconds = (h * 3600) + (m * 60) + s;

            if (_remainingSeconds <= 0)
            {
                MessageBox.Show("Please enter a duration greater than 0.", "Invalid Duration", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (rbShutdown.IsChecked == true)
                Process.Start(new ProcessStartInfo("shutdown", $"-s -t {_remainingSeconds}") { CreateNoWindow = true });
            else if (rbRestart.IsChecked == true)
                Process.Start(new ProcessStartInfo("shutdown", $"-r -t {_remainingSeconds}") { CreateNoWindow = true });

            btnStart.IsEnabled = false;
            UpdateDisplay();
            _timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (_remainingSeconds > 0)
            {
                _remainingSeconds--;
                UpdateDisplay();
            }
            else
            {
                _timer.Stop();
                btnStart.IsEnabled = true;

                if (rbSleep.IsChecked == true)
                    Process.Start(new ProcessStartInfo("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0") { CreateNoWindow = true });
            }
        }

        private void UpdateDisplay()
        {
            TimeSpan t = TimeSpan.FromSeconds(_remainingSeconds);
            lblCountdown.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }

        private void CancelTimer(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("shutdown", "-a") { CreateNoWindow = true });

            if (_timer.IsEnabled)
                _timer.Stop();

            _remainingSeconds = 0;
            lblCountdown.Text = "00:00:00";
            btnStart.IsEnabled = true;

            MessageBox.Show("All scheduled tasks have been canceled.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}