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
    public partial class FormCompleteWork : Form
    {
        AutosaloonDataSetTableAdapters.DocumentTableAdapter documentTableAdapter = new AutosaloonDataSetTableAdapters.DocumentTableAdapter();
        AutosaloonDataSetTableAdapters.CompletedworkTableAdapter completedworkTableAdapter = new AutosaloonDataSetTableAdapters.CompletedworkTableAdapter();
        AutosaloonDataSetTableAdapters.UserTableAdapter userTableAdapter = new AutosaloonDataSetTableAdapters.UserTableAdapter();
        AutosaloonDataSet.UserDataTable userDataTable;
        public FormCompleteWork()
        {
            InitializeComponent();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                documentTableAdapter.Insert(Param.iduser);
                AutosaloonDataSet.DocumentDataTable documentDataTable;
                documentDataTable = documentTableAdapter.GetData();
                var param = documentDataTable.AsEnumerable().Last();
                int idDocument = param.ID;
                DateTime dt = DateTime.Now;

                completedworkTableAdapter.Insert(tb_Name.Text, tb_LaseName.Text, dt, tb_carNumber.Text, tb_carMark.Text, tb_CompletedWork.Text,idDocument);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void FormCompleteWork_Load(object sender, EventArgs e)
        {
            userDataTable = userTableAdapter.GetData();
            var param2 = userDataTable.FirstOrDefault(x => x.ID == Param.iduser);
            tb_Name.Text = param2.FirstName;
            tb_LaseName.Text = param2.LastName;
        }
    }
}
