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
    /// ListControl_2.xaml 的交互逻辑
    /// </summary>
    public partial class ListControl_2 : Window
    {
        public ListControl_2()
        {
            InitializeComponent();
        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //当在listBox中使用不同元素时，读取SelectItem时，看不到ListBox中对象，只能看到放在列表中对象
            if (lst.SelectedItem == null) return;
            txtSelect.Text = "You choice Item at Position :" + (lst.SelectedIndex + 1) + "\r\n" +
                "Checked state is " +  ((CheckBox)lst.SelectedItem).IsChecked;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //对listBox的元素进行遍历
            foreach (CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    stringBuilder.Append(item.Content);
                    stringBuilder.Append("  is checked.");
                    stringBuilder.Append("\r\n");
                }
                txtSelect.Text = stringBuilder.ToString();
            }
        }
    }
}
