using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1CoursePaint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum SelectPen
        { Pen, Circle, Rect }
        private SelectPen currentPen = SelectPen.Pen;
        private Color currentColor = Colors.Black;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CanvasPaint_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Shape shape = null;
            switch (currentPen)
            {
                case SelectPen.Pen:
                    shape = new Ellipse
                    {
                        Fill = new SolidColorBrush(currentColor),
                        Width = 5,
                        Height = 5,
                    };
                    break;
                case SelectPen.Circle:
                    shape = new Ellipse
                    {
                        Fill = new SolidColorBrush(currentColor),
                        Width = 50,
                        Height = 50,
                    };
                    break;
                case SelectPen.Rect:
                    shape = new Rectangle
                    {
                        Fill = new SolidColorBrush(currentColor),
                        Width = 50,
                        Height = 50,
                    };
                    break;
                default:
                    return;
            }
            Canvas.SetLeft(shape, e.GetPosition(canvasPaint).X - shape.Width/2);
            Canvas.SetTop(shape, e.GetPosition(canvasPaint).Y - shape.Height/2);
            canvasPaint.Children.Add(shape);
        }

        private void ButtonPen_OnClick(object sender, RoutedEventArgs e)
        {
            currentPen = SelectPen.Pen;
        }
        private void ButtonCircle_OnClick(object sender, RoutedEventArgs e)
        {
            currentPen = SelectPen.Circle;
        }
        private void ButtonRect_OnClick(object sender, RoutedEventArgs e)
        {
            currentPen = SelectPen.Rect;
        }

        private void ButtonWhite_OnClick(object sender, RoutedEventArgs e)
        {
            currentColor = Colors.White;
        }
        private void ButtonBlack_OnClick(object sender, RoutedEventArgs e)
        {
            currentColor = Colors.Black;
        }
        private void ButtonGreen_OnClick(object sender, RoutedEventArgs e)
        {
            currentColor = Colors.Green;
        }
        private void ButtonYellow_OnClick(object sender, RoutedEventArgs e)
        {
            currentColor = Colors.Yellow;
        }
        private void ButtonRed_OnClick(object sender, RoutedEventArgs e)
        {
            currentColor = Colors.Red;
        }
    }
}
