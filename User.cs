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
    public partial class User : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True";
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        public User()
        {
            InitializeComponent();
            showData_user();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login kk = new Login();
            kk.Show();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            // note duplicate
            for (int item = 0; item < dataview_user.Rows.Count - 1; item++)
            {
                if (password_user.Text == dataview_user.Rows[item].Cells[0].Value.ToString())
                {
                    MessageBox.Show("ID Duplicate");
                    cnn.Close();
                    return;
                }

            }
            myhome.CommandText = "insert into Tb_User(User_Name,User_Sex,User_Phone,User_Password)" +
                "values(@param2,@param3,@param4,@param5)";
            myhome.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = name_user.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = sex_user.Text;
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = phone_user.Text;
            myhome.Parameters.Add("@param5", SqlDbType.Int).Value = password_user.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            showData_user();
            id_user.Text = "";
            name_user.Text = "";
            sex_user.Text = "";
            phone_user.Text = "";
            password_user.Text = "";
        }
        private void showData_user()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_User", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_user.DataSource = dt;
            dataview_user.Sort(dataview_user.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_User where User_ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.text_filter.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.id_user.Text = kd["User_ID"].ToString();
                    this.name_user.Text = kd["User_name"].ToString();
                    this.sex_user.Text = kd["User_Sex"].ToString();
                    this.phone_user.Text = kd["User_Phone"].ToString();
                    this.password_user.Text = kd["User_password"].ToString();



                }
                showData_user();
            }
            catch
            {
                MessageBox.Show("Success!!");
            }
            finally
            {
                cnn.Close();


            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            myhome = new SqlCommand();
            myhome.CommandText = "update Tb_User set User_Name=@param2,User_Sex=@param3,User_Phone=@param4,User_Password=@param5 where User_ID=@param1";
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = this.id_user.Text;
            myhome.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = this.name_user.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = this.sex_user.Text;
            myhome.Parameters.Add("@param4", SqlDbType.VarChar,250).Value = this.phone_user.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar,250).Value = this.password_user.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_user();
            id_user.Text = "";
            name_user.Text = "";
            sex_user.Text = "";
            phone_user.Text = "";
            password_user.Text = "";
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete " + id_user.Text;
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                cnn = new SqlConnection(connectionString);
                myhome = new SqlCommand();
                myhome.CommandText = " delete  from Tb_Customer where Cus_ID =" + id_user.Text + "";
                cnn.Open();
                myhome.Connection = cnn;
                myhome.ExecuteNonQuery();
                cnn.Close();
                showData_user();
                MessageBox.Show("Data delete Success!");
                id_user.Text = "";
            }
        }

        private void bt_filter_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_User where User_Name like '%" + text_filter.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_user.DataSource = dt;
            dataview_user.Sort(dataview_user.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
