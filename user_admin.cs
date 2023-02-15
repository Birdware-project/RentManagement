using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class user_admin : Form
    {
        public user_admin()
        {
            InitializeComponent();
            timer2.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = "Admin";
            string password = "1234";
            if (this.adminuser.Text == userName && this.adminpassword.Text == password)
            {
                User kk = new User();
                kk.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User Admin Login !");
            }
        }
    }
}
