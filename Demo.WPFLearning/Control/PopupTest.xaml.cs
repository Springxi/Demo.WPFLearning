using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Documents;

namespace Demo.WPFLearning.Control
{
    /// <summary>
    /// PopupTest.xaml 的交互逻辑
    /// </summary>
    public partial class PopupTest : Window
    {
        public PopupTest()
        {
            InitializeComponent();
        }

        private void Run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            //打开浏览器，指向对应路径
            Process.Start(((Hyperlink)sender).NavigateUri.ToString());
        }
    }
}
