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
    public partial class Магазины : Form
    {
        SqlConnection _con1;
        string connectionString = @"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;";
        public Магазины()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security = true; ");
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Меню train = new Меню();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void Магазины_Load(object sender, EventArgs e)
        {
            ShopGrid();
        }
        private void ShopGrid()
        {  // наполнение сетки DataGridView данными
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Магазин";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = name.Text;
                String ID = id.Text;
                String Address = address.Text;
                String NumPhone = numPhone.Text;
                String Time = time.Text;
                if (name.Text == "")
                {
                    MessageBox.Show("Введите название", "Ошибка");
                    conn.Close();
                    return;
                }
                if (id.Text == "")
                {
                    MessageBox.Show("Введите код", "Ошибка");
                    conn.Close();
                    return;
                }
                if (address.Text == "")
                {
                    MessageBox.Show("Укажите Адрес", "Ошибка");
                    conn.Close();
                    return;
                }
                if (numPhone.Text == "")
                {
                    MessageBox.Show("Укажите Номер телефона", "Ошибка");
                    conn.Close();
                    return;
                }
                if (time.Text == "")
                {
                    MessageBox.Show("Укажите Время работы", "Ошибка");
                    conn.Close();
                    return;
                }

                if (checkMagazine())
                {
                    conn.Close();
                    return;
                }

                SqlCommand _comSel1 = new SqlCommand("insert into Магазин (id,Название,Адрес,Телефон,ВремяРаботы) VALUES(@id,@name,@address,@number,@timework)");
                _comSel1.Parameters.Add("@Id", SqlDbType.VarChar).Value = ID;
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
                _comSel1.Parameters.Add("@timework", SqlDbType.VarChar).Value = Time;
                _comSel1.Parameters.Add("@number", SqlDbType.VarChar).Value = NumPhone;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                ShopGrid();
                //MessageBox.Show("Магазин успешно добавлен");
                conn.Close();
            }
        }

        private void dell_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Магазин WHERE id ='" + ID + "'";
                    SqlCommand commdel = new SqlCommand(sql, conn);
                    try
                    {
                        commdel.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Магазин удалён!");
                    ShopGrid();
                    conn.Close();
                }
            }
        }
        public Boolean checkMagazine()
        {

            SqlCommand _comSel1 = new SqlCommand("select * from Магазин where id = @id");
            _comSel1.Parameters.Add("@id", SqlDbType.VarChar).Value = id.Text;
            _comSel1.Connection = _con1;


            SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
            DataTable _dtb1 = new DataTable();
            _da1.Fill(_dtb1);

            if (_dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка,магазин с таким 'ID' уже существет");
                return true;
            }
            else
            {
                MessageBox.Show("Магазин успешно добавлен!");
                return false;
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    address.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    name.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    time.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    id.ReadOnly = true;
                    add.Enabled = false;
                    dell.Enabled = false;
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
                String Name = name.Text;
                String ID = id.Text;
                String Adres = address.Text;
                String NumPhone = numPhone.Text;
                String Time = time.Text;
                if (id.Text == "")
                {
                    MessageBox.Show("Для начала выберите строку которую хотите изменить!", "Ошибка");
                    conn.Close();
                    return;
                }
                if (name.Text == "")
                {
                    MessageBox.Show("Введите название", "Ошибка");
                    conn.Close();
                    return;
                }
                if (address.Text == "")
                {
                    MessageBox.Show("Укажите адрес", "Ошибка");
                    conn.Close();
                    return;
                }
                if (numPhone.Text == "")
                {
                    MessageBox.Show("Укажите контактный номер", "Ошибка");
                    conn.Close();
                    return;
                }
                if (time.Text == "")
                {
                    MessageBox.Show("Укажите время работы", "Ошибка");
                    conn.Close();
                    return;
                }

                SqlCommand _comSel1 = new SqlCommand("update Магазин set Имя = @name, Код = @id, Адрес = @adres,Телефон = @numphone, ВремяРаботы = @time where (id = @id)");
                _comSel1.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@adres", SqlDbType.VarChar).Value = Adres;
                _comSel1.Parameters.Add("@time", SqlDbType.VarChar).Value = Time;
                _comSel1.Parameters.Add("@numphone", SqlDbType.VarChar).Value = NumPhone;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                ShopGrid();
                MessageBox.Show("Запись успешно изменена");
                name.Text = "";
                address.Text = "";
                numPhone.Text = "";
                time.Text = "";
                id.Text = "";
                add.Enabled = true;
                dell.Enabled = true;
                id.ReadOnly = false;
                conn.Close();
            }
        }

    }
}
