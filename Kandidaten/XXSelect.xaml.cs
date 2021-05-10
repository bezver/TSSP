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
    /// Interaction logic for XXSelect.xaml
    /// </summary>
    public partial class XXSelect : Window
    {
        MainWindow mw;

        public XXSelect()
        {
            InitializeComponent();
        }

        public XXSelect(MainWindow mainForm)
        {
            mw = mainForm;
            InitializeComponent();
        }

        private void CloseFormXX(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SearchEntrantXX(object sender, RoutedEventArgs e)
        {
            try
            {
                double averageMark = Convert.ToDouble(this.averageMark.Text);
                List<Entrant> entrants = MainWindow.db.XXSelection(averageMark);
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
