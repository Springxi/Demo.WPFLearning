using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.WPFLearning.Ap;
using Microsoft.VisualBasic.ApplicationServices;

namespace Demo.WPFLearning
{
    class SingleInstanceApplicationWrapper : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public SingleInstanceApplicationWrapper()
        {
            this.IsSingleInstance = true;

        }
        private SingleWPFApp app;
        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
           // return base.OnStartup(eventArgs);
            app = new SingleWPFApp();
            app.Run();
            return false;
        }
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            //只是打开一个新的窗口，并不启动一个新的实例
            app.showWindow();
        }
    }
}
