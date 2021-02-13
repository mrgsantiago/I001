using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I001
{
    public partial class ReadUrer : Form
    {
        public ReadUrer(string Name, string Login, string Password, string Role)
        {
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
            this.Visible = false;
            this.ShowInTaskbar = false;
            Glavnoe view = new Glavnoe();
            view.ShowDialog();
        }
    }
}
