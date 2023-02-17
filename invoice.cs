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
    public partial class invoice : Form
    {
        string connectionString;
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        private string _userID;
        public invoice(string connection,string userID)
        {
            InitializeComponent();
            connectionString = connection;
            Lb_userID.Text = userID;
            _userID = userID;
            showData_invoice();
            _ListRoomId();
            _ListEDC();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ListRoomId()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select roomid from Room";
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.CB_roomid.Items.Add(kd["RoomID"].ToString());
            }
        }
        private void _ListEDC()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select ID from edc_water";
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.cb_edc.Items.Add(kd["ID"].ToString());
            }
        }
        private void showData_invoice()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Invoice", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            // note duplicate
            //for (int item = 0; item < dataGridView1.Rows.Count - 1; item++)
            //{
            //    if (id_invoice.Text == dataGridView1.Rows[item].Cells[0].Value.ToString())
            //    {
            //        MessageBox.Show("ID Duplicate");
            //        cnn.Close();
            //        return;
            //    }

            //}
            myhome.CommandText = "insert into invoice(" +
                "Room_ID,User_ID,Edc_ID,EDC_Price,Water_Price,Vehicle_Price,Trash_Price,Date,Room_Money)" +
                "values(" +
                "@roomID,@userID,@edc_price,@water_price,@vehicle_price,@trash_price,@date_time,@money_room,@edc)";
            myhome.Parameters.Add("@roomID", SqlDbType.Int).Value = CB_roomid.Text;
            myhome.Parameters.Add("@userID", SqlDbType.Int).Value = Lb_userID.Text;
            myhome.Parameters.Add("@edc_price", SqlDbType.VarChar, 250).Value = edc_price.Text;
            myhome.Parameters.Add("@water_price", SqlDbType.VarChar,250).Value = water_price.Text;
            myhome.Parameters.Add("@vehicle_price", SqlDbType.VarChar,250).Value = vehicle_price.Text;
            myhome.Parameters.Add("@trash_price", SqlDbType.VarChar,250).Value = trash_price.Text;
            myhome.Parameters.Add("@date_time", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@money_room", SqlDbType.VarChar, 250).Value = money_room.Text;
            myhome.Parameters.Add("@edc", SqlDbType.VarChar, 250).Value = cb_edc.Text;

            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            showData_invoice();
            LB_invoiceID.Text = "";
            Lb_userID.Text = "";
            CB_roomid.Text = "";
            edc_price.Text = "";
            vehicle_price.Text = "";
            date_time.Text = "";
            money_room.Text = "";
            total_num_water.Text = "";
            total_num_edc.Text = "";
            vehicle_space.Text = "";
            trash_service.Text = "";
            cb_edc.Text = "";
            trash_price.Text = "";
            water_price.Text = "";

        }

        private void CB_roomid_SelectedValueChanged(object sender, EventArgs e)
        {
            _RoomMoney();
        }
        private void _RoomMoney()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_menu where Rent_ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.CB_roomid.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.money_room.Text = (kd["Room_Money"].ToString());
                this.trash_service.Text = (kd["Trash_Service"].ToString());
                this.vehicle_space.Text = (kd["Vehicle_Space"].ToString());
            }

        }
        private void _edc()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_edcandwater where ID =@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.cb_edc.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.total_num_edc.Text = kd["EDC_Values"].ToString();
                this.total_num_water.Text = kd["Water_Valuse"].ToString();
            }
        }

        private void cb_edc_SelectedIndexChanged(object sender, EventArgs e)
        {
            _edc();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_Invoice where Invoice_ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.TB_filter.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.LB_invoiceID.Text = kd["Invoice_ID"].ToString();
                    this.Lb_userID.Text = kd["User_ID"].ToString();
                    this.edc_price.Text = kd["EDC_Price"].ToString();
                    this.water_price.Text = kd["Water_Price"].ToString();
                    this.water_price.Text = kd["Water_Price"].ToString();
                    this.vehicle_price.Text = kd["Vehicle_Price"].ToString();
                    this.trash_price.Text = kd["Trash_Price"].ToString();
                    this.date_time.Text = kd["Date"].ToString();
                    this.money_room.Text = kd["Room_Money"].ToString();
                    this.total_num_water.Text = (float.Parse(kd["TotalMoney_Water"].ToString()) / float.Parse(water_price.Text)).ToString();
                    this.total_num_edc.Text = (float.Parse(kd["TotalMoney_EDC"].ToString()) / float.Parse(water_price.Text)).ToString();

                    this.CB_roomid.Text = kd["Room_ID"].ToString();
                    this.cb_edc.Text = kd["Edc_ID"].ToString();
                    
                }
                showData_invoice();
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
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "update Tb_Invoice set Room_ID=@param2,User_ID=@param3,EDC_Price=@param4,Water_Price=@param5,Vehicle_Price=@param6,Trash_Price=@param7,Date=@param8,Room_Money=@param10,Edc_ID=@param13 where Invoice_ID=@param1";
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = LB_invoiceID.Text;
            myhome.Parameters.Add("@param2", SqlDbType.Int).Value = CB_roomid.Text;
            myhome.Parameters.Add("@param3", SqlDbType.Int).Value = Lb_userID.Text;
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = edc_price.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar, 250).Value = water_price.Text;
            myhome.Parameters.Add("@param6", SqlDbType.VarChar, 250).Value = vehicle_price.Text;
            myhome.Parameters.Add("@param7", SqlDbType.VarChar, 250).Value = trash_price.Text;
            myhome.Parameters.Add("@param8", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@param10", SqlDbType.VarChar, 250).Value = money_room.Text;
            myhome.Parameters.Add("@param13", SqlDbType.VarChar, 250).Value = cb_edc.Text;


            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_invoice();
            Lb_userID.Text = "";
            LB_invoiceID.Text = "";
            CB_roomid.Text = "";
            edc_price.Text = "";
            vehicle_price.Text = "";
            date_time.Text = "";
            money_room.Text = "";
            total_num_water.Text = "";
            total_num_edc.Text = "";
            vehicle_space.Text = "";
            trash_service.Text = "";
            cb_edc.Text = "";
            trash_price.Text = "";
            water_price.Text = "";
        }

        private void bt_total_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            ViewInvoice viewInvoice = new ViewInvoice(this.CB_roomid.Text,
                this.total_num_water.Text,this.water_price.Text, this.total_num_edc.Text,this.trash_price.Text,
                this.vehicle_price.Text,this.money_room.Text,this.edc_price.Text,this.vehicle_space.Text,this.trash_service.Text);
            viewInvoice.Show();
        }
    }
}
