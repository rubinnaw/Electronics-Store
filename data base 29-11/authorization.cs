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
    public partial class Form1 : Form
    {
        SqlConnection _con1;
        public Form1()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
            //_con1 = new SqlConnection(@"Data Source=DESKTOP-LST11UT\SQLEXPRESS01; Database = BelskiyAS; Integrated Security = True");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration train = new registration();
            this.Visible = false;
            train.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _con1.Open();
            String loginUs = login.Text;
            String passUs = pass.Text;
            SqlCommand _comSel1 = new SqlCommand("select * from Пользователи where Имя = @UL AND Пароль = @UP");
            _comSel1.Parameters.Add("@UL", SqlDbType.VarChar).Value = loginUs;
            _comSel1.Parameters.Add("@UP", SqlDbType.VarChar).Value = passUs;
            _comSel1.Connection = _con1;
            textBox1.Enabled = false;
            label4.Text = "Соединение с DataBase Успешно установлено";

            SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
            DataTable _dtb1 = new DataTable();
            _da1.Fill(_dtb1);

            if (_dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                Магазин_пользователяcs train = new Магазин_пользователяcs();
                this.Visible = false;
                train.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации!");
            }
            /*else
            {
                MessageBox.Show("Ошибка авторизации!");
            }*/
            _con1.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            adminauthorization train = new adminauthorization();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
    }
}
