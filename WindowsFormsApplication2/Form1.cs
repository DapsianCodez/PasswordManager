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
    public partial class start_screen : Form
    {
        public start_screen()
        {
            InitializeComponent();
        }

        private void existing_user_Click(object sender, EventArgs e)
        {
            user_login exist = new user_login();
            exist.Show();
            
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            user_register New = new user_register();
            New.Show();
        }

        private void start_screen_Load(object sender, EventArgs e)
        {

        }

        
    }
}
