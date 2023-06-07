using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data_base_29_11
{
    public partial class Пользователи : Form
    {

        SqlConnection _con1;
        string connectionString = @"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;";
        public Пользователи()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Пользователи_Load(object sender, EventArgs e)
        {
            UserGrid();
        }
        private void UserGrid()
        {  // наполнение сетки DataGridView данными
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Пользователи";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Пользователи WHERE Имя ='" + name +"'";
                    SqlCommand commdel = new SqlCommand(sql, conn);
                    try
                    {
                        commdel.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Пользователь успешно удалён!", "Успех");
                    UserGrid();
                }
            }
        }

        private void swith_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin train = new AddAdmin();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню train = new Меню();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = username.Text;
                String Email = email.Text;
                String Password = password.Text;
                if (username.Text == "")
                {
                    MessageBox.Show("Для начала выберите строку которую хотите изменить!", "Ошибка");
                    conn.Close();
                    return;
                }
                if (email.Text == "")
                {
                    MessageBox.Show("Введите Email", "Ошибка");
                    conn.Close();
                    return;
                }
                if (password.Text == "")
                {
                    MessageBox.Show("Введите пароль", "Ошибка");
                    conn.Close();
                    return;
                }

                SqlCommand _comSel1 = new SqlCommand("update Пользователи set Имя = @name, Пароль = @password, Почта = @email where (Имя = @name)");
                _comSel1.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                UserGrid();
                MessageBox.Show("Запись успешно изменена");
                username.Text = "";
                email.Text = "";
                password.Text = "";
                adduser.Enabled = true;
                delete.Enabled = true;
                conn.Close();
            }
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = username.Text;
                String Email = email.Text;
                String Password = password.Text;
                if (username.Text == "")
                {
                    MessageBox.Show("Введите имя", "Ошибка");
                    conn.Close();
                    return;
                }
                if (email.Text == "")
                {
                    MessageBox.Show("Введите Email", "Ошибка");
                    conn.Close();
                    return;
                }
                if (password.Text == "")
                {
                    MessageBox.Show("Укажите пароль", "Ошибка");
                    conn.Close();
                    return;
                }

                if (CheckUSRAdd())
                {
                    conn.Close();
                    return;
                }
                SqlCommand _comSel1 = new SqlCommand("insert into Пользователи (Имя,Пароль,Почта) VALUES(@name,@password,@email)");
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;
                _comSel1.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                UserGrid();
                //MessageBox.Show("Товар успешно добавлен");
                conn.Close();
            }
        }
        public Boolean CheckUSRAdd()
        {
            SqlCommand _comSel1 = new SqlCommand("select * from Пользователи where Имя = @name");
            _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = username.Text;
            _comSel1.Connection = _con1;

            SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
            DataTable _dtb1 = new DataTable();
            _da1.Fill(_dtb1);

            if (_dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка \nАдминистратор с таким именем или уникальным ключём уже существует!");
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь успешно добавлен!","Успех");
                return false;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    username.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    password.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    email.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    adduser.Enabled = false;
                    delete.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный запрос, выберите необходимую строку", "Ошибка");
            }
        }
    }
}
