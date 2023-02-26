using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class edc_water : Form
    {
        string connectionString;
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        string userID;
        public edc_water(string connection,string userID)
        {
            this.userID= userID;
            this.connectionString = connection;
            InitializeComponent();
            showData_water();
            _ListRoomId();

            LB_userID.Text = userID;
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
                this.CB_roomID.Items.Add(kd["ID"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {

            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            
            myhome.CommandText = "" +
                "insert into " +
                "edc_water(RoomID,userID,Date,EDC_old,Water_old,EDC_new,Water_new)" +
                "values (@roomid,@userid,@date,@edc_old,@water_old,@edc_new,@water_new)";
            myhome.Parameters.Add("@roomid", SqlDbType.Int).Value = CB_roomID.Text;
            myhome.Parameters.Add("@userid", SqlDbType.Int).Value = this.userID.ToString();
            myhome.Parameters.Add("@date", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@edc_old", SqlDbType.VarChar, 250).Value = TB_old_edc.Text;
            myhome.Parameters.Add("@water_old", SqlDbType.VarChar, 250).Value = TB_old_wat.Text;
            myhome.Parameters.Add("@edc_new", SqlDbType.VarChar, 250).Value = TB_new_edc.Text;
            myhome.Parameters.Add("@water_new", SqlDbType.VarChar, 250).Value = TB_new_wat.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            showData_water();
            _clearForm();
        }
        private void showData_water()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select FORMAT(date,'dd/MMM/yyyy') Date,* from edc_water", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_water.DataSource = dt;
            dataview_water.Sort(dataview_water.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from edc_water where ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.TB_FilterSearch.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.LB_id.Text = kd["id"].ToString();
                    this.CB_roomID.Text = kd["RoomID"].ToString();
                    this.date_time.Text = kd["Date"].ToString();
                    this.TB_old_edc.Text = kd["EDC_old"].ToString();
                    this.TB_old_wat.Text = kd["Water_old"].ToString();
                    this.TB_new_edc.Text = kd["EDC_new"].ToString();
                    this.TB_new_wat.Text = kd["Water_new"].ToString();
                }
                showData_water();
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
            myhome.CommandText = "update edc_water " +
                "set RoomID=@roomid,userID = @userid,Date=@date,EDC_old=@edc_old,Water_old=@water_old," +
                "EDC_new=@edc_new,Water_new=@water_new where ID=@id";
            myhome.Parameters.Add("@id", SqlDbType.Int).Value = LB_id.Text;
            myhome.Parameters.Add("@roomid", SqlDbType.Int).Value = CB_roomID.Text;
            myhome.Parameters.Add("@userid", SqlDbType.Int).Value = this.userID;
            myhome.Parameters.Add("@date", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@edc_old", SqlDbType.VarChar, 250).Value = TB_old_edc.Text;
            myhome.Parameters.Add("@water_old", SqlDbType.VarChar, 250).Value = TB_old_wat.Text;
            myhome.Parameters.Add("@edc_new", SqlDbType.VarChar, 250).Value = TB_new_edc.Text;
            myhome.Parameters.Add("@water_new", SqlDbType.VarChar, 250).Value = TB_new_wat.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_water();
            _clearForm();
        }

        private void bt_filteredc_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from edc_water where RoomID like '%" + TB_FilterSearch.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_water.DataSource = dt;
            dataview_water.Sort(dataview_water.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bt_Total_Click(object sender, EventArgs e)
        {}
        private void _edc_waterOldnumber()
        {
            //MessageBox.Show("love");
            DateTime _thisDate = this.date_time.Value;
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from edc_water where Date < @date1 and date >= @date2 and roomid = @roomid ";
            myhome.Parameters.Add("@date1", SqlDbType.Date).Value = new DateTime(_thisDate.Year, _thisDate.Month, 1);
            myhome.Parameters.Add("@date2", SqlDbType.Date).Value = new DateTime(_thisDate.Year, _thisDate.Month, 1).AddMonths(-1);
            myhome.Parameters.Add("@roomid", SqlDbType.Int).Value = CB_roomID.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.TB_old_edc.Text = kd["edc_new"].ToString();
                this.TB_old_wat.Text = kd["water_new"].ToString();
            }
            
        }

        private void _clearForm()
        {
            LB_id.Text = "";
            CB_roomID.Text = "";
            date_time.Text = "";
            TB_old_edc.Text = "0";
            TB_old_wat.Text = "0";
            TB_new_edc.Text = "0";
            TB_new_wat.Text = "0";
        }
        private void CB_roomID_SelectedValueChanged(object sender, EventArgs e)
        {
            _edc_waterOldnumber();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            LB_id.Text = "";
            CB_roomID.Text = "";
            date_time.Text = "";
            TB_old_edc.Text = "0";
            TB_old_wat.Text = "0";
            TB_new_edc.Text = "0";
            TB_new_wat.Text = "0";
        }

        private void date_time_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CB_roomID.Text))
            {
                _edc_waterOldnumber();
            }
        }
    }
}
