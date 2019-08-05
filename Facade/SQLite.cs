using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class SQLite : IDb
    {
        public string LoadData(string configurationString)
        {
            //doing some SQlite-Query here, getting configuration
            return ""; //return string, loaded from database
        }
    }
}
