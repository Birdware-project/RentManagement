using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class User : Form
    {
        string connectionString;
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        public User(string connection)
        {
            connectionString = connection;
            InitializeComponent();
            showData_user();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            //Login kk = new Login();
            //kk.Show();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText =
                "insert into Users(Name,Sex,Phone,Password)" +
                "values(@param2,@param3,@param4,@param5)";
            cmd.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = name_user.Text;
            cmd.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = CB_sex.Text;
            cmd.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = phone_user.Text;
            cmd.Parameters.Add("@param5", SqlDbType.Int).Value = password_user.Text;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
            showData_user();
            id_user.Text = "";
            name_user.Text = "";
            CB_sex.Text = "";
            phone_user.Text = "";
            password_user.Text = "";
        }
        private void showData_user()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Users", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_user.DataSource = dt;
            dataview_user.Sort(dataview_user.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Users where ID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = this.TB_filterSearch.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            kd = cmd.ExecuteReader();
            while (kd.Read())
            {
                this.id_user.Text = kd["ID"].ToString();
                this.name_user.Text = kd["name"].ToString();
                this.CB_sex.Text = kd["Sex"].ToString();
                this.phone_user.Text = kd["Phone"].ToString();
                this.password_user.Text = kd["password"].ToString();
            }
            showData_user();
            cnn.Close();
        }
        private void bt_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "update Users " +
                "set Name=@param2,Sex=@param3,Phone=@param4,Password=@param5 " +
                "where ID=@param1";
            cmd.Parameters.Add("@param1", SqlDbType.Int).Value = this.id_user.Text;
            cmd.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = this.name_user.Text;
            cmd.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = this.CB_sex.Text;
            cmd.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = this.phone_user.Text;
            cmd.Parameters.Add("@param5", SqlDbType.VarChar, 250).Value = this.password_user.Text;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_user();
            id_user.Text = "";
            name_user.Text = "";
            CB_sex.Text = "";
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
                cmd = new SqlCommand();
                cmd.CommandText = " delete  from users where ID =" + id_user.Text + "";
                cnn.Open();
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
                showData_user();
                MessageBox.Show("Data delete Success!");
                id_user.Text = "";
            }
        }

        private void bt_filter_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Users where Name like '%" + TB_filterSearch.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_user.DataSource = dt;
            dataview_user.Sort(dataview_user.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
