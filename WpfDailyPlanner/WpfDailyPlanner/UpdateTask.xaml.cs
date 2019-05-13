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
        public string updatetask { get; set; }
        public UpdateTask()
        {
            InitializeComponent();
            Service1Client client = new Service1Client();

            foreach (var item in client.GetGroups())
            {
                if (!item.IsDeleted)
                {
                    if (item.Name != null)
                    {
                        cb_group.Items.Add(item.Name.ToString());
                    }
                }
            }
        }

        private void Btn_saveTask_Click(object sender, RoutedEventArgs e)
        {

            Service1Client client = new Service1Client();

            var task = client.GetTaskByName(updatetask);

            task.Name = tb_taskname.Text;
            task.Description = tb_taskdescr.Text;
            task.Location = tb_location.Text;
            DateTimeFormatInfo dateFormatProvider = new DateTimeFormatInfo();
            dateFormatProvider.ShortDatePattern = "dd/MM/yyyy";
            task.StartDate = DateTime.Parse(dp_start.Text + " " + Convert.ToDateTime(tp_start.Text).ToLongTimeString(), dateFormatProvider);
            task.EndDate = DateTime.Parse(dp_end.Text + " " + Convert.ToDateTime(tp_end.Text).ToLongTimeString(), dateFormatProvider);

            if (client.GetGroupbyName(cb_group.SelectedItem.ToString()) != null)
            {
                task.Group = client.GetGroupbyName(cb_group.SelectedItem.ToString());
            }
         
            client.UpdateTask(task);


            this.Close();
        }

        private void Cb_group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
