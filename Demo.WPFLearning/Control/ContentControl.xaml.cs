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
    /// ContentControl.xaml 的交互逻辑
    /// </summary>
    public partial class ContentControl : Window
    {
        public ContentControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IsCancel");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IsDefault");
        }
    }
}
