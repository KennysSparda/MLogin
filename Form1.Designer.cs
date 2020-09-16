namespace Login_M
{
    partial class frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.painel_status = new System.Windows.Forms.Panel();
            this.lbl_status_user_name = new System.Windows.Forms.Label();
            this.lbl_status_access_num = new System.Windows.Forms.Label();
            this.lbl_status_user = new System.Windows.Forms.Label();
            this.lbl_status_access = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painel_login = new System.Windows.Forms.Panel();
            this.txtbox_login_user_name = new System.Windows.Forms.TextBox();
            this.lbl_login_user_name = new System.Windows.Forms.Label();
            this.txtbox_login_passwd = new System.Windows.Forms.TextBox();
            this.lbl_login_passwd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.painel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_status
            // 
            this.painel_status.BackColor = System.Drawing.SystemColors.ControlDark;
            this.painel_status.Controls.Add(this.lbl_status_user_name);
            this.painel_status.Controls.Add(this.lbl_status_access_num);
            this.painel_status.Controls.Add(this.lbl_status_user);
            this.painel_status.Controls.Add(this.lbl_status_access);
            this.painel_status.Controls.Add(this.pictureBox1);
            this.painel_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painel_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_status.Location = new System.Drawing.Point(0, 236);
            this.painel_status.Name = "painel_status";
            this.painel_status.Size = new System.Drawing.Size(384, 25);
            this.painel_status.TabIndex = 0;
            // 
            // lbl_status_user_name
            // 
            this.lbl_status_user_name.AutoSize = true;
            this.lbl_status_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_status_user_name.Location = new System.Drawing.Point(169, 4);
            this.lbl_status_user_name.Name = "lbl_status_user_name";
            this.lbl_status_user_name.Size = new System.Drawing.Size(26, 16);
            this.lbl_status_user_name.TabIndex = 1;
            this.lbl_status_user_name.Text = "- - -";
            // 
            // lbl_status_access_num
            // 
            this.lbl_status_access_num.AutoSize = true;
            this.lbl_status_access_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_access_num.ForeColor = System.Drawing.Color.White;
            this.lbl_status_access_num.Location = new System.Drawing.Point(92, 4);
            this.lbl_status_access_num.Name = "lbl_status_access_num";
            this.lbl_status_access_num.Size = new System.Drawing.Size(15, 16);
            this.lbl_status_access_num.TabIndex = 1;
            this.lbl_status_access_num.Text = "0";
            // 
            // lbl_status_user
            // 
            this.lbl_status_user.AutoSize = true;
            this.lbl_status_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_user.ForeColor = System.Drawing.Color.White;
            this.lbl_status_user.Location = new System.Drawing.Point(113, 4);
            this.lbl_status_user.Name = "lbl_status_user";
            this.lbl_status_user.Size = new System.Drawing.Size(58, 16);
            this.lbl_status_user.TabIndex = 1;
            this.lbl_status_user.Text = "Usuário:";
            // 
            // lbl_status_access
            // 
            this.lbl_status_access.AutoSize = true;
            this.lbl_status_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_access.ForeColor = System.Drawing.Color.White;
            this.lbl_status_access.Location = new System.Drawing.Point(29, 4);
            this.lbl_status_access.Name = "lbl_status_access";
            this.lbl_status_access.Size = new System.Drawing.Size(64, 16);
            this.lbl_status_access.TabIndex = 1;
            this.lbl_status_access.Text = "Acessos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_M.Properties.Resources.led_red;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // painel_login
            // 
            this.painel_login.BackColor = System.Drawing.Color.DimGray;
            this.painel_login.Controls.Add(this.button2);
            this.painel_login.Controls.Add(this.button1);
            this.painel_login.Controls.Add(this.pictureBox2);
            this.painel_login.Controls.Add(this.lbl_login_passwd);
            this.painel_login.Controls.Add(this.lbl_login_user_name);
            this.painel_login.Controls.Add(this.txtbox_login_passwd);
            this.painel_login.Controls.Add(this.txtbox_login_user_name);
            this.painel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_login.ForeColor = System.Drawing.Color.White;
            this.painel_login.Location = new System.Drawing.Point(0, 0);
            this.painel_login.Name = "painel_login";
            this.painel_login.Size = new System.Drawing.Size(384, 236);
            this.painel_login.TabIndex = 1;
            // 
            // txtbox_login_user_name
            // 
            this.txtbox_login_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_login_user_name.Location = new System.Drawing.Point(63, 94);
            this.txtbox_login_user_name.Name = "txtbox_login_user_name";
            this.txtbox_login_user_name.Size = new System.Drawing.Size(192, 22);
            this.txtbox_login_user_name.TabIndex = 0;
            // 
            // lbl_login_user_name
            // 
            this.lbl_login_user_name.AutoSize = true;
            this.lbl_login_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_login_user_name.Location = new System.Drawing.Point(8, 96);
            this.lbl_login_user_name.Name = "lbl_login_user_name";
            this.lbl_login_user_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_login_user_name.TabIndex = 1;
            this.lbl_login_user_name.Text = "Usuário";
            // 
            // txtbox_login_passwd
            // 
            this.txtbox_login_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_login_passwd.Location = new System.Drawing.Point(63, 122);
            this.txtbox_login_passwd.Name = "txtbox_login_passwd";
            this.txtbox_login_passwd.Size = new System.Drawing.Size(192, 22);
            this.txtbox_login_passwd.TabIndex = 0;
            // 
            // lbl_login_passwd
            // 
            this.lbl_login_passwd.AutoSize = true;
            this.lbl_login_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_passwd.ForeColor = System.Drawing.Color.White;
            this.lbl_login_passwd.Location = new System.Drawing.Point(12, 124);
            this.lbl_login_passwd.Name = "lbl_login_passwd";
            this.lbl_login_passwd.Size = new System.Drawing.Size(47, 16);
            this.lbl_login_passwd.TabIndex = 1;
            this.lbl_login_passwd.Text = "Senha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login_M.Properties.Resources.IconCrpM;
            this.pictureBox2.Location = new System.Drawing.Point(261, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Criar Conta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.painel_login);
            this.Controls.Add(this.painel_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login M";
            this.painel_status.ResumeLayout(false);
            this.painel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painel_login.ResumeLayout(false);
            this.painel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_status;
        private System.Windows.Forms.Label lbl_status_user_name;
        private System.Windows.Forms.Label lbl_status_access_num;
        private System.Windows.Forms.Label lbl_status_user;
        private System.Windows.Forms.Label lbl_status_access;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel painel_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_login_passwd;
        private System.Windows.Forms.Label lbl_login_user_name;
        private System.Windows.Forms.TextBox txtbox_login_passwd;
        private System.Windows.Forms.TextBox txtbox_login_user_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

