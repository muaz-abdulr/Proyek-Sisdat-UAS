using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisdat_Movie_List
{
    public class RecordCollector //menampung hasil query
    {
        public List<string> Record(List<dynamic> recordList)    //format record secara general, output => "{column1Val1} {column2Val1}..."
        {
            List<string> strList = new List<string>();
            for(int i = 0; i < recordList.Count; i++)
            {
                string output = "";
                foreach (dynamic record in recordList[i])
                {
                    string temp = record.Value.ToString();
                    output += temp + " ";
                }
                strList.Add(output);
            }
            return strList;
        }
        public class Actors                                     //isi dari attribut tabel Actors yang menampung query
        {
            public int actor_id {get; set;}
            public string actor_name { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string bio { get; set; }
            public string ActorInfo                            //format yang dipakai di UI (Dashboard.cs)
            {
                get
                {
                    return $"{ actor_name }";
                }
            }
            public string Bio
            { 
                get
                {
                    return $"Age\t\t: {age}\nGender\t: {gender}\nDescription\n{ bio }";
                }
            }
        }
        public class Movie
        {
            public int film_id { get; set; }
            public string film_title { get; set; }
            public string description { get; set; }
            public string MovieDataID
            {
                get
                {
                    return $"{film_title}";
                }
            }
            public string Bio
            {
                get
                {
                    return $"Description\n{description}";
                }
            }
        }
        //disini tambah class baru jika ingin menambah output query dengan format yang berbeda
        public class sutradara
        {
            public int director_id { get; set; }
            public string director_name { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string bio { get; set; }
   
            public string DirectorInfo
            {
                get
                {
                    return $"{ director_name }";
                }
            }
            public string Bio
            {
                get
                {
                    return $"Age\t\t: {age}\nGender\t: {gender}\nDescription\n{ bio }";
                }
            }
        }

        public class Genre
        {
            public int genre_id { get; set; }
            public string genre_type { get; set; }

            public string GenresInfo
            {
                get
                {
                    return $"{genre_type}";
                }
            }
            public string Bio
            {
                get
                {
                    return $"";
                }
            }
        }

    }
}
