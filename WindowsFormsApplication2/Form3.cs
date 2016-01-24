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
    public partial class user_register : Form
    {
        public user_register()
        {
            InitializeComponent();
        }

        private void user_register_Load(object sender, EventArgs e)
        {
            hint.Text = "Hint: use random symbols instead of your private information," + Environment.NewLine + "like your name, phone number, e-mail etc.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (incl_security.Checked)
            {
                security_question.Enabled = true;
                security_answer.Enabled = true;
                code_gen.Enabled = true;
            }
            else {
                security_question.Enabled = false;
                security_answer.Enabled = false;
                code_gen.Enabled = false;
            }
        }

        
    }
}
