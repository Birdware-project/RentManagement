using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class user_admin : Form
    {
        string connectionString;
        SqlCommand cmd;
        SqlConnection cnn;

        Login _login;
        public user_admin(string connectionSource,Login login)
        {
            connectionString = connectionSource;
            InitializeComponent();
            login = login;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Users where ID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = 1;
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
                    var _username = kd["name"].ToString();
                    var _password = kd["password"].ToString();

                    if (this.TB_username.Text == _username && this.TB_password.Text == _password)
                    {
                        User kk = new User(connectionString);
                        kk.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect User Admin Login !");
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
