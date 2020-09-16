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
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_signup_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_signup.Visible = true;
        }

        private void btn_signup_cancel_Click(object sender, EventArgs e)
        {
            panel_signup.Visible = false;
            panel_login.Visible = true;
        }
    }
}
