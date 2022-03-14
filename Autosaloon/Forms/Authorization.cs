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
    public partial class Authorization : Form
    {
        AutosaloonDataSet.UserDataTable userDataTable;

        public Authorization()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            userDataTable = userTableAdapter2.GetData();
            var search = userDataTable.Where(x => x.Email == tb_Email.Text && x.Password == tb_Password.Text);
            
            if(search.Count() == 0)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            else
            {
                Param.login = search.ElementAt(0).Email;
                Param.iduser = search.ElementAt(0).ID;
                Param.idrole = search.ElementAt(0).IDRole;

                switch (Param.idrole)
                {
                    case 6:
                        FormAdmin fa = new FormAdmin();
                        Hide();
                        fa.ShowDialog();
                        Show();
                        break;                    
                    case 8:
                        FormSeller fs = new FormSeller();
                        Hide();
                        fs.ShowDialog();
                        Show();
                        break;
                    case 9:
                        FormWorker fw = new FormWorker();
                        Hide();
                        fw.ShowDialog();
                        Show();
                        break;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
