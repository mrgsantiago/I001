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
    public partial class Glavnoe : Form
    {
        int Id, IndexRow;
        string NameUser, Login, Password, Role;
        public Glavnoe()
        {
            InitializeComponent();
        }

        private void Glavnoe_Load(object sender, EventArgs e) // загрузка данных в dvgUsers из БД таблицы Users
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = I001CRUD; Persist Security Info=True; User ID = student; Password = passw0rd"))
            {
                string query = "SELECT * from Users";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    dvgUsers.DataSource = dt;
                    dvgUsers.Update();

                    dvgUsers.Columns[1].HeaderText = "Имя";
                    dvgUsers.Columns[2].HeaderText = "Логин";
                    dvgUsers.Columns[3].HeaderText = "Пароль";
                    dvgUsers.Columns[4].HeaderText = "Роль";

                    dvgUsers.Columns[0].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }



            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) // переход на форму изменения информации о пользователе
        {
            if (dvgUsers.SelectedRows.Count == 1)
            {
                NameUser = dvgUsers[1, IndexRow].Value.ToString();
                Login = dvgUsers[2, IndexRow].Value.ToString();
                Password = dvgUsers[3, IndexRow].Value.ToString();
                Role = dvgUsers[4, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                UpdateUser change = new UpdateUser(Id, NameUser, Login, Password, Role);
                change.ShowDialog();


            }
            else
            {
                if (dvgUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // переход на форму добавления пользователя
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            AddUsers view = new AddUsers();
            view.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e) // удаление пользователя из БД
        {
            string message = $"Вы действительно хотите удалить {Id} запись?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (dvgUsers.SelectedRows.Count == 1)
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = I001CRUD; Persist Security Info=True; User ID = student; Password = passw0rd"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM Users WHERE ID = @ID";
                            cmd.Parameters.AddWithValue(@"ID", Id);
                            cmd.ExecuteScalar();
                            dvgUsers.Refresh();
                            MessageBox.Show("Запись успешно удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Users ", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dvgUsers.DataSource = dataTable;
                            dvgUsers.Refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Запись не удалена!");
                }
            }
            else
            {
                if (dvgUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите только ОДНУ строку для удаления!");
                }
            }
        }

        private void dvgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //переход и передача данных на форму ReadUser для просмотра данных о выбранном пользователе
        {
            NameUser = dvgUsers[1, IndexRow].Value.ToString();
            Login = dvgUsers[2, IndexRow].Value.ToString();
            Password = dvgUsers[3, IndexRow].Value.ToString();
            Role = dvgUsers[4, IndexRow].Value.ToString();
            this.Visible = false;
            this.ShowInTaskbar = false;
            ReadUrer prosmotr = new ReadUrer(NameUser, Login, Password, Role);
            prosmotr.ShowDialog();
        }

        private void dvgUsers_CellClick(object sender, DataGridViewCellEventArgs e) //извлечение Id выбранного пользователя
        {
            try
            {
                dvgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt32(dvgUsers[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }
    }
}
