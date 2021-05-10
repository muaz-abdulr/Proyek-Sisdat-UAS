using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Sisdat_Movie_List
{
    public class DataAccess
    {
        public List<RecordCollector.Actors> GetActor(string actor_name) //menampung output dari query dalam list yang didefinisi di RecordCollector.cs
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectorToDataSource.CnnVal("Sisdat_Movie_List.Properties.Settings.MovieList"))) //pemanggilan CnnVAl() dengan argumen nama db di App.config
            {
                var output = connection.Query<RecordCollector.Actors>($"select * from actors where actor_name = '{actor_name}'").ToList(); //query ke database
                return output; //return output dari query
            }
        }
    }
}
