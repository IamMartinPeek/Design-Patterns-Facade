using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    //Facade
    public class SetUp
    {
        IDb _MongoDb = new MongoDb();
        IDb _MySql = new MySql();
        IDb _SQLite = new SQLite();
        public IDictionary<string, string> LoadSetUpData()
        {
            Dictionary<string, string> information = new Dictionary<string, string>();
            information.Add("IP-Address", _SQLite.LoadData("IP-Address"));
            information.Add("Port", _SQLite.LoadData("Port"));
            information.Add("Report", _MongoDb.LoadData("Report"));
            information.Add("UsersLoggedIn", _MySql.LoadData("UsersLoggedIn"));
            return information;

        }
    }
}
