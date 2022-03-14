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
    public partial class OrderSeller : Form
    {        
        AutosaloonDataSetTableAdapters.ClientTableAdapter clientTableAdapter = new AutosaloonDataSetTableAdapters.ClientTableAdapter();
        AutosaloonDataSetTableAdapters.DocumentTableAdapter documentTableAdapter = new AutosaloonDataSetTableAdapters.DocumentTableAdapter();


        public OrderSeller()
        {
            InitializeComponent();
        }

        private void bt_accept_Click(object sender, EventArgs e)
        {
            try
            {
                documentTableAdapter.Insert(Param.iduser);
                AutosaloonDataSet.DocumentDataTable documentDataTable;
                documentDataTable = documentTableAdapter.GetData();
                var param = documentDataTable.AsEnumerable().Last();
                int idDocument = param.ID;
                DateTime dt = DateTime.Now;

                clientTableAdapter.Insert(tb_Name.Text, tb_SecondName.Text, tb_PhoneNumber.Text, tb_NumberCar.Text, tb_BrandCar.Text, dt, tb_Reason.Text, idDocument);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");                
            }            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
