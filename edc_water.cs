using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class edc_water : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True";
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;
        public edc_water()
        {
            InitializeComponent();
            showData_water();
            _ListRoomId();
        }
        private void _ListRoomId()
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select room_id from Tb_Room";
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.id_room.Items.Add(kd["Room_ID"].ToString());
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
            //// note duplicate
            //for (int item = 0; item < dataview_water.Rows.Count - 1; item++)
            //{
            //    if (id_watandedc.Text == dataview_water.Rows[item].Cells[0].Value.ToString())
            //    {
            //        MessageBox.Show("ID Duplicate");
            //        cnn.Close();
            //        return;
            //    }

            //}
            myhome.CommandText = "insert into Tb_edcandwater(Room_ID,Date,EDC_Values,Water_Valuse,Old_EDC,Old_Water,New_EDC,New_Water)" +
                "values (@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9)";
            myhome.Parameters.Add("@param2", SqlDbType.Int).Value = id_room.Text;
            myhome.Parameters.Add("@param3", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = total_edc.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar, 250).Value = total_wat.Text;
            myhome.Parameters.Add("@param6", SqlDbType.VarChar, 250).Value = old_edc.Text;
            myhome.Parameters.Add("@param7", SqlDbType.VarChar, 250).Value = old_wat.Text;
            myhome.Parameters.Add("@param8", SqlDbType.VarChar, 250).Value = new_edc.Text;
            myhome.Parameters.Add("@param9", SqlDbType.VarChar, 250).Value = new_wat.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            showData_water();
            id_room.Text = "";
            date_time.Text = "";
            total_wat.Text = "";
            total_edc.Text = "";
            old_edc.Text = "";
            old_wat.Text = "";
            new_edc.Text = "";
            new_wat.Text = "";
        }
        private void showData_water()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select FORMAT(date,'dd/MMM/yyyy') Date,Id,Room_ID,EDC_Values,Water_Valuse,Old_EDC,Old_Water,New_EDC,New_Water from tb_edcandwater", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_water.DataSource = dt;
            dataview_water.Sort(dataview_water.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_edcandwater where ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.txt_filter.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.LB_id.Text = kd["id"].ToString();
                    this.id_room.Text = kd["Room_ID"].ToString();
                    this.date_time.Text = kd["Date"].ToString();
                    this.total_edc.Text = kd["EDC_Values"].ToString();
                    this.total_wat.Text = kd["Water_Valuse"].ToString();
                    this.old_edc.Text = kd["Old_EDC"].ToString();
                    this.old_wat.Text = kd["Old_Water"].ToString();
                    this.new_edc.Text = kd["New_EDC"].ToString();
                    this.new_wat.Text = kd["New_Water"].ToString();
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
            myhome.CommandText = "update Tb_edcandwater set Room_ID=@param2,Date=@param3,EDC_Values=@param4,Water_Valuse=@param5,Old_EDC=@param6,Old_Water=@param7,New_EDC=@param8,New_Water=@param9 where ID=@param1";
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = LB_id.Text;
            myhome.Parameters.Add("@param2", SqlDbType.Int).Value = id_room.Text;
            myhome.Parameters.Add("@param3", SqlDbType.Date).Value = date_time.Value.ToString("yyyy-MM-dd");
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = total_edc.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar, 250).Value = total_wat.Text;
            myhome.Parameters.Add("@param6", SqlDbType.VarChar, 250).Value = old_edc.Text;
            myhome.Parameters.Add("@param7", SqlDbType.VarChar, 250).Value = old_wat.Text;
            myhome.Parameters.Add("@param8", SqlDbType.VarChar, 250).Value = new_edc.Text;
            myhome.Parameters.Add("@param9", SqlDbType.VarChar, 250).Value = new_wat.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_water();
            id_room.Text = "";
            date_time.Text = "";
            total_wat.Text = "";
            total_edc.Text = "";
            old_edc.Text = "";
            old_wat.Text = "";
            new_edc.Text = "";
            new_wat.Text = "";
        }

        private void bt_filteredc_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_edcandwater where Room_ID like '%" + txt_filter.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_water.DataSource = dt;
            dataview_water.Sort(dataview_water.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bt_Total_Click(object sender, EventArgs e)
        {
            total_edc.Text = (Convert.ToDouble(new_edc.Text) - Convert.ToDouble(old_edc.Text)).ToString();
            total_wat.Text = (Convert.ToDouble(new_wat.Text) - Convert.ToDouble(old_wat.Text)).ToString();
        }
        private void _FillOldnumber()
        {
            DateTime _thisDate = this.date_time.Value;
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from tb_edcandwater where date < @date1 and date > @date2 ";
            myhome.Parameters.Add("@date1", SqlDbType.Date).Value = new DateTime(_thisDate.Year,_thisDate.Month,1);
            myhome.Parameters.Add("@date2", SqlDbType.Date).Value = new DateTime(_thisDate.Year, _thisDate.Month-1, 1);
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            kd = myhome.ExecuteReader();
            while (kd.Read())
            {
                this.old_edc.Text = kd["old_edc"].ToString();
                this.old_wat.Text = kd["old_water"].ToString();
            }
        }

        private void _FillOldnumber(object sender, EventArgs e)
        {
            _FillOldnumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LB_id.Text = "";
            id_room.Text = "";
            date_time.Text = "";
            total_wat.Text = "";
            total_edc.Text = "";
            old_edc.Text = "";
            old_wat.Text = "";
            new_edc.Text = "";
            new_wat.Text = "";
        }
    }
}
