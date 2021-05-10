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
        List<RecordCollector.Actors> actor_list = new List<RecordCollector.Actors>();
        public Dashboard()
        {
            InitializeComponent();
            ActorFound.DataSource = actor_list;
            ActorFound.DisplayMember = "ActorsInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess actorDb = new DataAccess();
            actor_list = actorDb.GetActor(ActorSearchBox.Text);
            ActorFound.DataSource = actor_list;
            ActorFound.DisplayMember = "ActorsInfo";
        }
    }
}
