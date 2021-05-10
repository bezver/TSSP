using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kandidaten
{
    /// <summary>
    /// Interaction logic for AuthorizationForm.xaml
    /// </summary>
    public partial class AuthorizationForm : Window
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                string username = this.usernameTextBox.Text;
                string password = this.passwordTextBox.Text;

                Autorization.Login(username, password);

                MessageBox.Show("Операція успішна");
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
