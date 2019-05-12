using System;
using System.Collections.Generic;
using System.Globalization;
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
using WpfDailyPlanner.ServiceReference1;

namespace WpfDailyPlanner
{
    /// <summary>
    /// Interaction logic for UpdateTask.xaml
    /// </summary>
    public partial class UpdateTask : Window
    {
        public UpdateTask()
        {
            InitializeComponent();
        }

        private void Btn_saveTask_Click(object sender, RoutedEventArgs e)
        {

            Service1Client client = new Service1Client();
            var task = client.GetTaskByName(tb_taskname.Text);
            task.Name = tb_taskname.Text;
            task.Description = tb_taskdescr.Text;
            task.Location = tb_location.Text;
            DateTimeFormatInfo dateFormatProvider = new DateTimeFormatInfo();
            dateFormatProvider.ShortDatePattern = "dd/MM/yyyy";
            task.StartDate = DateTime.Parse(dp_start.Text + " " + Convert.ToDateTime(tp_start.Text).ToLongTimeString(), dateFormatProvider);
            task.EndDate = DateTime.Parse(dp_end.Text + " " + Convert.ToDateTime(tp_end.Text).ToLongTimeString(), dateFormatProvider);
            task.Group = client.GetGroupbyName(cb_group.SelectedItem.ToString());
            client.UpdateTask(task, tb_taskname.Text);

         
        }

        private void Cb_group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
