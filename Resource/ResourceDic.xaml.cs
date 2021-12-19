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

namespace Demo.WPFLearning.Resource
{
    /// <summary>
    /// ResourceDic.xaml 的交互逻辑
    /// </summary>
    public partial class ResourceDic : Window
    {
        public ResourceDic()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("WpfResourceLibrary;component/ResourceDictionary1.xaml", UriKind.Relative);
            this.Button4.Background = (Brush)rd["TileBrush2"];
        }
    }
}
