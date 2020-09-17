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
            this.panel_status = new System.Windows.Forms.Panel();
            this.lbl_status_user_name = new System.Windows.Forms.Label();
            this.lbl_status_access_num = new System.Windows.Forms.Label();
            this.lbl_status_user = new System.Windows.Forms.Label();
            this.lbl_status_access = new System.Windows.Forms.Label();
            this.pb_status_led = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.txtbox_login_user_name = new System.Windows.Forms.TextBox();
            this.txtbox_login_passwd = new System.Windows.Forms.TextBox();
            this.lbl_login_MFCloud = new System.Windows.Forms.Label();
            this.btn_login_signup = new System.Windows.Forms.Button();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.pb_login_logo = new System.Windows.Forms.PictureBox();
            this.lbl_login_passwd = new System.Windows.Forms.Label();
            this.lbl_login_user_name = new System.Windows.Forms.Label();
            this.panel_signup = new System.Windows.Forms.Panel();
            this.btn_signup_signup = new System.Windows.Forms.Button();
            this.btn_signup_back = new System.Windows.Forms.Button();
            this.txtbox_signup_user_name = new System.Windows.Forms.TextBox();
            this.txtbox_signup_confirm_passwd = new System.Windows.Forms.TextBox();
            this.txtbox_signup_passwd = new System.Windows.Forms.TextBox();
            this.lbl_signup_MFCloud = new System.Windows.Forms.Label();
            this.lbl_signup_confirm_passwd = new System.Windows.Forms.Label();
            this.pb_signup_logo = new System.Windows.Forms.PictureBox();
            this.lbl_signup_passwd = new System.Windows.Forms.Label();
            this.lbl_signup_user_name = new System.Windows.Forms.Label();
            this.panel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_led)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).BeginInit();
            this.panel_signup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_signup_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_status
            // 
            this.panel_status.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_status.Controls.Add(this.lbl_status_user_name);
            this.panel_status.Controls.Add(this.lbl_status_access_num);
            this.panel_status.Controls.Add(this.lbl_status_user);
            this.panel_status.Controls.Add(this.lbl_status_access);
            this.panel_status.Controls.Add(this.pb_status_led);
            this.panel_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_status.Location = new System.Drawing.Point(0, 236);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(384, 25);
            this.panel_status.TabIndex = 0;
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
            // pb_status_led
            // 
            this.pb_status_led.Image = global::Login_M.Properties.Resources.led_red;
            this.pb_status_led.Location = new System.Drawing.Point(0, 0);
            this.pb_status_led.Name = "pb_status_led";
            this.pb_status_led.Size = new System.Drawing.Size(25, 25);
            this.pb_status_led.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_status_led.TabIndex = 0;
            this.pb_status_led.TabStop = false;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.DimGray;
            this.panel_login.Controls.Add(this.txtbox_login_user_name);
            this.panel_login.Controls.Add(this.txtbox_login_passwd);
            this.panel_login.Controls.Add(this.lbl_login_MFCloud);
            this.panel_login.Controls.Add(this.btn_login_signup);
            this.panel_login.Controls.Add(this.btn_login_login);
            this.panel_login.Controls.Add(this.pb_login_logo);
            this.panel_login.Controls.Add(this.lbl_login_passwd);
            this.panel_login.Controls.Add(this.lbl_login_user_name);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.ForeColor = System.Drawing.Color.White;
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(384, 261);
            this.panel_login.TabIndex = 1;
            // 
            // txtbox_login_user_name
            // 
            this.txtbox_login_user_name.BackColor = System.Drawing.Color.Black;
            this.txtbox_login_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_login_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_login_user_name.ForeColor = System.Drawing.Color.White;
            this.txtbox_login_user_name.Location = new System.Drawing.Point(63, 94);
            this.txtbox_login_user_name.Name = "txtbox_login_user_name";
            this.txtbox_login_user_name.Size = new System.Drawing.Size(192, 22);
            this.txtbox_login_user_name.TabIndex = 0;
            // 
            // txtbox_login_passwd
            // 
            this.txtbox_login_passwd.BackColor = System.Drawing.Color.Black;
            this.txtbox_login_passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_login_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_login_passwd.ForeColor = System.Drawing.Color.White;
            this.txtbox_login_passwd.Location = new System.Drawing.Point(63, 122);
            this.txtbox_login_passwd.Name = "txtbox_login_passwd";
            this.txtbox_login_passwd.Size = new System.Drawing.Size(192, 22);
            this.txtbox_login_passwd.TabIndex = 1;
            this.txtbox_login_passwd.UseSystemPasswordChar = true;
            // 
            // lbl_login_MFCloud
            // 
            this.lbl_login_MFCloud.AutoSize = true;
            this.lbl_login_MFCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_MFCloud.Location = new System.Drawing.Point(56, 54);
            this.lbl_login_MFCloud.Name = "lbl_login_MFCloud";
            this.lbl_login_MFCloud.Size = new System.Drawing.Size(170, 42);
            this.lbl_login_MFCloud.TabIndex = 4;
            this.lbl_login_MFCloud.Text = "MFCloud";
            // 
            // btn_login_signup
            // 
            this.btn_login_signup.BackColor = System.Drawing.Color.Black;
            this.btn_login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_signup.ForeColor = System.Drawing.Color.White;
            this.btn_login_signup.Location = new System.Drawing.Point(161, 150);
            this.btn_login_signup.Name = "btn_login_signup";
            this.btn_login_signup.Size = new System.Drawing.Size(92, 23);
            this.btn_login_signup.TabIndex = 3;
            this.btn_login_signup.Text = "Criar Conta";
            this.btn_login_signup.UseVisualStyleBackColor = false;
            this.btn_login_signup.Click += new System.EventHandler(this.btn_login_signup_Click);
            // 
            // btn_login_login
            // 
            this.btn_login_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_login.ForeColor = System.Drawing.Color.White;
            this.btn_login_login.Location = new System.Drawing.Point(63, 150);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(92, 23);
            this.btn_login_login.TabIndex = 2;
            this.btn_login_login.Text = "Entrar";
            this.btn_login_login.UseVisualStyleBackColor = false;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // pb_login_logo
            // 
            this.pb_login_logo.Image = global::Login_M.Properties.Resources.IconCrpM;
            this.pb_login_logo.Location = new System.Drawing.Point(244, 58);
            this.pb_login_logo.Name = "pb_login_logo";
            this.pb_login_logo.Size = new System.Drawing.Size(140, 140);
            this.pb_login_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login_logo.TabIndex = 2;
            this.pb_login_logo.TabStop = false;
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
            // panel_signup
            // 
            this.panel_signup.BackColor = System.Drawing.Color.DimGray;
            this.panel_signup.Controls.Add(this.btn_signup_signup);
            this.panel_signup.Controls.Add(this.btn_signup_back);
            this.panel_signup.Controls.Add(this.txtbox_signup_user_name);
            this.panel_signup.Controls.Add(this.txtbox_signup_confirm_passwd);
            this.panel_signup.Controls.Add(this.txtbox_signup_passwd);
            this.panel_signup.Controls.Add(this.lbl_signup_MFCloud);
            this.panel_signup.Controls.Add(this.lbl_signup_confirm_passwd);
            this.panel_signup.Controls.Add(this.pb_signup_logo);
            this.panel_signup.Controls.Add(this.lbl_signup_passwd);
            this.panel_signup.Controls.Add(this.lbl_signup_user_name);
            this.panel_signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_signup.ForeColor = System.Drawing.Color.White;
            this.panel_signup.Location = new System.Drawing.Point(0, 0);
            this.panel_signup.Name = "panel_signup";
            this.panel_signup.Size = new System.Drawing.Size(384, 261);
            this.panel_signup.TabIndex = 1;
            this.panel_signup.Visible = false;
            // 
            // btn_signup_signup
            // 
            this.btn_signup_signup.BackColor = System.Drawing.Color.Black;
            this.btn_signup_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signup_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup_signup.Location = new System.Drawing.Point(65, 178);
            this.btn_signup_signup.Name = "btn_signup_signup";
            this.btn_signup_signup.Size = new System.Drawing.Size(92, 23);
            this.btn_signup_signup.TabIndex = 3;
            this.btn_signup_signup.Text = "Criar";
            this.btn_signup_signup.UseVisualStyleBackColor = false;
            this.btn_signup_signup.Click += new System.EventHandler(this.btn_signup_signup_Click);
            // 
            // btn_signup_back
            // 
            this.btn_signup_back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signup_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signup_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup_back.ForeColor = System.Drawing.Color.White;
            this.btn_signup_back.Location = new System.Drawing.Point(163, 178);
            this.btn_signup_back.Name = "btn_signup_back";
            this.btn_signup_back.Size = new System.Drawing.Size(92, 23);
            this.btn_signup_back.TabIndex = 4;
            this.btn_signup_back.Text = "Voltar";
            this.btn_signup_back.UseVisualStyleBackColor = false;
            this.btn_signup_back.Click += new System.EventHandler(this.btn_signup_cancel_Click);
            // 
            // txtbox_signup_user_name
            // 
            this.txtbox_signup_user_name.BackColor = System.Drawing.Color.Black;
            this.txtbox_signup_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_signup_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_signup_user_name.ForeColor = System.Drawing.Color.White;
            this.txtbox_signup_user_name.Location = new System.Drawing.Point(125, 94);
            this.txtbox_signup_user_name.Name = "txtbox_signup_user_name";
            this.txtbox_signup_user_name.Size = new System.Drawing.Size(130, 22);
            this.txtbox_signup_user_name.TabIndex = 0;
            // 
            // txtbox_signup_confirm_passwd
            // 
            this.txtbox_signup_confirm_passwd.BackColor = System.Drawing.Color.Black;
            this.txtbox_signup_confirm_passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_signup_confirm_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_signup_confirm_passwd.ForeColor = System.Drawing.Color.White;
            this.txtbox_signup_confirm_passwd.Location = new System.Drawing.Point(125, 150);
            this.txtbox_signup_confirm_passwd.Name = "txtbox_signup_confirm_passwd";
            this.txtbox_signup_confirm_passwd.Size = new System.Drawing.Size(130, 22);
            this.txtbox_signup_confirm_passwd.TabIndex = 2;
            this.txtbox_signup_confirm_passwd.UseSystemPasswordChar = true;
            // 
            // txtbox_signup_passwd
            // 
            this.txtbox_signup_passwd.BackColor = System.Drawing.Color.Black;
            this.txtbox_signup_passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_signup_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_signup_passwd.ForeColor = System.Drawing.Color.White;
            this.txtbox_signup_passwd.Location = new System.Drawing.Point(125, 122);
            this.txtbox_signup_passwd.Name = "txtbox_signup_passwd";
            this.txtbox_signup_passwd.Size = new System.Drawing.Size(130, 22);
            this.txtbox_signup_passwd.TabIndex = 1;
            this.txtbox_signup_passwd.UseSystemPasswordChar = true;
            // 
            // lbl_signup_MFCloud
            // 
            this.lbl_signup_MFCloud.AutoSize = true;
            this.lbl_signup_MFCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup_MFCloud.Location = new System.Drawing.Point(56, 54);
            this.lbl_signup_MFCloud.Name = "lbl_signup_MFCloud";
            this.lbl_signup_MFCloud.Size = new System.Drawing.Size(170, 42);
            this.lbl_signup_MFCloud.TabIndex = 4;
            this.lbl_signup_MFCloud.Text = "MFCloud";
            // 
            // lbl_signup_confirm_passwd
            // 
            this.lbl_signup_confirm_passwd.AutoSize = true;
            this.lbl_signup_confirm_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup_confirm_passwd.ForeColor = System.Drawing.Color.White;
            this.lbl_signup_confirm_passwd.Location = new System.Drawing.Point(12, 152);
            this.lbl_signup_confirm_passwd.Name = "lbl_signup_confirm_passwd";
            this.lbl_signup_confirm_passwd.Size = new System.Drawing.Size(107, 16);
            this.lbl_signup_confirm_passwd.TabIndex = 1;
            this.lbl_signup_confirm_passwd.Text = "Confirmar Senha";
            // 
            // pb_signup_logo
            // 
            this.pb_signup_logo.Image = global::Login_M.Properties.Resources.IconCrpM;
            this.pb_signup_logo.Location = new System.Drawing.Point(244, 58);
            this.pb_signup_logo.Name = "pb_signup_logo";
            this.pb_signup_logo.Size = new System.Drawing.Size(140, 140);
            this.pb_signup_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_signup_logo.TabIndex = 2;
            this.pb_signup_logo.TabStop = false;
            // 
            // lbl_signup_passwd
            // 
            this.lbl_signup_passwd.AutoSize = true;
            this.lbl_signup_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup_passwd.ForeColor = System.Drawing.Color.White;
            this.lbl_signup_passwd.Location = new System.Drawing.Point(72, 124);
            this.lbl_signup_passwd.Name = "lbl_signup_passwd";
            this.lbl_signup_passwd.Size = new System.Drawing.Size(47, 16);
            this.lbl_signup_passwd.TabIndex = 1;
            this.lbl_signup_passwd.Text = "Senha";
            // 
            // lbl_signup_user_name
            // 
            this.lbl_signup_user_name.AutoSize = true;
            this.lbl_signup_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_signup_user_name.Location = new System.Drawing.Point(64, 96);
            this.lbl_signup_user_name.Name = "lbl_signup_user_name";
            this.lbl_signup_user_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_signup_user_name.TabIndex = 1;
            this.lbl_signup_user_name.Text = "Usuário";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.panel_signup);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MFCloud";
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_led)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).EndInit();
            this.panel_signup.ResumeLayout(false);
            this.panel_signup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_signup_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label lbl_status_user;
        private System.Windows.Forms.Label lbl_status_access;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.PictureBox pb_login_logo;
        private System.Windows.Forms.Label lbl_login_passwd;
        private System.Windows.Forms.Label lbl_login_user_name;
        private System.Windows.Forms.TextBox txtbox_login_passwd;
        private System.Windows.Forms.TextBox txtbox_login_user_name;
        private System.Windows.Forms.Button btn_login_signup;
        private System.Windows.Forms.Label lbl_login_MFCloud;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Panel panel_signup;
        private System.Windows.Forms.TextBox txtbox_signup_user_name;
        private System.Windows.Forms.TextBox txtbox_signup_passwd;
        private System.Windows.Forms.Label lbl_signup_MFCloud;
        private System.Windows.Forms.Button btn_signup_signup;
        private System.Windows.Forms.Button btn_signup_back;
        private System.Windows.Forms.PictureBox pb_signup_logo;
        private System.Windows.Forms.Label lbl_signup_passwd;
        private System.Windows.Forms.Label lbl_signup_user_name;
        private System.Windows.Forms.TextBox txtbox_signup_confirm_passwd;
        private System.Windows.Forms.Label lbl_signup_confirm_passwd;
        public System.Windows.Forms.Label lbl_status_user_name;
        public System.Windows.Forms.Label lbl_status_access_num;
        public System.Windows.Forms.PictureBox pb_status_led;
    }
}

