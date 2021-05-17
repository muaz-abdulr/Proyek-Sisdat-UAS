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
            DataAccess x = new DataAccess();
            RecordCollector y = new RecordCollector();
            var recordList = x.GetRecord("films");
            var output = y.Record(recordList);
            RecordList.DataSource = output;
        }
    }
}
