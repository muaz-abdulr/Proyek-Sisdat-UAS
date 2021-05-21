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
        public List<dynamic> GetRecord(string table_name) //fungsi yang memanggil query dan menyimpan output dalam list yang didefinisi di RecordCollector.cs
        {
            {
                List<dynamic> output = connection.Query($"select * from {table_name}").ToList();
                return output; //return output dari query
            }
        }
        public List<RecordCollector.Movie> getMovieData()
        {
            List<RecordCollector.Movie> output = connection.Query<RecordCollector.Movie>($"exec getMovieData").ToList();
            return output;
        }
        public List<RecordCollector.Actors> getActorsData()
        {
            List<RecordCollector.Actors> output = connection.Query<RecordCollector.Actors>($"exec getActorsData").ToList();
            return output;
        }
        public List<RecordCollector.sutradara> getDirectorsData()
        {
            List<RecordCollector.sutradara> output = connection.Query<RecordCollector.sutradara>($"exec getDirectorsData").ToList();
            return output;
        }
        public List<RecordCollector.Genre> getGenreData()
        {
            List<RecordCollector.Genre> output = connection.Query<RecordCollector.Genre>($"exec getGenreData").ToList();
            return output;
        }
        public List<RecordCollector.WL> getWL()
        {
            List<RecordCollector.WL> output = connection.Query<RecordCollector.WL>($"select watchlist.watchlistID, watchlist.film_id, watchlist.watchschedule, films.film_title from watchlist inner join films on films.film_id = watchlist.film_id").ToList();
            return output;
        }
        public void insertWL(int film_id, string dateTime)
        {
            connection.Query($"insert into watchlist values ({film_id}, '{dateTime}')");
        }
        public void updateWL(int watchlistID,int film_id, string dateTime)
        {
            connection.Query($"update watchlist set film_id = {film_id}, watchschedule = '{dateTime}' where watchlistID = {watchlistID}");
        }
        public void deleteWL(int watchlistID)
        {
            connection.Query($"delete from watchlist where watchlistID = {watchlistID}");
        }
        public List<RecordCollector.Movie> searchGenreData(string GenreName)
        {
            List<RecordCollector.Movie> output = connection.Query<RecordCollector.Movie>($"select films.film_id, films.film_title, films.description from films inner join genres_in_films ON films.film_id = genres_in_films.film_id  inner join genres ON genres.genre_id = genres_in_films.genre_id  where genre_type LIKE '%{ GenreName }%'").ToList();
            return output;
        }
    }
}
