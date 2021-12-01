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
    /// Keyboard.xaml 的交互逻辑
    /// </summary>
    public partial class Keyboard : Window
    {
        public Keyboard()
        {
            InitializeComponent();
        }
        public void Textboxx_KeyEvent(object sender, KeyEventArgs e)
        {
            string msg = "Event:" + e.RoutedEvent + "   Key:" + e.Key;
            this.listMessage.Items.Add(msg);
        }
        public void Textboxx_TextInput(object sender, TextCompositionEventArgs e)
        {
            string msg = "Event:" + e.RoutedEvent + "   Key:" + e.Text;
            this.listMessage.Items.Add(msg);
        }

        private void Textboxx_TextChanged(object sender, TextChangedEventArgs e)
        {
            string msg = "Event:" + e.RoutedEvent;
            this.listMessage.Items.Add(msg);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            this.listMessage.Items.Clear();
        }
    }
}
