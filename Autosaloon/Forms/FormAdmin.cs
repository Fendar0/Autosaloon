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
    public partial class FormAdmin : Form
    {
        AutosaloonDataSetTableAdapters.UserRoleTableAdapter userroleAdapter = new AutosaloonDataSetTableAdapters.UserRoleTableAdapter();
        AutosaloonDataSet.UserRoleDataTable userroleDataTable;
        AutosaloonDataSet.UserRoleRow userroleRow;

        AutosaloonDataSetTableAdapters.ClientDocUserTableAdapter clientDocUserTableAdapter = new AutosaloonDataSetTableAdapters.ClientDocUserTableAdapter();
        AutosaloonDataSet.ClientDocUserDataTable clientDocUserDataTable;

        AutosaloonDataSetTableAdapters.CompletedworkTableAdapter completedworkTableAdapter = new AutosaloonDataSetTableAdapters.CompletedworkTableAdapter();
        AutosaloonDataSet.CompletedworkDataTable completedWorkDataTable;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Param.mode = "Редактирование";
            DataRowView dtRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            userroleRow = (AutosaloonDataSet.UserRoleRow)dtRow.Row;

            if(dtRow != null)
            {
                FormWorkUser fwu = new FormWorkUser(userroleRow);
                if (fwu.ShowDialog() == DialogResult.OK)
                    Update();                
            }
            else
            {
                MessageBox.Show("Somthing went wrong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Param.mode = "Добавить";
            FormWorkUser fwu = new FormWorkUser(null);
            if(fwu.ShowDialog() == DialogResult.OK)
                Update();
        }

        public void Update()
        {
            userroleDataTable = userroleAdapter.GetData();
            dataGridView1.DataSource = userroleDataTable;
        }

        private void rb_work_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_user.Checked == true)
            {
                userroleDataTable = userroleAdapter.GetData();
                dataGridView1.DataSource = userroleDataTable;
            }
            else if (rb_clients.Checked == true)
            {
                clientDocUserDataTable = clientDocUserTableAdapter.GetData();
                dataGridView1.DataSource = clientDocUserDataTable;
            }
            else if (rb_work.Checked == true)
            {
                completedWorkDataTable = completedworkTableAdapter.GetData();
                dataGridView1.DataSource = completedWorkDataTable;
            }
        }
    }
}
