
namespace data_base_29_11
{
    partial class Пользователи
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
            this.swith = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.addAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.adduser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(468, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // swith
            // 
            this.swith.BackColor = System.Drawing.SystemColors.Info;
            this.swith.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.swith.Location = new System.Drawing.Point(661, 12);
            this.swith.Name = "swith";
            this.swith.Size = new System.Drawing.Size(127, 50);
            this.swith.TabIndex = 1;
            this.swith.Text = "Сменить пользователя";
            this.swith.UseVisualStyleBackColor = false;
            this.swith.Click += new System.EventHandler(this.swith_Click);
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Underline);
            this.users.Location = new System.Drawing.Point(13, 12);
            this.users.Name = "users";
            this.users.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.users.Size = new System.Drawing.Size(277, 33);
            this.users.TabIndex = 2;
            this.users.Text = "Запись пользователя";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.delete.Location = new System.Drawing.Point(113, 51);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(87, 41);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addAdmin
            // 
            this.addAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.addAdmin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.addAdmin.Location = new System.Drawing.Point(434, 12);
            this.addAdmin.Name = "addAdmin";
            this.addAdmin.Size = new System.Drawing.Size(103, 50);
            this.addAdmin.TabIndex = 4;
            this.addAdmin.Text = "Добавить Админа";
            this.addAdmin.UseVisualStyleBackColor = false;
            this.addAdmin.Click += new System.EventHandler(this.addAdmin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(543, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.update.Location = new System.Drawing.Point(26, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(157, 44);
            this.update.TabIndex = 6;
            this.update.Text = "Изменить запись";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button2_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.username.Location = new System.Drawing.Point(24, 136);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(174, 25);
            this.username.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.password.Location = new System.Drawing.Point(23, 196);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(174, 25);
            this.password.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Passowd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.email.Location = new System.Drawing.Point(11, 163);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(174, 25);
            this.email.TabIndex = 12;
            // 
            // adduser
            // 
            this.adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adduser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.adduser.Location = new System.Drawing.Point(17, 388);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(101, 41);
            this.adduser.TabIndex = 13;
            this.adduser.Text = "Добавить";
            this.adduser.UseVisualStyleBackColor = false;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 196);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.update);
            this.panel2.Location = new System.Drawing.Point(14, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 101);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(14, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Управление записями";
            // 
            // Пользователи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addAdmin);
            this.Controls.Add(this.users);
            this.Controls.Add(this.swith);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Пользователи";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Пользователи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button swith;
        private System.Windows.Forms.Label users;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}