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

namespace Demo.WPFLearning.Ap
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //查看当天住窗体
           // MessageBox.Show("The main Window is" + Application.Current.MainWindow.Title);
            //读出当前打开的所有窗体
            foreach( Window window in Application.Current.Windows)
            {
                MessageBox.Show("The open Window Tile is :" + Application.Current.MainWindow.Title);
            }
           
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Document();
            doc.Owner = this;
            doc.Show();
            ((App)Application.Current).Documents.Add(doc); //只要创建新的窗口，就添加进doc集合中

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            foreach( Document doc in ((App)Application.Current).Documents)
            {
                doc.Content += "\r\n refreshed at " + DateTime.Now.ToLongTimeString()+".";            }
        }
    }
}
