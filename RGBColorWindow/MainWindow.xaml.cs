using System.Windows;
using System.Windows.Media;

namespace RGBColorWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            ColorRectangle.Fill = new SolidColorBrush(color);

            color = Color.FromRgb((byte)RedSlider.Value, 0, 0);
            RedRectangle.Fill = new SolidColorBrush(color);

            color = Color.FromRgb(0, (byte)GreenSlider.Value, 0);
            GreenRectangle.Fill = new SolidColorBrush(color);

            color = Color.FromRgb(0, 0, (byte)BlueSlider.Value);
            BlueRectangle.Fill = new SolidColorBrush(color);
        }

        private void BtnRevert_Click(object sender, RoutedEventArgs e)
        {
            RedSlider.Value = 255 - RedSlider.Value;
            GreenSlider.Value = 255 - GreenSlider.Value;
            BlueSlider.Value = 255 - BlueSlider.Value;
        }
    }
}
