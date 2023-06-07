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
    public partial class registration : Form
    {
        SqlConnection _con1;
        //private string connectionString;

        public registration()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _con1.Open();
            String LoginUS = login.Text;
            String PassUS = pass.Text;
            String EmailUS = email.Text;
            if (login.Text == "")
            {
                MessageBox.Show("Введите логин");
                _con1.Close();
                return;
            }
            if (pass.Text == "")
            {
                MessageBox.Show("Введите пароль");
                _con1.Close();
                return;
            }
            if (email.Text == "")
            {
                MessageBox.Show("Введите email");
                _con1.Close();
                return;
            }

            if (CheckUSeR())
            {
                _con1.Close();
                return;
            }

            SqlCommand _comSel1 = new SqlCommand("insert into Пользователи (Имя,Пароль,Почта) VALUES(@login,@pass,@email)");
            _comSel1.Parameters.Add("@login", SqlDbType.VarChar).Value = LoginUS;
            _comSel1.Parameters.Add("@pass", SqlDbType.VarChar).Value = PassUS;
            _comSel1.Parameters.Add("@email", SqlDbType.VarChar).Value = EmailUS;
            _comSel1.Connection = _con1;
            _comSel1.ExecuteNonQuery();

            _con1.Close();
        }

        private void avt_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
        public Boolean CheckUSeR()
        {
                SqlCommand _comSel1 = new SqlCommand("select * from Пользователи where Имя = @UL");
                _comSel1.Parameters.Add("@UL", SqlDbType.VarChar).Value = login.Text;
                _comSel1.Connection = _con1;


                SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
                DataTable _dtb1 = new DataTable();
                _da1.Fill(_dtb1);

                if (_dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Ошибка,такой лоигн уже существет");
                    return true;
                }
                else
                {
                    MessageBox.Show("Логин свободен \nАккаунт успешно создан");
                    return false;
                }
        }
    }
}