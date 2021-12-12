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
    /// MouseDragAndDrop.xaml 的交互逻辑
    /// </summary>
    public partial class MouseDragAndDrop : Window
    {
        public MouseDragAndDrop()
        {
            InitializeComponent();
        }

        private void LabFrom_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label label = (Label)sender;
            DragDrop.DoDragDrop(label, label.Content, DragDropEffects.Copy);
        }

        private void LabTo_Drop(object sender, DragEventArgs e)
        {
            Label label = (Label)sender;
            label.Content = e.Data.GetData(DataFormats.Text);
        }
    }
}
