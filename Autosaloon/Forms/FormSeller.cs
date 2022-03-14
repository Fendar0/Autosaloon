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
    public partial class FormSeller : Form
    {
        AutosaloonDataSetTableAdapters.ClientDocUserTableAdapter clientDocUserTableAdapter = new AutosaloonDataSetTableAdapters.ClientDocUserTableAdapter();

        AutosaloonDataSet.ClientDocUserDataTable clientDocIserDataTable;
        public FormSeller()
        {
            InitializeComponent();            
        }

        private void bt_OpenOrder_Click(object sender, EventArgs e)
        {
            OrderSeller os = new OrderSeller();
            if (os.ShowDialog() == DialogResult.OK)
                Update();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSeller_Load(object sender, EventArgs e)
        {
            Update();
        }

        public void Update()
        {
            clientDocIserDataTable = clientDocUserTableAdapter.GetData();
            dataGridView1.DataSource = clientDocIserDataTable;
        }
    }
}
