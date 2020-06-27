using System;
using System.Windows;


namespace AstroCalcWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Satellite_Checked(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new Uri("Satellite.xaml",
            UriKind.RelativeOrAbsolute));
        }

        private void Stellarium_Checked(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new Uri("Stellarium.xaml",
            UriKind.RelativeOrAbsolute));
        }

        private void Teleskopes_Checked(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new Uri("Telescopes.xaml",
            UriKind.RelativeOrAbsolute));
        }
    }
}
