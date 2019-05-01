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
    /// Interaction logic for DailyTask.xaml
    /// </summary>
    public partial class DailyTask : Window
    {
        public DailyTask()
        {
            InitializeComponent();

            TextBlock textBlock = new TextBlock();
            textBlock.Text = "ky";//tb_taskdescr.Text;
            Thickness margin = new Thickness();
            margin.Left = 16;
            margin.Top = 16;
            margin.Right = 12;
            margin.Bottom = 8;
           // textBlock.Margin = margin;
              //    textBlock.Style.Resources.Add( "StaticResource", "MaterialDesignUserForegroundCheckBox");
            Thickness margincb = new Thickness();
            margincb.Left = 16;
            margincb.Top = 4;
            margincb.Right = 16;
            margincb.Bottom = 0;
    
            CheckBox checkBox = new CheckBox();
           // checkBox.Margin = margincb;
            
            st_notes.Children.Add(checkBox);
            st_notes.Children.Add(textBlock);

         
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            Service1Client service1Client = new Service1Client();
            DailyTaskNotes dailyTask = new DailyTaskNotes();
            dailyTask.Description = tb_taskdescr.Text;
            dailyTask.Name = tb_taskname.Text;
            dailyTask.Location = tb_location.Text;
            dailyTask.StartDate = DateTime.Parse(dp_start.Text);
            dailyTask.EndDate = DateTime.Parse(dp_end.Text);
          
                
            service1Client.GetTaskToAdd(dailyTask);
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
