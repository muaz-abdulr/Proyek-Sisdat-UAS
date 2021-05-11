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
        public Dashboard()
        {
            InitializeComponent();
        }
        private void tableChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess columnsData = new DataAccess();
            List<RecordCollector.columnsName> columns = columnsData.GetColumns(tableChoices.Text);
            columnChoices.DataSource = columns;
            columnChoices.DisplayMember = "column_name";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess recordData = new DataAccess();
            RecordCollector func = new RecordCollector();
            var records = recordData.GetRecord(tableChoices.Text, columnChoices.Text, SearchBox.Text);
            RecordFound.DataSource = func.Record(records);
        }
    }
}
