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
    public partial class Магазин_пользователяcs : Form
    {
        //string connectionString = @"Data Source=DESKTOP-LST11UT\SQLEXPRESS01;Initial Catalog=BelskiyAS;Integrated Security=True";
        string connectionString = @"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;";
        //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LST11UT\SQLEXPRESS01;Initial Catalog=BelskiyAS;Integrated Security=True");
        SqlConnection connection = new SqlConnection(@"Data Source = DBSRV\SQL2021; Database = sb1007Belskiy; Integrated Security=true;");
        SqlDataAdapter da;
        public Магазин_пользователяcs()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            addbasket();
        }
        public void addbasket()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[1].Value = dataGridView1.Rows[n].Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = dataGridView1.Rows[n].Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = dataGridView1.Rows[n].Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[4].Value = dataGridView1.Rows[n].Cells[4].Value.ToString();
                }
            }
            
        }

        public void claerbasket()
        {
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].FormattedValue)
                {
                    dataGridView2.Rows.RemoveAt(i);
                }
            }

            //for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //{
            //    if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
            //    {

            //        dataGridView2.Rows.RemoveAt(i);
            //    }
            //}
        }
       

        private void Магазин_пользователяcs_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Продукт", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item["Код"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Название"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Производитель"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Цена"].ToString();
            }
        }

        private void allbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = true;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            claerbasket();
        }

        private void button1_Click(object sender, EventArgs e) //datagridciew1 выбрать всё
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) //datagridciew1 отменить выбранное
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            confirmorder();
        }

        public void confirmorder()
        {
            string ID = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].FormattedValue)
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
                        //MessageBox.Show("Заказ успешно оформлен!");
                        dataGridView2.Rows.RemoveAt(i);
                        dataGridView1.Rows.RemoveAt(i);
                        conn.Close();
                    }
                    dataGridView1.Refresh();
                }
            }
            MessageBox.Show("Заказ успешно оформлен!","Спасибо за покупку!");
        }
    }
}
