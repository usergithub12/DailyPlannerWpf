using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Btn_sign_in_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                Service1Client client = new Service1Client();
               
                 var  u = client.GetUserbyName(tb_login.Text);
                
              
                DailyTask task = new DailyTask();
                task.tb_username.Text = tb_login.Text;
                task.tb_updatelogin.Text = tb_login.Text;
                task.tb_updatepassword.Text = tb_password.Password;
            
                if (!String.IsNullOrEmpty(u.PhotoPath))
                {
                    task.user_img.ImageSource = new BitmapImage(new Uri(u.PhotoPath));
                }

                this.Close();
                task.ShowDialog();
            }
            catch (FaultException<MyExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException<PasswordEqualsInDataBaseExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException fe)
            {
                MessageBox.Show($"Error - {fe}");
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show("Null exception");
            }
            catch (Exception)
            {
                MessageBox.Show("Useless block");

            }



        }

        private void Btn_sign_up_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
           
        }
    }
}
