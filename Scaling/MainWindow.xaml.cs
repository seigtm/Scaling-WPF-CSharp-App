using System.Windows;

namespace ScalingNamespace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const uint DefaultHeight = 300;
        private const uint DefaultWidth = 500;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            Scaling scaling = new(this);
            _ = scaling.ShowDialog();
        }

        public void ChangeScaling(uint scaling)
        {
            Height = DefaultHeight * scaling / 100;
            Width = DefaultWidth * scaling / 100;
        }
    }
}
