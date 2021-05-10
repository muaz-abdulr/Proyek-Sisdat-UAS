using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisdat_Movie_List
{
    public class RecordCollector
    {
        public class Actors
        {
            public int actor_id {get; set;}
            public string actor_name { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string bio { get; set; }
            public string ActorsInfo
            {
                get
                {
                    return $"{ actor_id } { actor_name } { gender } { age } { bio }";
                }
            }
        }
    }
}
