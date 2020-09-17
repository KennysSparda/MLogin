using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_M
{
    public partial class frm_login : Form
    {
        DataTable dt = new DataTable();
        public frm_login()
        {
            InitializeComponent();
        }

        public void gotopanellogin()
        {
            panel_signup.Visible = false;
            panel_login.Visible = true;
        }

        public void gotopanelsignup()
        {
            panel_login.Visible = false;
            panel_signup.Visible = true;
        }

        public int signup()
        {
            user new_user = new user();
            new_user.user_name = txtbox_signup_user_name.Text;
            new_user.user_password = txtbox_signup_passwd.Text;
            new_user.confirm_user_password = txtbox_signup_confirm_passwd.Text;
            if (txtbox_signup_user_name.Text == "")
            {
                MessageBox.Show("Preencha o campo usuário");
                return -1;
            }
            else if (txtbox_signup_passwd.Text == "")
            {
                MessageBox.Show("Preencha o campo senha");
                return -1;
            }
            else if (txtbox_signup_passwd.Text == "")
            {
                MessageBox.Show("Preencha o campo confirmar senha");
                return -1;
            }
            else if (txtbox_signup_passwd.Text == txtbox_signup_confirm_passwd.Text)
            {
                database.NewUser(new_user);

                txtbox_signup_user_name.Clear();
                txtbox_signup_passwd.Clear();
                txtbox_signup_confirm_passwd.Clear();
                return 0;
            }
            else
            {
                MessageBox.Show("Essas senhas não coincidem!");
                txtbox_signup_confirm_passwd.Focus();
                return -1;
            }
        
        }

        public int login()
        {
            string username = txtbox_login_user_name.Text;
            string passwd = txtbox_login_passwd.Text;

            if (username == "")
            {
                MessageBox.Show("Preencha o campo usuário");
                txtbox_login_user_name.Focus();
                return -1;
            }
            else if (passwd == "")
            {
                MessageBox.Show("Preencha o campo senha");
                txtbox_login_passwd.Focus();
                return -1;
            }
            else
            {
                dt = database.Command("SELECT * FROM tb_users WHERE USER_NAME='" + username + "' AND USER_PASSWD='" + passwd + "'");
                if (dt.Rows.Count == 1)
                {
                    Global.logado = true;
                    lbl_status_access_num.Text = "1";
                    lbl_status_user_name.Text = dt.Rows[0].Field<string>("USER_NAME");
                    pb_status_led.Image = Properties.Resources.led_green;
                    panel_login.Visible = false;
                    return 0;
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                    return -1;
                }
            }
        }

        private void btn_login_signup_Click(object sender, EventArgs e)
        {
            gotopanelsignup();
        }

        private void btn_signup_cancel_Click(object sender, EventArgs e)
        {
            gotopanellogin();
        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btn_signup_signup_Click(object sender, EventArgs e)
        {
            signup();
        }
    }
}
