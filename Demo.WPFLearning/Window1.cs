using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Demo.WPFLearning
{
    class Window1 : Window
    {
        private Button button1;

        public Window1()
        {
            InitialzeComponent();
        }

        private void InitialzeComponent()
        {
            this.Width = 285;
            this.Height = 300;
            this.Left = this.Top = 100;
            this.Title = " code only Windows";

            //停靠面板
            DockPanel dockPanel = new DockPanel();

            //Button
            button1 = new Button();
            button1.Content = " hello ,click me";
            //使用Thickness 设置四周属性
            button1.Margin = new Thickness(30, 30, 30, 30);
            button1.Click += button1_Click; // 注册事件，没有括号

            //——分析允许混合子元素和文本元素所需方法的对象
            IAddChild container = dockPanel;//将按钮控件，设置到面板上
            container.AddChild(button1);

            container = this; //将面板控件，设置到当前窗体上
            container.AddChild(dockPanel);


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "hahahah";

        }
    }
}
