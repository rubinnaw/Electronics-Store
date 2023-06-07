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
    public partial class adminauthorization : Form
    {
        SqlConnection _con1;
        public adminauthorization()
        {
            _con1 = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            _con1.Open();
            String nameadm = textBoxName.Text;
            String passadm = textBoxPass.Text;
            String uniquekey = textBoxUniq.Text;
            SqlCommand _comSel1 = new SqlCommand("select * from администратор where Имя = @AN AND Пароль = @AP AND UniqueKey = @UK");
            _comSel1.Parameters.Add("@AN", SqlDbType.VarChar).Value = nameadm;
            _comSel1.Parameters.Add("@AP", SqlDbType.VarChar).Value = passadm;
            _comSel1.Parameters.Add("@UK", SqlDbType.VarChar).Value = uniquekey;
            _comSel1.Connection = _con1;

            SqlDataAdapter _da1 = new SqlDataAdapter(_comSel1);
            DataTable _dtb1 = new DataTable();
            _da1.Fill(_dtb1);

            if (_dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                Меню train = new Меню();
                this.Visible = false;
                train.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации!");
            }
            _con1.Close();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
