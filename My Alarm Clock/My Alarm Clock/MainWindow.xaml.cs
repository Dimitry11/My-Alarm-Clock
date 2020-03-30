namespace My_Alarm_Clock
{
    using System;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Threading;

    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RotationSecond.Angle = 6 * DateTime.Now.Second;
            RotationMinute.Angle = 6 * DateTime.Now.Minute;
            RotationHour.Angle = 30 * DateTime.Now.Hour + 5 * (DateTime.Now.Minute / 10);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void closeBtn_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
