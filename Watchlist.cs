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
    public partial class Watchlist : Form
    {
        List<RecordCollector.Movie> movie = new List<RecordCollector.Movie>();
        List<RecordCollector.WL> watchL = new List<RecordCollector.WL>();
        public Watchlist()
        {
            InitializeComponent();
        }
        private void refreshWL()
        {
            DataAccess wl = new DataAccess();
            watchL = wl.getWL();
            watchlistList.DataSource = watchL;
            watchlistList.DisplayMember = "list";
        }

        private void Watchlist_Load(object sender, EventArgs e)
        {
            DataAccess movData = new DataAccess();
            movie = movData.getMovieData();
            filmList.DataSource = movie;
            filmList.DisplayMember = "MovieDataID";
            refreshWL();
        }

        private void Watchlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            dynamic x = watchlistList.Items[watchlistList.SelectedIndex];
            dynamic y = filmList.Items[filmList.SelectedIndex];
            DataAccess wl = new DataAccess();
            wl.updateWL(x.watchlistID, y.film_id, dateTimeWatchlist.Value.ToString());
            refreshWL();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DataAccess wl = new DataAccess();
            dynamic x = watchlistList.Items[watchlistList.SelectedIndex];
            wl.deleteWL(x.watchlistID);
            refreshWL();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            DataAccess wl = new DataAccess();
            dynamic films = filmList.Items[filmList.SelectedIndex];
            wl.insertWL(films.film_id, dateTimeWatchlist.Text);
            refreshWL();
        }

        private void watchlistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic x = watchlistList.Items[watchlistList.SelectedIndex];
            dateTimeWatchlist.Value = DateTime.Parse(x.watchschedule);
            filmList.SelectedItem = movie.Find(
                delegate (RecordCollector.Movie mv)
                {
                    return mv.film_title == x.film_title;
                }
                );
        }
    }
}
