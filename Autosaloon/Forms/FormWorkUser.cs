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
    public partial class FormWorkUser : Form
    {
        AutosaloonDataSetTableAdapters.RoleTableAdapter roleTableAdapter = new AutosaloonDataSetTableAdapters.RoleTableAdapter();
        AutosaloonDataSetTableAdapters.UserTableAdapter userTableAdapter = new AutosaloonDataSetTableAdapters.UserTableAdapter();
        AutosaloonDataSet.UserRoleRow userroleRow;
        string sex;

        public FormWorkUser(AutosaloonDataSet.UserRoleRow _userroleRow)
        {
            InitializeComponent();
            this.userroleRow = _userroleRow;

            switch (Param.mode)
            {
                case "Редактирование":
                    tb_Name.Text = userroleRow.FirstName;
                    tb_SecondName.Text = userroleRow.LastName;
                    datePicker.Value = userroleRow.Birthday;
                    tb_PhoneNumber.Text = userroleRow.PhoneNumber;
                    if (userroleRow.Sex == "М")
                        rb_M.Checked = true;
                    if (userroleRow.Sex == "Ж")
                        rb_J.Checked = true;
                    cb_role.DataSource = roleTableAdapter.GetData();
                    cb_role.DisplayMember = "Title";
                    cb_role.ValueMember = "ID";
                    tb_Email.Text = userroleRow.Email;
                    tb_Password.Text = userroleRow.Password;
                    break;
                case "Добавить":
                    cb_role.DataSource = roleTableAdapter.GetData();
                    cb_role.DisplayMember = "Title";
                    cb_role.ValueMember = "ID";
                    break;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_M.Checked == true)
                sex = "М";
            if (rb_J.Checked == true)
                sex = "Ж";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Param.mode)
            {
                case "Добавить":
                    try
                    {
                        userTableAdapter.Insert(tb_Name.Text, tb_SecondName.Text, datePicker.Value, tb_PhoneNumber.Text, sex, (int)cb_role.SelectedValue, tb_Email.Text, tb_Password.Text);
                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong");                       
                    }
                    break;
                case "Редактирование":
                    try
                    {
                        userroleRow.FirstName = tb_Name.Text;
                        userroleRow.LastName = tb_SecondName.Text;
                        userroleRow.Birthday = datePicker.Value;
                        userroleRow.PhoneNumber = tb_PhoneNumber.Text;
                        userroleRow.Sex = sex;
                        userroleRow.IDRole = (int)cb_role.SelectedValue;
                        userroleRow.Email = tb_Email.Text;
                        userroleRow.Password = tb_Password.Text;

                        userTableAdapter.Update(userroleRow);

                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong");
                    }                    
                    break;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
