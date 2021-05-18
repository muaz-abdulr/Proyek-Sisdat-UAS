using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisdat_Movie_List
{
    public class RecordCollector //menampung hasil query
    {
        public class columnsName
        {
            public string column_name { get; set; }
        }

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
                    return $" Actor ID : { actor_id }, Actor Name : { actor_name }, Gender : { gender }, Age: { age }";
                }
            }
            public string Bio
            { 
                get
                {
                    return $" { bio }";
                }
            }
        }
        public class movie2                                    //isi dari attribut tabel Actors yang menampung query
        {
            public int film_id { get; set; }
            public string film_title { get; set; }
            public string description { get; set; }
            public string MovieDataID                            //format yang dipakai di UI (Dashboard.cs)
            {
                get
                {
                    return $"ID : {film_id}, title  : {film_title}";
                }
            }
            public string Bio
            {
                get
                {
                    return $"{description}";
                }
            }
        }
        //disini tambah class baru jika ingin menambah output query dengan format yang berbeda
    }
}
