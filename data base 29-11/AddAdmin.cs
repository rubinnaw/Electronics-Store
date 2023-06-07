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
    public partial class AddAdmin : Form
    {
        SqlConnection _con1;
        string connectionString = @"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;";
        public AddAdmin()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminGrid();
        }
        private void AdminGrid()
        {  // наполнение сетки DataGridView данными
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM администратор";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = textBoxName.Text;
                String Email = textBoxEmail.Text;
                String Password = textBoxPassword.Text;
                String Unq = textBoxUnq.Text;
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Enter Name","WARNING");
                    conn.Close();
                    return;
                }
                if (textBoxEmail.Text == "")
                {
                    MessageBox.Show("Enter Email", "WARNING");
                    conn.Close();
                    return;
                }
                if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Enter Password", "WARNING");
                    conn.Close();
                    return;
                }
                if (textBoxUnq.Text == "")
                {
                    MessageBox.Show("Not Specified UniqueKey", "WARNING");
                    conn.Close();
                    return;
                }

                if (checkAdmAdd())
                {
                    conn.Close();
                    return;
                }
                SqlCommand _comSel1 = new SqlCommand("insert into администратор (Имя,Пароль,Email,UniqueKey) VALUES(@name,@email,@пароль,@unq)");
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@пароль", SqlDbType.VarChar).Value = Password;
                _comSel1.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                _comSel1.Parameters.Add("@unq", SqlDbType.VarChar).Value = Unq;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                AdminGrid();
                //MessageBox.Show("Товар успешно добавлен");
                conn.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string uniquekey = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM администратор WHERE UniqueKey ='" + uniquekey +"'";
                    SqlCommand commdel = new SqlCommand(sql, conn);
                    try
                    {
                        commdel.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Администратор удалён!","Успех");
                    AdminGrid();
                    conn.Close();
                }
            }
        }

        private void gen_Click(object sender, EventArgs e)
        {
            textBoxUnq.Text = UniqueKey(7);
            MessageBox.Show("Внимание!\nУникальный ключ выдаётся один раз, во избежние потери просим записать его!","Внимание");
        }
        private static string UniqueKey(int len)
        {
            string s = "", symb = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz123456789";
            Random rnd = new Random();

            for (int i = 0; i < len; i++)
                s += symb[rnd.Next(0, symb.Length)];
            return s;
        }
        public Boolean checkAdmAdd()
        {

            SqlCommand _comSel1 = new SqlCommand("select * from администратор where UniqueKey = @unq and Имя = @admname");
            _comSel1.Parameters.Add("@unq", SqlDbType.VarChar).Value = textBoxUnq.Text;
            _comSel1.Parameters.Add("@admname", SqlDbType.VarChar).Value = textBoxName.Text;
            _comSel1.Connection = _con1;

            SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
            DataTable _dtb1 = new DataTable();
            _da1.Fill(_dtb1);

            if (_dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка \nАдминистратор с таким именем или уникальным ключём уже существует!","Ошибка");
                return true;
            }
            else
            {
                MessageBox.Show("Администартор успешно добавлен!", "Успех");
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню train = new Меню();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void textBoxUnq_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    textBoxName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    textBoxPassword.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxUnq.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    textBoxUnq.ReadOnly = true;
                    add.Enabled = false;
                    delete.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный запрос, выберите необходимую строку");
            }
        }
        private void change_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = textBoxName.Text;
                String uniquekey = textBoxUnq.Text;
                String password = textBoxPassword.Text;
                String email = textBoxEmail.Text;
                if (textBoxUnq.Text == "")
                {
                    MessageBox.Show("Для начала выберите строку которую хотите изменить!", "Ошибка");
                    conn.Close();
                    return;
                }
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Введите имя", "Ошибка");
                    conn.Close();
                    return;
                }
                if (textBoxEmail.Text == "")
                {
                    MessageBox.Show("Укажите Email", "Ошибка");
                    conn.Close();
                    return;
                }
                if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Придумайте пароль", "Ошибка");
                    conn.Close();
                    return;
                }

                SqlCommand _comSel1 = new SqlCommand("update администратор set Имя = @name, Пароль = @password, Email = @email,UniqueKey = @uniquekey where (UniqueKey = @uniquekey)");
                _comSel1.Parameters.Add("@uniquekey", SqlDbType.VarChar).Value = uniquekey;
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                _comSel1.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                AdminGrid();
                MessageBox.Show("Запись успешно изменена");
                textBoxName.Text = "";
                textBoxEmail.Text = "";
                textBoxUnq.Text = "";
                textBoxPassword.Text = "";
                add.Enabled = true;
                delete.Enabled = true;
                textBoxUnq.ReadOnly = false;
                conn.Close();
            }
        }
    }
}

