using System;
using System.Windows;

namespace ScalingNamespace
{
    /// <summary>
    /// Логика взаимодействия для Scaling.xaml
    /// </summary>
    public partial class Scaling : Window
    {
        private readonly MainWindow w;

        public Scaling(MainWindow window)
        {
            w = window;
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            w.ChangeScaling(ScalingAmount);
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            w.ChangeScaling(ScalingAmount);
            DialogResult = true;
        }

        public uint ScalingAmount => Convert.ToUInt32(scalingBox.Text);
    }
}
