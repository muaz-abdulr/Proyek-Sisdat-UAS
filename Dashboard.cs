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
        List<RecordCollector.movie2> movie = new List<RecordCollector.movie2>();
        List<RecordCollector.Actors> actor = new List<RecordCollector.Actors>();

        public Dashboard()
        {
            InitializeComponent();

        }

        private void entityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchForActor_Click)
            {
                DataAccess mov = new DataAccess();
                List<RecordCollector.movie2> movData = mov.getMovieData();
                DescTextBox.Text = movData[entityID.SelectedIndex].MovieDesc;

            }
            else if (searchForMovie_Click)
     
        }

        private void searchForMovie_Click(object sender, EventArgs e)
        {
            DataAccess movieData = new DataAccess();
            movie = movieData.getMovieData();
            entityID.DataSource = movie;
            entityID.DisplayMember = "MovieDataID";

        }

        private void searchForActor_Click(object sender, EventArgs e)
        {
            DataAccess actorData = new DataAccess();
            actor = actorData.getActorsData();
            entityID.DataSource = actor;
            entityID.DisplayMember = "ActorInfo";

        }
    }
}
