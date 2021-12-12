using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Demo.WPFLearning.Ap
{
    class SingleWPFApp :System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            showWindow();
        }
        public void showWindow()
        {
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
