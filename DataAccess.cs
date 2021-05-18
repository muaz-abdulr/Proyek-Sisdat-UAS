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
        public List<RecordCollector.Movie> getMovieData()
        {
            List<RecordCollector.Movie> output = connection.Query<RecordCollector.Movie>($"select * from films").ToList();
            return output;
        }
        public List<RecordCollector.Actors> getActorsData()
        {
            List<RecordCollector.Actors> output = connection.Query<RecordCollector.Actors>($"select * from actors").ToList();
            return output;
        }
        public List<RecordCollector.sutradara> getDirectorsData()
        {
            List<RecordCollector.sutradara> output = connection.Query<RecordCollector.sutradara>($"select * from directors").ToList();
            return output;
        }
        public List<RecordCollector.Genre> getGenreData()
        {
            List<RecordCollector.Genre> output = connection.Query<RecordCollector.Genre>($"select * from genres").ToList();
            return output;
        }

        public List<RecordCollector.Movie> searchMovieData(string filmName)
        {
            List<RecordCollector.Movie> output = connection.Query<RecordCollector.Movie>($"select * from films where film_title LIKE '%{ filmName }%'").ToList();
            return output;
        }

        public List<RecordCollector.Actors> searchActorsData(string ActorName)
        {
            List<RecordCollector.Actors> output = connection.Query<RecordCollector.Actors>($"select * from actors where actor_name LIKE '%{ ActorName }%'").ToList();
            return output;
        }

        public List<RecordCollector.sutradara> searchDirectorsData(string DirectorName)
        {
            List<RecordCollector.sutradara> output = connection.Query<RecordCollector.sutradara>($"select * from directors where director_name LIKE '%{ DirectorName }%'").ToList();
            return output;
        }

        public List<RecordCollector.Movie> searchGenreData(string GenreName)
        {
            List<RecordCollector.Movie> output = connection.Query<RecordCollector.Movie>($"select films.film_id, films.film_title, films.description from films inner join genres_in_films ON films.film_id = genres_in_films.film_id  inner join genres ON genres.genre_id = genres_in_films.genre_id  where genre_type LIKE '%{ GenreName }%'").ToList();
            return output;
        }



    }
}
