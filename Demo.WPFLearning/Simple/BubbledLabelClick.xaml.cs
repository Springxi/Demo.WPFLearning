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

namespace Demo.WPFLearning
{
    /// <summary>
    /// BubbledLabelClick.xaml 的交互逻辑
    /// </summary>
    public partial class BubbledLabelClick : Page
    {
        public BubbledLabelClick()
        {
            InitializeComponent();
        }
        private int eventCount = 0;
        private void SomethingClicked(object sender, RoutedEventArgs e)
        {
            eventCount++;
            string message = "#" + eventCount.ToString() + ":\r\n" +
                "Sender:" + sender.ToString() + ":\r\n" +
                "Source:" + e.Source.ToString() + ":\r\n" +
                "Original Source:" + e.OriginalSource.ToString() + ":\r\n"+
                "Event:" + e.RoutedEvent + "\r\n";
            listMessages.Items.Add(message);
            e.Handled = (bool)chkHandle.IsChecked;
        }
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            eventCount = 0;
            listMessages.Items.Clear();
        }
        
    }
}
