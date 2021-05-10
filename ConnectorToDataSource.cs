using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisdat_Movie_List
{
    public static class ConnectorToDataSource
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; //fungsi untu memanggil connection string database yang ada di App.config
        }
    }
}
