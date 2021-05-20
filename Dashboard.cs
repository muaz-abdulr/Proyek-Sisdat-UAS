﻿using System;
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

        bool filmcheck = false;
        bool actorcheck = false;
        bool genrecheck = false;
        bool directorcheck = false;
        int mouseX, mouseY;
        bool mousePressed;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void entityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic x = entityID.Items[entityID.SelectedIndex];
            DescTextBox.Text = x.Bio;
        }
        private void changePanelColor(Color panelColor, params Panel[] pan)
        {
            for(int i = 0; i < pan.Length; i++)
            {
                pan[i].BackColor = panelColor;
            }
        }
        private void searchForMovie_Click(object sender, EventArgs e)
        {
            DataAccess movieData = new DataAccess();
            movie = movieData.getMovieData();
            entityID.DataSource = movie;
            entityID.DisplayMember = "MovieDataID";
            filmcheck = true;
            actorcheck = false;
            genrecheck = false;
            directorcheck = false;
            searchForMovie.BackColor = Color.FromArgb(35, 65, 87);
            changePanelColor(Color.FromArgb(78, 205, 196), topLeft, topRight, highLight);
            highLight.Location = searchForMovie.Location;
            highLight.Visible = true;
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
            searchForActor.BackColor = Color.FromArgb(35, 65, 87);
            changePanelColor(Color.FromArgb(255, 107, 107), topLeft, topRight, highLight);
            highLight.Location = searchForActor.Location;
            highLight.Visible = true;
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
            searchForDirector.BackColor = Color.FromArgb(35, 65, 87);
            changePanelColor(Color.FromArgb(255, 209, 102), topLeft, topRight, highLight);
            highLight.Location = searchForDirector.Location;
            highLight.Visible = true;
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
            searchForGenre.BackColor = Color.FromArgb(35, 65, 87);
            changePanelColor(Color.FromArgb(26, 83, 92), topLeft, topRight, highLight);
            highLight.Location = searchForGenre.Location;
            highLight.Visible = true;
            lblvalue.Text = searchForGenre.Text;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (filmcheck)
            {
                List<RecordCollector.Movie> searched = movie.FindAll(
                    delegate (RecordCollector.Movie x)
                    {
                        return x.film_title.IndexOf(searchText.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    }
                    );
                entityID.DataSource = searched;
                entityID.DisplayMember = "MovieDataID";
            }
            else if (actorcheck)
            {
                List<RecordCollector.Actors> searched = actor.FindAll(
                    delegate (RecordCollector.Actors x)
                    {
                        return x.actor_name.IndexOf(searchText.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    }
                    );
                entityID.DataSource = searched;
                entityID.DisplayMember = "ActorInfo";
            }
            else if (directorcheck)
            {
                List<RecordCollector.sutradara> searched = direct.FindAll(
                    delegate (RecordCollector.sutradara x)
                    {
                        return x.director_name.IndexOf(searchText.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    }
                    );
                entityID.DataSource = searched;
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

        private void borderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void borderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        private void borderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeBttn_Click(object sender, EventArgs e)
        {
            if(this.ClientSize == this.MinimumSize)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeBttn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void searchForMovie_Leave(object sender, EventArgs e)
        {
            searchForMovie.BackColor = Color.FromArgb(22, 44, 59);
        }

        private void searchForActor_Leave(object sender, EventArgs e)
        {
            searchForActor.BackColor = Color.FromArgb(22, 44, 59);
        }

        private void searchForDirector_Leave(object sender, EventArgs e)
        {
            searchForDirector.BackColor = Color.FromArgb(22, 44, 59);
        }

        private void watchlistbutton_Click(object sender, EventArgs e)
        {
            Watchlist f2 = new Watchlist();
            f2.ShowDialog();

        }

        private void searchForGenre_Leave(object sender, EventArgs e)
        {
            searchForGenre.BackColor = Color.FromArgb(22, 44, 59);
        }

    }
}
