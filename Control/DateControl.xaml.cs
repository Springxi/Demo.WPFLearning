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

namespace Demo.WPFLearning.Control
{
    /// <summary>
    /// DateControl.xaml 的交互逻辑
    /// </summary>
    public partial class DateControl : Window
    {
        public DateControl()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
           Title = Calendar.SelectedDate.ToString();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            for (int i = 0; i < Calendar.SelectedDates.Count; i++)
            {
                s += Calendar.SelectedDates[i].ToString()+" ";
            }
           
            Title = s;
        }

        private void DatePicker_DateValidationError(object sender, DatePickerDateValidationErrorEventArgs e)
        {
            MessageBox.Show(e.Text + " is not a valid value because " + e.Exception.Message);
        }
    }
}
