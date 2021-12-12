using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Demo.WPFLearning.Ap;

namespace Demo.WPFLearning
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //.....发生未处理事件时执行
        }
        //重写一个受保护的方法
        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
            e.Cancel = true;
            MessageBox.Show("无法注销或关闭系统！");
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow win = new MainWindow();
            if (e.Args.Length > 0)
            {
                string file = e.Args[0];
                if (File.Exists(file))
                {
                    win.LoadFile(file);
                }
            }
            win.Show();
        }


        private List<Document> _documents = new List<Document>();
        public List<Document> Documents
        {
            get
            {
                return _documents;
            }
            set
            {
                _documents = value;
            }
        }


    }
}
