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
using System.IO;

namespace moneyhome
{
    public partial class Room : Form
    {
        string connectionString;
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        string _userID;
        public Room(string connection)
        {
            InitializeComponent();
            connectionString = connection;
            showData_room1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO  Room(Price,Name) " +
                "VALUES (@price,@name)";
            cmd.Parameters.Add("@price", SqlDbType.VarChar, 250).Value = this.LB_roomPrice.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 250).Value = this.LB_RoomName.Text;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
            showData_room1();
            id_room.Text = "";
            LB_roomPrice.Text = "";
            LB_RoomName.Text = "";
        }
        private void showData_room1()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Room", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_room1.DataSource = dt;
            dataview_room1.Sort(dataview_room1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Room where Name like '%" + TB_FilterSearch.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_room1.DataSource = dt;
            dataview_room1.Sort(dataview_room1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Room where ID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = this.TB_FilterSearch.Text;
            cmd.Connection = cnn;

            cnn.Open();
            SqlDataReader kd;


            kd = cmd.ExecuteReader();
            while (kd.Read())
            {
                this.id_room.Text = kd["ID"].ToString();
                this.LB_roomPrice.Text = kd["Price"].ToString();
                this.LB_RoomName.Text = kd["Name"].ToString();
               
            }
            showData_room1();

            cnn.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            MemoryStream ms;
            cmd.CommandText = "update Room " +
                "set Price=@price,Name=@name where ID=@id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.id_room.Text;
            cmd.Parameters.Add("@price", SqlDbType.VarChar, 250).Value = this.LB_roomPrice.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 250).Value = this.LB_RoomName.Text;

            cnn.Open();
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_room1();
            id_room.Text = "";
            LB_roomPrice.Text = "";
            LB_RoomName.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            id_room.Text = "";
            LB_roomPrice.Text = "";
            LB_RoomName.Text = "";
        }
    }
}
