﻿using Microsoft.Win32;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
           

        }
        private void Btn_confirm_Click(object sender, RoutedEventArgs e)
        {

            try
            {

             
                Service1Client client = new Service1Client();
                User u = new User();
                u.Login = tb_login.Text;
                u.Password = tb_password.Password;
                u.PasswordConfirmation = tb_conf_password.Password;
                u.Telephone = tb_telephone.Text;
                u.Email = tb_email.Text;
                u.PhotoPath = tb_photopath.Text;
                client.GetUser(u);

                this.Close();
            }

            catch (FaultException<EmptyCyrilicLoginExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException<EmailFormatExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException<PasswordConfirmationExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException<PasswordIndexOutOfRangeExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException<PasswordSpecificCharactersExceptionFault> err)
            {
                MessageBox.Show($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                MessageBox.Show($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException<PhoneFormatExceptionFault> err)
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

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            tb_telephone.Text = String.Empty;
            tb_password.Password = String.Empty;
            tb_conf_password.Password = String.Empty;
            tb_login.Text = String.Empty;
            tb_email.Text = String.Empty;
            tb_photopath.Text = String.Empty;
            gd_img.Visibility = Visibility.Collapsed;
        }

        private void Btn_image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            gd_img.Visibility = Visibility.Visible;
            this.UpdateLayout();
            tb_photopath.Text = file.FileName;
            if (!String.IsNullOrEmpty(tb_photopath.Text))
            {
                user_img.ImageSource = new BitmapImage(new Uri(tb_photopath.Text));
            }
        }
    }
}
