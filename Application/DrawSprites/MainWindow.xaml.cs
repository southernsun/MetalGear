using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawSprites
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawSprites();
        }

        public void DrawSprites()
        {
            var myLine = new Line
            {
                Stroke = System.Windows.Media.Brushes.LightSteelBlue,
                X1 = 1,
                X2 = 50,
                Y1 = 1,
                Y2 = 50,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
                StrokeThickness = 2
            };

            MyCanvas.Children.Add(myLine);
        }
    }
}