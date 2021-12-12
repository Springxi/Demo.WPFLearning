using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Demo.WPFLearning
{
    class Program : Application
    {
        //[STAThread]单线程 Single Thread Apartment Thread.(单一线程单元线程), [] 是用来表示Attributes,指示应用程序的 COM 线程模型是单线程单元。

        //[STAThread]一种线程模型，用在程序的入口方法上（在C#和VB.NET里是Main()方法），来指定当前线程的ApartmentState 是STA。
        //用在其他方法上不产生影响。在aspx页面上可以使用AspCompat = "true" 来达到同样的效果。

        //[STAThread]指示应用程序的默认线程模型是单线程单元 (STA)。启动线程模型可设置为单线程单元或多线程单元。如果未对其进行设置，则该线程不被初始化。
        //其它的还有MTA（多线程套间）、Free  Thread（自由线程）
        [STAThread()]
        static void Main()
        {
            Program app = new Program();
            // app.MainWindow = new Window1();// 当前主窗体实例化一个window1
            app.MainWindow = new MainWindow("Window2.xaml");
            app.MainWindow.ShowDialog();//采用模态方法打开。
            //模态显示（showdialog）和非模态显示（show）。
            // 模态与非模态窗体的主要区别是窗体显示的时候是否可以操作其他窗体。模态窗体不允许操作其他窗体，非模态窗体可以操作其他窗体。
        }
    }
}
