﻿using System;
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
            public string ActorsInfo                            //format yang dipakai di UI (Dashboard.cs)
            {
                get
                {
                    return $"{ actor_id } { actor_name } { gender } { age } { bio }";
                }
            }
        }
        //disini tambah class baru jika ingin menambah output query dengan format yang berbeda
    }
}
