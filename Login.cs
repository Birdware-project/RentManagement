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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True";
        SqlCommand myhome;
        SqlConnection cnn;
        public Login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _userID;
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_User where User_name=@username";
            myhome.Parameters.Add("@username", SqlDbType.VarChar).Value = this.user_login.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = myhome.ExecuteReader();
                if (!kd.HasRows)
                {
                    MessageBox.Show("Incorrect User  Login !");
                }
                while (kd.Read())
                {
                    _userID = kd["user_id"].ToString();
                    var _username = kd["User_name"].ToString();
                    var _password = kd["User_password"].ToString();

                    if (this.user_login.Text == _username && this.password_user.Text == _password)
                    {
                        this.Hide();
                        Rent mm = new Rent(_userID);
                        
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
