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

namespace Demo.WPFLearning.Control
{
    /// <summary>
    /// SpecialContainerControl.xaml 的交互逻辑
    /// </summary>
    public partial class SpecialContainerControl : Window
    {
        public SpecialContainerControl()
        {
            InitializeComponent();
        }


        

        private void PageDown_Click(object sender, RoutedEventArgs e)
        {
            this.ScrollViewer1.PageDown();
        }

        private void LineUp_Click(object sender, RoutedEventArgs e)
        {
            this.ScrollViewer1.LineUp();
        }

        private void TooHome_Click(object sender, RoutedEventArgs e)
        {
            ScrollViewer1.ScrollToHome();
        }
    }
}
