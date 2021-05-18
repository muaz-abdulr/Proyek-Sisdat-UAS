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
        List<RecordCollector.sutradara> sutradara = new List<RecordCollector.sutradara>();

        public Dashboard()
        {
            InitializeComponent();

        }

        private void entityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic x = entityID.Items[entityID.SelectedIndex];
            DescTextBox.Text = x.Bio;



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

        private void searchForDirector_Click(object sender, EventArgs e)
        {
            DataAccess directorData = new DataAccess();
            sutradara = directorData.getDirectorsData();
            entityID.DataSource = sutradara;
            entityID.DisplayMember = "DirectorInfo";

        }
    }
}
