using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class FormWorker : Form
    {
        AutosaloonDataSetTableAdapters.CompletedworkTableAdapter completedworkTableAdapter = new AutosaloonDataSetTableAdapters.CompletedworkTableAdapter();
        AutosaloonDataSet.CompletedworkDataTable completedWorkDataTable;

        public FormWorker()
        {
            InitializeComponent();
        }

        private void bt_OpenOrder_Click(object sender, EventArgs e)
        {
            FormCompleteWork fcw = new FormCompleteWork();
            if (fcw.ShowDialog() == DialogResult.OK)
                UpdateGrid();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            completedWorkDataTable = completedworkTableAdapter.GetData();
            dataGridView1.DataSource = completedWorkDataTable;
        }
    }
}
