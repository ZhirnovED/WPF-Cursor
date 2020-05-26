using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseMove += Text_MouseMove;
            this.MouseLeftButtonUp += rectangle_positions;
            this.KeyDown += Text_KeyDown;
        }
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
            double height = this.ActualHeight;
            double width = this.ActualWidth;

            textBlock.Text = "Высота " + height + "," + "ширина " + width;
        }
        private void Text_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            krd.Text = "X=" + p.X + " Y=" + p.Y;

        }
        private void Text_KeyDown(object sender, KeyEventArgs e)
        {
            Key k = e.Key;
            txkey.Text = "клавиша: " + k;
        }
        private void rectangle_positions(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 1 )
            {
                Point mousePosition = e.GetPosition(Canvas1);
                double mousePositionX = e.GetPosition(Canvas1).X;
                double mousePositionY = e.GetPosition(Canvas1).Y;

                Canvas.SetLeft(rectang, mousePositionX);
                Canvas.SetTop(rectang, mousePositionY);

            }
        }




    }
}
