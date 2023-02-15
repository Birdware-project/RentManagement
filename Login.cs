using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace moneyhome
{
    public partial class Login : Form
    {
        string connectionString; 
        
        SqlCommand cmd;
        SqlConnection cnn;
        public Login(string connectionSource)
        {
            connectionString = connectionSource;
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _userID;
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Tb_User where User_name=@username";
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.LB_username.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = cmd.ExecuteReader();
                if (!kd.HasRows)
                {
                    MessageBox.Show("Incorrect User  Login !");
                }
                while (kd.Read())
                {
                    _userID = kd["user_id"].ToString();
                    var _username = kd["User_name"].ToString();
                    var _password = kd["User_password"].ToString();

                    if (this.LB_username.Text == _username && this.LB_password.Text == _password)
                    {
                        this.Close();
                        Rent mm = new Rent(_userID,connectionString);
                        mm.Show();
                    }

                }
            }
            catch
            {
                MessageBox.Show("error user input");
            }
            finally
            {
                cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                this.Hide();
                user_admin kk = new user_admin();
                kk.Show();
           
        }
    }
}
