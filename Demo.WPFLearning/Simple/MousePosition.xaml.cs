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

namespace Demo.WPFLearning.Simple
{
    /// <summary>
    /// MousePosition.xaml 的交互逻辑
    /// </summary>
    public partial class MousePosition : Window
    {
        public MousePosition()
        {
            InitializeComponent();
        }
        private void Rect_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(this);
            this.Info.Text = ("Mouse is at ( " + pt.X + " , " + pt.Y + " ) in window");
        }

        private void cmdCapture_Click(object sender, RoutedEventArgs e)
        {
            Mouse.Capture(this.rect);
            this.cmdCapture.Content = "Mouse is now captured ...";
        }
    }
}
