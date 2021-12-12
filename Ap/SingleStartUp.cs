using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WPFLearning.Ap
{
    class SingleStartUp
    {
        [STAThread()]
        static void Main(string [] args)
        {
            ////启动多个进程
            //SingleWPFApp app = new SingleWPFApp();
            //app.Run();

            SingleInstanceApplicationWrapper wrapper = new SingleInstanceApplicationWrapper();
            wrapper.Run(args);

        }
    }
}
