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
        public List<RecordCollector.Actors> GetActor(string actor_name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sisdat_Movie_List.Properties.Settings.MovieList")))
            {
                var output = connection.Query<RecordCollector.Actors>($"select * from actors where actor_name = '{actor_name}'").ToList();
                return output;
            }
        }
    }
}
