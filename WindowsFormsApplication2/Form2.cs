using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string usr = username.Text;
            string psw = password.Text;
            
            if (String.IsNullOrEmpty(usr) && String.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Both fields are empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(usr))
            {
                MessageBox.Show("Username field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Password field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            else { 
                
            }
        }

        
    }
}
