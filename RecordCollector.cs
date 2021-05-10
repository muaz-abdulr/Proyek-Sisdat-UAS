using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisdat_Movie_List
{
    public class RecordCollector //menampung hasil query
    {
        public class Actors //isi dari attribut tabel Actors yang menampung query
        {
            public int actor_id {get; set;}
            public string actor_name { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string bio { get; set; }
            public string ActorsInfo //yang akan dipanggil di UI (Dashboard.cs)
            {
                get
                {
                    return $"{ actor_id } { actor_name } { gender } { age } { bio }";
                }
            }
        }
        //disini tambah class baru jika ingin menambah output query dengan isi yang berbeda
    }
}
