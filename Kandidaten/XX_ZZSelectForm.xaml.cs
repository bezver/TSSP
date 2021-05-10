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
    /// Interaction logic for XX_ZZSelectForm.xaml
    /// </summary>
    public partial class XX_ZZSelectForm : Window
    {
        MainWindow mw;

        public XX_ZZSelectForm()
        {
            InitializeComponent();
        }

        public XX_ZZSelectForm(MainWindow mainWindow)
        {
            mw = mainWindow;
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
                double averageMark = Convert.ToDouble(this.averageMark.Text);
                uint school = Convert.ToUInt32(this.schoolTextBox.Text);
                List<Entrant> entrants = MainWindow.db.XX_ZZSelection(averageMark, school);
                mw.EntrantsListSet.Items.Clear();
                foreach (var item in entrants)
                {
                    mw.EntrantsListSet.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
