using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Salesautopilot_API_Client_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string databaseName = "SapiClient.db";
        private static string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string folderPath = "SapiClient";
        public static string DbPath = Path.Combine(myDocumentsPath, databaseName);
    }
}
