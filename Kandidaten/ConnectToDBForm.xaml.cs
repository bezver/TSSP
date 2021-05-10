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
using MySql.Data.MySqlClient;
using System.Data;

namespace Kandidaten
{
    /// <summary>
    /// Interaction logic for ConnectToDBForm.xaml
    /// </summary>
    public partial class ConnectToDBForm : Window
    {
        public ConnectToDBForm()
        {
            InitializeComponent();
        }

        private void CloseDBForm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ConnectToDataBase_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string host = this.Host_TextBox.Text;
                string port = this.Port_TextBox.Text;
                string user = this.User_TextBox.Text;
                string password = this.Password_TextBox.Text;
                string dataBase = this.DataBase_TextBox.Text;

                string connStr = String.Format($"host = {host}; port = {port}; user = {user}; password = {password}; database = {dataBase}");
                MyDatabase tempDB = new MyDatabase(connStr);
                tempDB.connection.Open();
                tempDB.connection.Close();
                MainWindow.db = tempDB;
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
