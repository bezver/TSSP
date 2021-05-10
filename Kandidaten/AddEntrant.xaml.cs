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
    /// Interaction logic for AddEntrant.xaml
    /// </summary>
    public partial class AddEntrant : Window
    {
        public AddEntrant()
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
                
                string firstName   = this.firstNameTextBox.Text;
                string secondName  = this.secondNameTextBox.Text;
                double averageMark = Convert.ToDouble(this.averageMarkTextBox.Text);
                uint schol = Convert.ToUInt32(this.schoolTextBox.Text);
                MainWindow.db.AddEntrant(new Entrant(firstName, secondName, averageMark, schol));
                MessageBox.Show("Операція успішна");
                this.firstNameTextBox.Clear();
                this.secondNameTextBox.Clear();
                this.averageMarkTextBox.Clear();
                this.schoolTextBox.Clear();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.Add_Button.IsEnabled = Autorization.isAutorization;
        }
    }
}
