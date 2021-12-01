using System.Windows;
using System.IO;
using System.Windows.Markup;
using System.Windows.Controls;

namespace Demo.WPFLearning
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button mybutton;
        public MainWindow()
        {
            InitializeComponent();


        }
        public MainWindow(string xmalFile)
        {
            //设置窗体
            this.Width = this.Height = 300;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            //// 从外部文档获取XAML的内容
            //FileStream fileStream = new FileStream(xmalFile, FileMode.Open); //文件流对象， 二参打开方式

            ////用xaml文件流对象 XamlReader 加载，转换为DependencyObject对象。
            ////DependencyObject是WPF空间继承的的一个基类，可以放在任何类型的容器里。
            //DependencyObject rootElement = (DependencyObject)XamlReader.Load(fileStream);

            DependencyObject rootElement;
            //因为流的关系，使用using语句(有开有关)
            using (FileStream fileStream = new FileStream(xmalFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fileStream);
            }

            this.Content = rootElement;  //内容关联,将xaml文件显示在当前窗口
            mybutton = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button_1");
            mybutton.Click += myButton_Click;//注册

        }
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            mybutton.Content = "Thank you.";

        }

    }

    

}
