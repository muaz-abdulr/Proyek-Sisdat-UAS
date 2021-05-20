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
        public Watchlist()
        {
            InitializeComponent();
        }

        private void Watchlist_Load(object sender, EventArgs e)
        {

        }

        private void Watchlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard f1 = new Dashboard();
            this.Hide();
            f1.ShowDialog();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
