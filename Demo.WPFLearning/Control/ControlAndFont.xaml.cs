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
    /// ControlFormat.xaml 的交互逻辑
    /// </summary>
    public partial class ControlFormat : Window
    {
        public ControlFormat()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 鼠标光标
            this.Cursor = Cursors.Wait;
            //this.button.Background = new SolidColorBrush(Colors.AliceBlue);
            this.button.Background = new SolidColorBrush(Color.FromRgb(100,40,29));
            this.button.Foreground = System.Windows.SystemColors.ControlDarkBrush;

            foreach(FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                this.listBox.Items.Add(fontFamily.Source);
            }
        }
    }
}
