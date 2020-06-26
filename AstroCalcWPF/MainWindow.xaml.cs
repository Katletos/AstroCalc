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
            FrameWithinGrid.Navigate(new System.Uri("Satellite.xaml",
            System.UriKind.RelativeOrAbsolute));
        }

        private void Teleskopes_Checked(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("Telescopes.xaml",
           System.UriKind.RelativeOrAbsolute));
        }
    }
}
