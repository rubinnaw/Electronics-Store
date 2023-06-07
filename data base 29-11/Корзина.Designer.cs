
namespace data_base_29_11
{
    partial class Корзина
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.shopbtn = new System.Windows.Forms.Button();
            this.статус = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.статус,
            this.id,
            this.наименование,
            this.производитель,
            this.цена});
            this.dataGridView1.Location = new System.Drawing.Point(254, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderbtn
            // 
            this.orderbtn.Location = new System.Drawing.Point(12, 397);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(113, 41);
            this.orderbtn.TabIndex = 1;
            this.orderbtn.Text = "Оформить заказ";
            this.orderbtn.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(675, 12);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(113, 41);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Сменить пользователя";
            this.loginbtn.UseVisualStyleBackColor = true;
            // 
            // shopbtn
            // 
            this.shopbtn.BackColor = System.Drawing.SystemColors.Control;
            this.shopbtn.Location = new System.Drawing.Point(556, 12);
            this.shopbtn.Name = "shopbtn";
            this.shopbtn.Size = new System.Drawing.Size(113, 41);
            this.shopbtn.TabIndex = 3;
            this.shopbtn.Text = "В магазин";
            this.shopbtn.UseVisualStyleBackColor = false;
            // 
            // статус
            // 
            this.статус.HeaderText = "Статус";
            this.статус.Name = "статус";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // наименование
            // 
            this.наименование.HeaderText = "Наименование";
            this.наименование.Name = "наименование";
            // 
            // производитель
            // 
            this.производитель.HeaderText = "Производитель";
            this.производитель.Name = "производитель";
            // 
            // цена
            // 
            this.цена.HeaderText = "Цена";
            this.цена.Name = "цена";
            // 
            // Корзина
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shopbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Корзина";
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button shopbtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименование;
        private System.Windows.Forms.DataGridViewTextBoxColumn производитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена;
    }
}