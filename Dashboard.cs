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
        List<RecordCollector.Movie> movie = new List<RecordCollector.Movie>();
        List<RecordCollector.Actors> actor = new List<RecordCollector.Actors>();
        List<RecordCollector.sutradara> direct = new List<RecordCollector.sutradara>();
        List<RecordCollector.Genre> genre = new List<RecordCollector.Genre>();
        List<RecordCollector.columnsName> columns = new List<RecordCollector.columnsName>();

        bool filmcheck = false;
        bool actorcheck = false;
        bool genrecheck = false;
        bool directorcheck = false;

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
            columns = movieData.GetColumns("films");
            movie = movieData.getMovieData();
            entityID.DataSource = movie;
            entityID.DisplayMember = "MovieDataID";
            filmcheck = true;
            actorcheck = false;
            genrecheck = false;
            directorcheck = false;
            lblvalue.Text = searchForMovie.Text;
        }

        private void searchForActor_Click(object sender, EventArgs e)
        {
            DataAccess actorData = new DataAccess();
            actor = actorData.getActorsData();
            entityID.DataSource = actor;
            entityID.DisplayMember = "ActorInfo";
            filmcheck = false;
            actorcheck = true;
            genrecheck = false;
            directorcheck = false;
            lblvalue.Text = searchForActor.Text;

        }
        private void searchForDirector_Click(object sender, EventArgs e)
        {
            DataAccess directorData = new DataAccess();
            direct = directorData.getDirectorsData();
            entityID.DataSource = direct;
            entityID.DisplayMember = "DirectorInfo";
            filmcheck = false;
            actorcheck = false;
            genrecheck = false;
            directorcheck = true;
            lblvalue.Text = searchForDirector.Text;


        }

        private void searchForGenre_Click(object sender, EventArgs e)
        {
            DataAccess genreData = new DataAccess();
            genre = genreData.getGenreData();
            entityID.DataSource = genre;
            entityID.DisplayMember = "GenresInfo";
            filmcheck = false;
            actorcheck = false;
            genrecheck = true;
            directorcheck = false;
            lblvalue.Text = searchForGenre.Text;
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (filmcheck)
            {
                DataAccess search = new DataAccess();
                movie = search.searchMovieData(searchText.Text);
                entityID.DataSource = movie;
                entityID.DisplayMember = "MovieDataID";
            }
            else if (actorcheck)
            {
                DataAccess search = new DataAccess();
                actor = search.searchActorsData(searchText.Text);
                entityID.DataSource = actor;
                entityID.DisplayMember = "ActorInfo";
            }
            else if (directorcheck)
            {
                DataAccess search = new DataAccess();
                direct = search.searchDirectorsData(searchText.Text);
                entityID.DataSource = direct;
                entityID.DisplayMember = "DirectorInfo";
            }
            else if (genrecheck)
            {
                DataAccess search = new DataAccess();
                movie = search.searchGenreData(searchText.Text);
                entityID.DataSource = movie;
                entityID.DisplayMember = "MovieDataID";
            }
         
        }

        private void lblvalue_Click(object sender, EventArgs e)
        {

        }
    }
}
