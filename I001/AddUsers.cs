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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
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
                using (SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = I001CRUD; Persist Security Info=True; User ID = student; Password = passw0rd"))
                {
                    try
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT Users (Name, Login, Password, IsAdmin) VALUES ('" + txtName.Text + "','" + txtLogin.Text + "','" + txtPassword.Text + "','" + txtRole.Text + "')";
                        cmd.ExecuteScalar();
                        con.Close();

                        this.Hide();
                        Glavnoe info = new Glavnoe();
                        info.Visible = true;
                        info.ShowInTaskbar = true;



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
                MessageBox.Show("Заполните все поля");
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
