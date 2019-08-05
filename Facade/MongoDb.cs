using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class MongoDb : IDb
    {
        public string LoadData(string configurationString)
        {
            //doing some MongoDb-Query here, getting configuration
            return ""; //return string, loaded from database
        }
    }
}
