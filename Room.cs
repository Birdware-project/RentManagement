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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True";
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        public Room()
        {
            InitializeComponent();
            showData_room1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "INSERT INTO  Tb_Room(Room_Price,Room_Name) VALUES (@param2,@param3)"; 
            myhome.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = this.price_room.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = this.name_room.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            showData_room1();
            id_room.Text = "";
            price_room.Text = "";
            name_room.Text = "";
        }
        private void showData_room1()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_Room", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_room1.DataSource = dt;
            dataview_room1.Sort(dataview_room1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_Room where Room_ID like '%" + filter_room.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_room1.DataSource = dt;
            dataview_room1.Sort(dataview_room1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_Room where Room_ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.filter_room.Text;
            myhome.Connection = cnn;

            cnn.Open();
            SqlDataReader kd;


            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.id_room.Text = kd["Room_ID"].ToString();
                this.price_room.Text = kd["Room_Price"].ToString();
                this.name_room.Text = kd["Room_Name"].ToString();
               
            }
            showData_room1();

            cnn.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            myhome = new SqlCommand();
            MemoryStream ms;
            myhome.CommandText = "update Tb_Room set Room_Price=@param2,Room_Name=@param3 where Room_ID=@param1";
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = this.id_room.Text;
            myhome.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = this.price_room.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = this.name_room.Text;

            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_room1();
            id_room.Text = "";
            price_room.Text = "";
            name_room.Text = "";
        }
    }
}
