using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_base_29_11
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Магазины train = new Магазины();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product train = new product();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Пользователи train = new Пользователи();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
    }
}
