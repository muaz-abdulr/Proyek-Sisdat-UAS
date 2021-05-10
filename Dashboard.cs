using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisdat_Movie_List
{
    public partial class Dashboard : Form
    {
        List<RecordCollector.Actors> actor_list = new List<RecordCollector.Actors>();   //deklarasi list dari class di RecordColector.cs
        public Dashboard()
        {
            InitializeComponent();
            ActorFound.DataSource = actor_list;
            ActorFound.DisplayMember = "ActorsInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e) //command yang akan dieksekusi ketika search button di click
                                                                    //SearchButton merupakan nama variabel yang dideklarasi di Dashboard.cs
        {
            DataAccess actorDb = new DataAccess();                  //deklarasi dari class DataAccess.cs
            actor_list = actorDb.GetActor(ActorSearchBox.Text);     //list diisi lewat fungsi GetActor()
                                                                    //argumen yang dipassing adalah isi dari textbox
                                                                    //variabel textbox dideklarasi di dashboard.cs dengan nama ActorSearchBox

            ActorFound.DataSource = actor_list;                     //datasource dari listbox ActorFound (ada di Dashboard.cs)
            ActorFound.DisplayMember = "ActorsInfo";                //format output berdasarkan ActorsInfo di RecordCollector.cs
        }
    }
}
