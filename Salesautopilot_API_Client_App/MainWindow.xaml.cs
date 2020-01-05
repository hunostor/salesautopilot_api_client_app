using Salesautopilot_API_Client_App.Classes;
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

namespace Salesautopilot_API_Client_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadDatabase();
        }

        private void addApiContactPopUpButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewAPIContact addNewAPIContact = new AddNewAPIContact();
            addNewAPIContact.Show();

            ReadDatabase();
        }

        void ReadDatabase()
        {
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DbPath))
            {
                conn.CreateTable<SalesautopilotAPIKey>();
                var contacts = conn.Table<SalesautopilotAPIKey>().ToList();
            }
        }
    }
}
