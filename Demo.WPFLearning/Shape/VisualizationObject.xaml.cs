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
using System.Windows.Shapes;

namespace Demo.WPFLearning.Shape
{
    /// <summary>
    /// VisualizationObject.xaml 的交互逻辑
    /// </summary>
    public partial class VisualizationObject : Window
    {
        public VisualizationObject()
        {
            InitializeComponent();
        }

        private void MyPanel_Loaded(object sender, RoutedEventArgs e)
        {
            DrawingVisual visual = new DrawingVisual();
            using (DrawingContext drawingContext = visual.RenderOpen())
            {
                Brush brush = Brushes.LightGreen;
                Pen pen = new Pen(Brushes.SteelBlue, 3);

                drawingContext.DrawLine(pen, new Point(0, 50), new Point(50, 0));
                drawingContext.DrawLine(pen, new Point(50, 0), new Point(100, 50));
                drawingContext.DrawLine(pen, new Point(0, 50), new Point(100, 50));

                drawingContext.DrawRectangle(brush, pen, new Rect(new Point(100, 100), new Size(50, 100)));

                drawingContext.DrawEllipse(brush,pen,new Point(300,200),100,60);
            }
            MyPanel.AddVisual(visual);
        }
    }
}
