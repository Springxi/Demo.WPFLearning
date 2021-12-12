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

namespace Demo.WPFLearning.Bindingg
{
    /// <summary>
    /// ElementBinding.xaml 的交互逻辑
    /// </summary>
    public partial class ElementBinding : Window
    {
        public ElementBinding()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //this.Slider.Value = 30;
            this.TextBlock1.FontSize = 30;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Source = this.Slider;
            binding.Path = new PropertyPath("Value");
            binding.Mode = BindingMode.TwoWay;
            this.TextBlock1.SetBinding(TextBlock.FontSizeProperty, binding);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearAllBindings(this.TextBlock1);
        }
    }
}
