using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesautopilot_API_Client_App.Classes
{
    public class SalesautopilotAPIKey
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string KeyName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
