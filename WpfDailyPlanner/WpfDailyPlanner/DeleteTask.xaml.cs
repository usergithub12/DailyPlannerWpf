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
using WpfDailyPlanner.ServiceReference1;

namespace WpfDailyPlanner
{
    /// <summary>
    /// Interaction logic for DeleteTask.xaml
    /// </summary>
    public partial class DeleteTask : Window
    {
        public DeleteTask()
        {
            InitializeComponent();
            Service1Client client = new Service1Client();

            foreach (var item in client.GetGroups())
            {
                if (item.Name != null)
                {
                    cb_group.Items.Add(item.Name.ToString());
                }
            }
        }

        private void Cb_group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb_tasks.Items.Clear();
            if (cb_group.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(cb_group.Text))
                {
                    Service1Client client = new Service1Client();
                    foreach (var item in client.GetTasksFromGroup(cb_group.Text))
                    {

                        lb_tasks.Items.Add(item.Name);
                    }
                }
            }
        }

        private void Btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            Service1Client service1Client = new Service1Client();
            service1Client.DeleteTaskByName(tb_TaskName.Text);
            lb_tasks.Items.Refresh();
            this.Close();
        }

        private void Lb_tasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lb_tasks.SelectedIndex!=-1)
            {
                tb_TaskName.Text = lb_tasks.SelectedItem.ToString();
            }
        }
    }
}
