using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawSprites
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static WriteableBitmap? _writeableBitmap;
        private static Image? _i;
        private const int WidthAndHeight = 200;

        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
            _i = new Image();
            RenderOptions.SetBitmapScalingMode(_i, BitmapScalingMode.NearestNeighbor);
            RenderOptions.SetEdgeMode(_i, EdgeMode.Aliased);

            MyContent.Content = _i;

            _writeableBitmap = new WriteableBitmap(
                WidthAndHeight,
                WidthAndHeight,
                96,
                96,
                PixelFormats.Bgr32,
                null);

            _i.Source = _writeableBitmap;

            _i.Stretch = Stretch.None;
            _i.HorizontalAlignment = HorizontalAlignment.Left;
            _i.VerticalAlignment = VerticalAlignment.Top;

            _i.MouseMove += i_MouseMove;
            _i.MouseLeftButtonDown +=
                i_MouseLeftButtonDown;
            _i.MouseRightButtonDown +=
                i_MouseRightButtonDown;

            MyContent.MouseWheel += w_MouseWheel;
        }

        // The DrawPixel method updates the WriteableBitmap by using
        // unsafe code to write a pixel into the back buffer.
        static void DrawPixel(MouseEventArgs e)
        {
            int column = (int)e.GetPosition(_i).X;
            int row = (int)e.GetPosition(_i).Y;

            _writeableBitmap.SetPixel(column, row, Colors.White);
        }

        static void ErasePixel(MouseEventArgs e)
        {
            int column = (int)e.GetPosition(_i).X;
            int row = (int)e.GetPosition(_i).Y;

            _writeableBitmap.SetPixel(column, row, Colors.Black);
        }

        static void i_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ErasePixel(e);
        }

        static void i_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DrawPixel(e);
        }

        static void i_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DrawPixel(e);
            }
            else if (e.RightButton == MouseButtonState.Pressed)
            {
                ErasePixel(e);
            }
        }

        static void w_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (_i == null) return;

            var m = _i.RenderTransform.Value;

            if (e.Delta > 0)
            {
                m.ScaleAt(
                    1.5,
                    1.5,
                    e.GetPosition(sender as UIElement).X,
                    e.GetPosition(sender as UIElement).Y);
            }
            else
            {
                m.ScaleAt(
                    1.0 / 1.5,
                    1.0 / 1.5,
                    e.GetPosition(sender as UIElement).X,
                    e.GetPosition(sender as UIElement).Y);
            }

            _i.RenderTransform = new MatrixTransform(m);
        }
    }
}