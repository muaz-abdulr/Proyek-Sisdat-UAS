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
        IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectorToDataSource.CnnVal("Sisdat_Movie_List.Properties.Settings.MovieListConnectionString"));
        public List<RecordCollector.columnsName> GetColumns(string table_name)
        {
            {
                var output = connection.Query<RecordCollector.columnsName>($"select column_name from information_schema.columns where table_name = '{table_name}'").ToList();
                return output;
            }
        }
        public List<dynamic> GetRecord(string table_name) //fungsi yang memanggil query dan menyimpan output dalam list yang didefinisi di RecordCollector.cs
        {
            {
                List<dynamic> output = connection.Query($"select * from {table_name}").ToList();
                return output; //return output dari query
            }
        }
        public List<RecordCollector.movie> getMovieData()
        {
            List<RecordCollector.movie> output = connection.Query<RecordCollector.movie>($"select * from films").ToList();
            return output;
        }
    }
}
