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
    /// TextControl.xaml 的交互逻辑
    /// </summary>
    public partial class TextControl : Window
    {
        public TextControl()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (this.txtSelect == null) return;
            this.txtSelect.Text = "Select from " + this.TextBox.SelectionStart + " to "
                + TextBox.SelectionLength + " is " + TextBox.SelectedText;
         }
    }
}
