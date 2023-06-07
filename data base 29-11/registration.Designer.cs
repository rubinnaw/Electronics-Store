
namespace data_base_29_11
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.avt = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.registr = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // avt
            // 
            this.avt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.avt.Location = new System.Drawing.Point(139, 305);
            this.avt.Name = "avt";
            this.avt.Size = new System.Drawing.Size(121, 48);
            this.avt.TabIndex = 0;
            this.avt.Text = "Авторизация";
            this.avt.UseVisualStyleBackColor = true;
            this.avt.Click += new System.EventHandler(this.avt_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.login.Location = new System.Drawing.Point(99, 127);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(211, 25);
            this.login.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.pass.Location = new System.Drawing.Point(99, 194);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(211, 25);
            this.pass.TabIndex = 2;
            // 
            // registr
            // 
            this.registr.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.registr.Location = new System.Drawing.Point(140, 359);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(120, 48);
            this.registr.TabIndex = 3;
            this.registr.Text = "Регистрация";
            this.registr.UseVisualStyleBackColor = true;
            this.registr.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.email.Location = new System.Drawing.Point(99, 259);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 25);
            this.email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(95, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Укажите Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(95, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Придумайте пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(70, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес электронной почты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(109, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.avt);
            this.Name = "registration";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avt;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}