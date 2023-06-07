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
    public partial class product : Form
    {
        SqlConnection _con1;
        string connectionString = @"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;";
        //string connectionString =@"Data Source=DESKTOP-LST11UT\SQLEXPRESS01; Database = BelskiyAS; Integrated Security = True";
        public product()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
            //_con1 = new SqlConnection(@"Data Source=DESKTOP-LST11UT\SQLEXPRESS01; Database = BelskiyAS; Integrated Security = True");
            InitializeComponent();
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        private void PopulateGrid()
        {  // наполнение сетки DataGridView данными
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Продукт";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = name.Text;
                String ID = idtxt.Text;
                String Manufacturer = manufacturer.Text;
                String Price = price.Text;
                if (name.Text == "")
                {
                    MessageBox.Show("Введите название");
                    conn.Close();
                    return;
                }
                if (idtxt.Text == "")
                {
                    MessageBox.Show("Введите код");
                    conn.Close();
                    return;
                }
                if (manufacturer.Text == "")
                {
                    MessageBox.Show("Укажите Производителя");
                    conn.Close();
                    return;
                }
                if (price.Text == "")
                {
                    MessageBox.Show("Укажите стоимость");
                    conn.Close();
                    return;
                }

                if (checkProduct())
                {
                    conn.Close();
                    return;
                }

                SqlCommand _comSel1 = new SqlCommand("insert into Продукт (Код,Название,Производитель,Цена) VALUES(@id,@name,@manufact,@price)");
                _comSel1.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@manufact", SqlDbType.VarChar).Value = Manufacturer;
                _comSel1.Parameters.Add("@price", SqlDbType.VarChar).Value = Price;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                PopulateGrid();
                //MessageBox.Show("Товар успешно добавлен");
                conn.Close();
            }
        }

        private void Удалить_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Продукт WHERE Код ='" + ID + "'";
                    SqlCommand commdel = new SqlCommand(sql, conn);
                    try
                    {
                        commdel.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Товар успешно удалён!");
                    PopulateGrid();
                    conn.Close();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Меню train = new Меню();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
        public Boolean checkProduct()
        {
                
                SqlCommand _comSel1 = new SqlCommand("select * from Продукт where Код = @id");
                _comSel1.Parameters.Add("@id", SqlDbType.VarChar).Value = idtxt.Text;
                _comSel1.Connection = _con1;


                SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
                DataTable _dtb1 = new DataTable();
                _da1.Fill(_dtb1);

                if (_dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Ошибка,товар с таким 'ID' уже существет", "Ошибка");
                    return true;
                }
                else
                {
                    MessageBox.Show("Товар успешно добавлен!", "Успех");
                    return false;
                }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    manufacturer.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    price.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    idtxt.ReadOnly = true;
                    Добавить.Enabled = false;
                    Удалить.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный запрос, выберите необходимую строку","Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String Name = name.Text;
                String ID = idtxt.Text;
                String Manufacturer = manufacturer.Text;
                String Price = price.Text;
                if (idtxt.Text == "")
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
                if (manufacturer.Text == "")
                {
                    MessageBox.Show("Укажите Производителя", "Ошибка");
                    conn.Close();
                    return;
                }
                if (price.Text == "")
                {
                    MessageBox.Show("Укажите стоимость", "Ошибка");
                    conn.Close();
                    return;
                }
                
                SqlCommand _comSel1 = new SqlCommand("update Продукт set Код = @id, Название = @name, Производитель = @manufact, Цена = @price where (Код = @id)");
                _comSel1.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
                _comSel1.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                _comSel1.Parameters.Add("@manufact", SqlDbType.VarChar).Value = Manufacturer;
                _comSel1.Parameters.Add("@price", SqlDbType.VarChar).Value = Price;
                _comSel1.Connection = conn;
                _comSel1.ExecuteNonQuery();
                PopulateGrid();
                MessageBox.Show("Запись успешно изменена");
                name.Text = "";
                idtxt.Text = "";
                manufacturer.Text = "";
                price.Text = "";
                Добавить.Enabled = true;
                Удалить.Enabled = true;
                idtxt.ReadOnly = false;
                conn.Close();
            }
        }
    }
}
