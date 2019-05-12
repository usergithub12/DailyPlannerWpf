using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for DailyTask.xaml
    /// </summary>
    public partial class DailyTask : Window
    {
        public DailyTask()
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


        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            Service1Client service1Client = new Service1Client();
            DailyTaskNotes dailyTask = new DailyTaskNotes();
            dailyTask.Description = tb_taskdescr.Text;
            dailyTask.Name = tb_taskname.Text;
            dailyTask.Location = tb_location.Text;
            dailyTask.IsDeleted = false;
            DateTimeFormatInfo dateFormatProvider = new DateTimeFormatInfo();
            dateFormatProvider.ShortDatePattern = "dd/MM/yyyy";
            dailyTask.StartDate = DateTime.Parse(dp_start.Text + " " + Convert.ToDateTime(tp_start.Text).ToLongTimeString(), dateFormatProvider);
            dailyTask.EndDate = DateTime.Parse(dp_end.Text + " " + Convert.ToDateTime(tp_end.Text).ToLongTimeString(), dateFormatProvider);


            if (service1Client.GetGroupbyName(cb_group.Text) != null)
            {
                if (!service1Client.GetGroupbyName(cb_group.Text).IsDeleted)
                {
                    dailyTask.Group = service1Client.GetGroupbyName(cb_group.Text);
                }
            }
            service1Client.GetTaskToAdd(dailyTask);
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            DeleteTask deleteTask = new DeleteTask();
            deleteTask.Owner = this;
            deleteTask.ShowDialog();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cb_group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //st_notes.Children.Clear();
            //if (cb_group.SelectedIndex != -1)
            //{
            //    TextBlock textBlock = new TextBlock();
            //    textBlock.Text = "Task List";
            //    textBlock.FontSize = 16;
            //    textBlock.FontWeight = FontWeights.Bold;
            //    Thickness margin = new Thickness();
            //    margin.Left = 16;
            //    margin.Top = 16;
            //    margin.Right = 12;
            //    margin.Bottom = 8;
            //    textBlock.Margin = margin;

            //    st_notes.Children.Add(textBlock);


            //    if (!String.IsNullOrEmpty(cb_group.Text))
            //    {
            //        Service1Client client = new Service1Client();
            //        Thickness margincb = new Thickness();

            //        margincb.Left = 16;
            //        margincb.Top = 4;
            //        margincb.Right = 16;
            //        margincb.Bottom = 0;
            //        foreach (var item in client.GetTasksFromGroup(cb_group.SelectedItem.ToString()))
            //        {
            //            if (!item.IsDeleted)
            //            {
            //                CheckBox checkBox = new CheckBox();

            //                checkBox.Margin = margincb;

            //                checkBox.Content = item.Name;
            //                st_notes.Children.Add(checkBox);
            //            }
            //        }
            //    }

            //}
        }

        private void Btn_addgroup_Click(object sender, RoutedEventArgs e)
        {

            AddGroup addGroup = new AddGroup();
            addGroup.Owner = this;
            addGroup.ShowDialog();

            Service1Client client = new Service1Client();

            cb_group.Items.Clear();
            foreach (var item in client.GetGroups())
            {
                if (item.Name != null)
                {
                    if (!item.IsDeleted)
                    {
                        cb_group.Items.Add(item.Name.ToString());
                    }
                }
            }
        }

        private void Btn_saveuser_Click(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();
            var user = client.GetUserbyName(tb_username.Text);
            user.Login = tb_updatelogin.Text;
            user.Password = tb_updatepassword.Text;
            user.Telephone = tb_updatephone.Text;
            user.PasswordConfirmation = tb_updatepassword.Text;
            user.Email = tb_updateEmail.Text;
            client.UpdateUser(user, tb_username.Text);
            tb_username.Text = tb_updatelogin.Text;
        }

        private void Cl_datepick_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            lb_showtasks.Visibility = Visibility.Visible;
            lb_showtasks.Items.Clear();
            if (cl_datepick.SelectedDate != null)
            {
                Service1Client client = new Service1Client();

                foreach (var item in client.GetTasksByDate(DateTime.Parse(cl_datepick.SelectedDate.ToString())))
                {
                    if (client.GetTasksByDate(DateTime.Parse(cl_datepick.SelectedDate.ToString())).Count() > 0)
                    {

                        if (!item.IsDeleted)
                        {
                            if (item.Group != null)
                            {
                                CheckBox checkBox = new CheckBox();
                                Thickness margincb = new Thickness();
                                margincb.Left = 16;
                                margincb.Top = 4;
                                margincb.Right = 16;
                                margincb.Bottom = 0;
                                checkBox.Margin = margincb;

                                //checkBox.Content = $" Name: {item.Name}" + "\n" + $" Group: {item.Group.Name}" + "\n" + $" Description: {item.Description}" + "\n" + $" StartDate: {item.StartDate} " + "\n" + $" EndDAte: {item.EndDate} " + "\n" + $" Location: {item.Location}";
                                checkBox.Content = item.Name;

                                lb_showtasks.Items.Add(checkBox);
                            }
                        }
                    }
                }

            }

        }

        private void Btn_deletegroup_Click(object sender, RoutedEventArgs e)
        {
            DeleteGroup deleteGroup = new DeleteGroup();
            deleteGroup.Owner = this;
            if (cb_group.SelectedIndex != -1)
            {
                deleteGroup.tb_GroupName.Text = cb_group.SelectedValue.ToString();
            }
            deleteGroup.ShowDialog();
            cb_group.Items.Refresh();
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Lb_showtasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            UpdateTask updateTask = new UpdateTask();
            var cb = lb_showtasks.SelectedValue as CheckBox;
            updateTask.tb_taskname.Text = cb.Content.ToString();
            updateTask.ShowDialog();
        }
    }
}