using Salesautopilot_API_Client_App.Classes;
using SQLite;
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

namespace Salesautopilot_API_Client_App
{
    /// <summary>
    /// Interaction logic for AddNewAPIContact.xaml
    /// </summary>
    public partial class AddNewAPIContact : Window
    {
        public AddNewAPIContact()
        {
            InitializeComponent();
        }

        private void addApiContactPanelCancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SalesautopilotAPIKey key = new SalesautopilotAPIKey() 
            {
                KeyName = addAPIContactName.Text,
                Username = addAPIContactKeyUserName.Text,
                Password = addAPIContactKeyPassword.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DbPath))
            {
                conn.CreateTable<SalesautopilotAPIKey>();
                conn.Insert(key);
            }

            MessageBox.Show("Successfully saved!", "Saved for DB!", MessageBoxButton.OK, MessageBoxImage.Information);

            Close();
        }
    }
}
