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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MySql.Data.MySqlClient;
using System.Data;


namespace Kandidaten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static string connStr = "host=localhost; port=3306; user=root; password=root; database=kandidaten";
        public static MyDatabase db;

        private void InfoKandidatenForm_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                db = new MyDatabase(connStr);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Current.Shutdown();
            }
        }

        private void XXSearchMenuItem_Click(object sender, RoutedEventArgs e)
        {
            XXSelect temp = new XXSelect(this);
            temp.ShowDialog();
        }

        private void XX_ZZSearchMenuItem_Click(object sender, RoutedEventArgs e)
        {
            XX_ZZSelectForm temp = new XX_ZZSelectForm(this);
            temp.ShowDialog();
        }

        private void AddDataMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddEntrant temp = new AddEntrant();
            temp.ShowDialog();
        }

        private void AuthorizationMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationForm temp = new AuthorizationForm();
            temp.ShowDialog();
        }

        private void DeleteEntrantMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DeleteEntrant temp = new DeleteEntrant();
            temp.ShowDialog();
        }

        private void ConnectDBMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ConnectToDBForm temp = new ConnectToDBForm();
            temp.ShowDialog();
        }

        private void CreateWordFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string WordDocumentPath = "EntrantsResult.docx";
                Xceed.Words.NET.DocX document = Xceed.Words.NET.DocX.Create(WordDocumentPath);

                List<Entrant> entrants = EntrantsListSet.Items.OfType<Entrant>().ToList();

                Xceed.Document.NET.Table table = document.AddTable(entrants.Count + 1, 5);

                table.Rows[0].Cells[0].Paragraphs.First().Append("№");
                table.Rows[0].Cells[1].Paragraphs.First().Append("Прізвище");
                table.Rows[0].Cells[2].Paragraphs.First().Append("Ім'я");
                table.Rows[0].Cells[3].Paragraphs.First().Append("Середній бал");
                table.Rows[0].Cells[4].Paragraphs.First().Append("Номер школи");

                for (int i = 1; i < entrants.Count + 1; i++)
                {
                    table.Rows[i].Cells[0].Paragraphs.First().Append((i).ToString());
                    table.Rows[i].Cells[1].Paragraphs.First().Append(entrants[i - 1].secondName.ToString());
                    table.Rows[i].Cells[2].Paragraphs.First().Append(entrants[i - 1].firstName.ToString());
                    table.Rows[i].Cells[3].Paragraphs.First().Append(entrants[i - 1].averageMark.ToString());
                    table.Rows[i].Cells[4].Paragraphs.First().Append(entrants[i - 1].school.ToString());
                }
                document.InsertTable(table);
                //Xceed.Document.NET.Paragraph paragraph = document.InsertParagraph();

                //List<Entrant> entrants = EntrantsListSet.Items.OfType<Entrant>().ToList();
                //foreach (var item in entrants)
                //{
                //    paragraph.AppendLine(item.ToString());
                //}


                document.Save();
                //if (MyBooks.BookLibrary.VariantForSearch == 1)
                //{
                //    //   document.RemoveParagraph(paragraph);
                //    paragraph.AppendLine(MyBooks.BookLibrary.PlaceBookAfterXYSearchVariant).FontSize(18).Alignment = Alignment.center;
                //    // document.InsertParagraph("Відібрані книги згідно пошуку по року\n");
                //    // document.InsertParagraph("Відібрані книги згідно пошуку по року\n" + MyBooks.BookLibrary.PlaceBookAfterXYSearchVariant);
                //    document.Save();
                //}
                //else
                //{
                //    //   document.RemoveParagraph(paragraph);
                //    paragraph.AppendLine(MyBooks.BookLibrary.NameBookAfterXXSearchVariant).FontSize(14).Alignment = Alignment.left;
                //    document.Save();
                //}
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
