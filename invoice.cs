using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
        public invoice(string connection, string userID)
        {
            InitializeComponent();
            connectionString = connection;
            Lb_userID.Text = userID;
            _userID = userID;
            showData_invoice();
            _ListRoomId();
            _ListEDC();
            _checkTextNullInTexboxt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ListRoomId()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select id from Room";
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.CB_roomid.Items.Add(kd["ID"].ToString());
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
            myhome.CommandText = "insert into invoice(" +
                "RoomID,UserID,Edc_waterID,EDC_Price,Water_Price,space_price,Trash_price,Date,Room_price,isSpace,isTrash)" +
                "values(" +
                "@roomID,@userID,@edcID,@edc_price,@water_price,@vehicle_price,@trash_price,@date_time,@money_room,@isspace,@istrash)";
            myhome.Parameters.Add("@roomID", SqlDbType.Int).Value = CB_roomid.Text;
            myhome.Parameters.Add("@userID", SqlDbType.Int).Value = Lb_userID.Text;
            myhome.Parameters.Add("@edcID", SqlDbType.Int).Value = cb_edc.Text;
            myhome.Parameters.Add("@edc_price", SqlDbType.VarChar, 250).Value = edc_price.Text;
            myhome.Parameters.Add("@water_price", SqlDbType.VarChar, 250).Value = water_price.Text;
            myhome.Parameters.Add("@vehicle_price", SqlDbType.VarChar, 250).Value = space_price.Text;
            myhome.Parameters.Add("@trash_price", SqlDbType.VarChar, 250).Value = trash_price.Text;
            myhome.Parameters.Add("@date_time", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@money_room", SqlDbType.VarChar, 250).Value = room_price.Text;
            myhome.Parameters.Add("@istrash", SqlDbType.Int).Value = LB_is_trash.Text;
            myhome.Parameters.Add("@isspace", SqlDbType.Int).Value = LB_is_space.Text;

            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            showData_invoice();
            LB_invoiceID.Text = "";
            Lb_userID.Text = "";
            CB_roomid.Text = "";
            edc_price.Text = "";
            space_price.Text = "";
            date_time.Text = "";
            room_price.Text = "";
            total_num_water.Text = "";
            total_num_edc.Text = "";
            LB_is_space.Text = "";
            LB_is_trash.Text = "";
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
            myhome.CommandText = "select * from Rent a join Room b on a.roomid = b.id where a.ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.CB_roomid.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.room_price.Text = (kd["Price"].ToString());
                this.LB_is_trash.Text = (kd["isTrash"].ToString());
                this.LB_is_space.Text = (kd["isSpace"].ToString());
            }

        }
        private void _edc()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from edc_water where ID =@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.cb_edc.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.total_num_edc.Text = (Int32.Parse(kd["EDC_new"].ToString()) - Int32.Parse(kd["EDC_old"].ToString())).ToString();
                this.total_num_water.Text = (Int32.Parse(kd["water_new"].ToString()) - Int32.Parse(kd["water_old"].ToString())).ToString(); ;
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
            myhome.CommandText = "select * from Invoice where ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.TB_filterSearch.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.LB_invoiceID.Text = kd["ID"].ToString();
                this.Lb_userID.Text = kd["UserID"].ToString();
                this.edc_price.Text = kd["EDC_Price"].ToString();
                this.water_price.Text = kd["Water_Price"].ToString();
                this.space_price.Text = kd["space_Price"].ToString();
                this.trash_price.Text = kd["Trash_Price"].ToString();
                LB_is_trash.Text = kd["istrash"].ToString();
                LB_is_space.Text = kd["isspace"].ToString();
                this.date_time.Text = kd["Date"].ToString();
                this.room_price.Text = kd["Room_price"].ToString();
                //this.total_num_water.Text = (float.Parse(kd["TotalMoney_Water"].ToString()) / float.Parse(water_price.Text)).ToString();
                //this.total_num_edc.Text = (float.Parse(kd["TotalMoney_EDC"].ToString()) / float.Parse(water_price.Text)).ToString();

                this.CB_roomid.Text = kd["RoomID"].ToString();
                this.cb_edc.Text = kd["Edc_waterID"].ToString();
            }
            showData_invoice();
            _edc();
            cnn.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "update Invoice " +
                "set Room_ID=@param2,User_ID=@param3,EDC_Price=@param4,Water_Price=@param5,Vehicle_Price=@param6,Trash_Price=@param7,Date=@param8,Room_Money=@param10,Edc_ID=@param13 where Invoice_ID=@param1";
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = LB_invoiceID.Text;
            myhome.Parameters.Add("@param2", SqlDbType.Int).Value = CB_roomid.Text;
            myhome.Parameters.Add("@param3", SqlDbType.Int).Value = Lb_userID.Text;
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = edc_price.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar, 250).Value = water_price.Text;
            myhome.Parameters.Add("@param6", SqlDbType.VarChar, 250).Value = space_price.Text;
            myhome.Parameters.Add("@param7", SqlDbType.VarChar, 250).Value = trash_price.Text;
            myhome.Parameters.Add("@param8", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@param10", SqlDbType.VarChar, 250).Value = room_price.Text;
            myhome.Parameters.Add("@param13", SqlDbType.VarChar, 250).Value = cb_edc.Text;


            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_invoice();
            LB_invoiceID.Text = "";
            CB_roomid.Text = "";
            edc_price.Text = "";
            space_price.Text = "";
            date_time.Text = "";
            room_price.Text = "";
            total_num_water.Text = "";
            total_num_edc.Text = "";
            LB_is_space.Text = "";
            LB_is_trash.Text = "";
            cb_edc.Text = "";
            trash_price.Text = "";
            water_price.Text = "";
        }

        private void bt_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            var _trashExpense = (float.Parse(LB_is_trash.Text) * float.Parse(trash_price.Text)).ToString();
            var _spaceExpense = (float.Parse(LB_is_space.Text)*float.Parse(space_price.Text)).ToString();
            ViewInvoice viewInvoice = new ViewInvoice(
                LB_invoiceID.Text,Lb_userID.Text,
                water_price.Text,total_num_water.Text,
                edc_price.Text,total_num_edc.Text,
                _trashExpense,_spaceExpense,room_price.Text
                );
            viewInvoice.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LB_invoiceID.Text = "";
            CB_roomid.Text = "";
            edc_price.Text = "";
            space_price.Text = "";
            date_time.Text = DateTime.Now.ToString();
            room_price.Text = "";
            total_num_water.Text = "";
            total_num_edc.Text = "";
            LB_is_space.Text = "";
            LB_is_trash.Text = "";
            cb_edc.Text = "";
            trash_price.Text = "";
            water_price.Text = "";

        }
        private void _checkTextNullInTexboxt()
        {
            if ((CB_roomid.Text).Length == 0 || 
                (water_price.Text).Length ==0)
            {
                btn_insert.BackColor = Color.DarkGray;
                btn_insert.Enabled= false;
                
                btn_update.Enabled= false;
                btn_update.BackColor = Color.DarkGray;
            }
            else
            {
                btn_insert.Enabled= true;
            }
        }

        private void CB_roomid_TextChanged(object sender, EventArgs e)
        {
            _checkTextNullInTexboxt();
        }

        private void water_price_TextChanged(object sender, EventArgs e)
        {
            _checkTextNullInTexboxt();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {

        }
    }
}
