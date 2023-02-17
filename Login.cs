using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            //MessageBox.Show(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _userID;
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Users where name=@username";
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.LB_username.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = cmd.ExecuteReader();
            if (!kd.HasRows)
            {
                MessageBox.Show("Incorrect User  Login !");
            }
            while (kd.Read())
            {
                _userID = kd["id"].ToString();
                var _username = kd["name"].ToString();
                var _password = kd["password"].ToString();

                if (this.LB_username.Text == _username && this.LB_password.Text == _password)
                {
                    this.Hide();
                    using (Rent mm = new Rent(_userID, connectionString))
                    {
                        if (mm.ShowDialog(this) == DialogResult.Cancel)
                        {
                            LB_password.Text = "";
                            LB_username.Text = "";
                            this.Show();
                        }
                    }
                }

            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (user_admin kk = new user_admin(connectionString, this))
            {
                if (kk.ShowDialog(this) == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
