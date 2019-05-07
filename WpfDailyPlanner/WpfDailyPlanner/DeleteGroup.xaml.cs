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
    /// Interaction logic for DeleteGroup.xaml
    /// </summary>
    public partial class DeleteGroup : Window
    {
        public DeleteGroup()
        {
            InitializeComponent();
        }

        private void Btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();
        
            client.DeleteGroupByName(tb_GroupName.Text);
            this.Close();
        }
    }
}
