using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public interface IDb
    {
        string LoadData(string configurationString);
    }
}
