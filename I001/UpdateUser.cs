using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I001
{
    public partial class UpdateUser : Form
    {
        int Id;
        public UpdateUser(int ID, string Name, string Login, string Password, string Role)
        {
            Id = ID;
            InitializeComponent();
            txtName.Text = Name;
            txtLogin.Text = Login;
            txtPassword.Text = Password;
            txtRole.Text = Role;
        }

        private void pbBackTo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            Glavnoe view = new Glavnoe();
            view.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPassword.Text != "" && txtName.Text != "" && txtRole.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = I001CRUD; Persist Security Info=True; User ID = student; Password = passw0rd"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE [Users] SET Name='" + txtName.Text + "', Login='" + txtLogin.Text + "', Password='" + txtPassword.Text + "',  IsAdmin='" + txtRole.Text + "' Where [Users].ID =" + Id;
                        cmd.ExecuteScalar();
                        conn.Close();

                        Glavnoe view = new Glavnoe();
                        view.Visible = true;
                        view.ShowInTaskbar = true;
                        this.Close();
                        GC.Collect();
                    }
                    catch (Exception ex)
                    {

                        if ("-2146232060" == Convert.ToString(ex.HResult))
                        {
                            MessageBox.Show("Логин занят");
                        }
                        else
                        {
                            MessageBox.Show(Convert.ToString(ex));
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void txtRole_KeyPress(object sender, KeyPressEventArgs e) //ограничение возможностей ввода для поля txtRole
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
