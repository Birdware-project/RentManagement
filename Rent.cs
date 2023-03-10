using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace moneyhome
{
    public partial class Rent : Form
    {
        string connectionString;
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        DataTable dt;

        private int _userID;

        public Rent(string UserID, string connectionSource)
        {
            connectionString = connectionSource;
            InitializeComponent();
            showData_customer();
            showData_Rent();
            list_ID_Room();

            LB_userID.Text = UserID;
            _userID = Int32.Parse(UserID);
            datagv_customer.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }
        private void list_ID_Room()
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select id from Room";
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = cmd.ExecuteReader();
            while (kd.Read())
            {
                this.CB_roomID.Items.Add(kd["ID"].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_addlist_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select id from customer where id = "+ TB_add_list.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            string _customerCheckid = "";

            kd = cmd.ExecuteReader();
            while (kd.Read())
            {
                _customerCheckid = (kd["ID"].ToString());
            }
            if (!string.IsNullOrEmpty(_customerCheckid)){
                list.Items.Add(TB_add_list.Text);
                TB_add_list.Text = "";
                this.label_member.Text = list.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("This Customer ID " + TB_add_list.Text +" not exist","Not found");
            }
            
        }

        private void bt_removelist_Click(object sender, EventArgs e)
        {
            list.Items.Remove(list.SelectedItem);
            TB_add_list.Text = "";
            this.label_member.Text = list.Items.Count.ToString();
        }

        private void bt_filtercus_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Customer where Name like '%" + filter_cus.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            datagv_customer.DataSource = dt;
            datagv_customer.Sort(datagv_customer.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void showData_customer()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select ID,name from Customer", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            datagv_customer.DataSource = dt;
            datagv_customer.Sort(datagv_customer.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            var _trash = 0;
            var _vehicle = 0;
            var _roomate = "";
            if (check_trash.Checked)
            {
                _trash = 1;
            }
            if (check_vehicle.Checked)
            {
                _vehicle = 1;
            }
            var x = 0;
            while (x < list.Items.Count)
            {
                _roomate += list.Items[x] + ",";
                x++;
            }
            cmd.CommandText = "insert into Rent" +
                "(RoomID,isTrash,isSpace,Roomate,UserID)" +
                "values(@RoomID,@istrash,@isvehicle,@roomate,@UserID)";

            cmd.Parameters.Add("@RoomID", SqlDbType.VarChar, 250).Value = CB_roomID.Text;
            cmd.Parameters.Add("@istrash", SqlDbType.Int).Value = _trash;
            cmd.Parameters.Add("@isvehicle", SqlDbType.Int).Value = _vehicle;
            cmd.Parameters.Add("@roomate", SqlDbType.VarChar, 250).Value = _roomate;
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = _userID;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
            RentID.Text = "";
            CB_roomID.Text = "";
            roomPrice.Text = "";
            list.Items.Clear();
            check_trash.Checked = false;
            check_vehicle.Checked = false;
            label_member.Text = "";
            MessageBox.Show("Data insert Success");
            showData_Rent();
        }
        private void showData_Rent()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Rent", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_Room.DataSource = dt;
            dataview_Room.Sort(dataview_Room.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }
        private void showDate_customer()
        {

        }
        private void bt_filterroom_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter2 = new SqlDataAdapter("select * from Rent where Name like '%" + filter_room.Text + "%'", cnn);
            dt = new DataTable();
            adapter2.Fill(dt);
            dataview_Room.DataSource = dt;
            dataview_Room.Sort(dataview_Room.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Rent where ID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = this.filter_room.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = cmd.ExecuteReader();
                while (kd.Read())
                {
                    this.RentID.Text = kd["ID"].ToString();
                    this.CB_roomID.Text = kd["Roomid"].ToString();
                    this.check_trash.Checked = Convert.ToInt32(kd["isTrash"].ToString()) == 1 ? true : false;
                    this.check_vehicle.Checked = Convert.ToInt32(kd["isSpace"].ToString()) == 1 ? true : false;
                    this.LB_userID.Text = kd["UserID"].ToString();

                    String str = kd["Roomate"].ToString();
                    char[] spearator = { ',' };
                    // Using the Method
                    String[] strlist = str.Split(spearator,
                           StringSplitOptions.None);
                    foreach (String s in strlist)
                    {
                        this.list.Items.Add(s);
                    }


                }
                showData_Rent();
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
            var _trash = 0;
            var _vehicle = 0;
            var _roomate = "";
            cmd = new SqlCommand();
            if (check_trash.Checked)
            {
                _trash = 1;
            }
            if (check_vehicle.Checked)
            {
                _vehicle = 1;
            }
            var x = 0;
            while (x < list.Items.Count)
            {
                _roomate += list.Items[x] + ",";
                x++;
            }
            cmd.CommandText = "update Rent set " +
                "RoomID=@roomID," +
                "isTrash=@trash,isSpace=@vehicle,Roomate=@roomate " +
                "where ID=@RentID";
            cmd.Parameters.Add("@RentID", SqlDbType.Int).Value = RentID.Text;
            cmd.Parameters.Add("@trash", SqlDbType.Int).Value = _trash;
            cmd.Parameters.Add("@vehicle", SqlDbType.Int).Value = _vehicle;
            cmd.Parameters.Add("@roomate", SqlDbType.VarChar, 250).Value = _roomate;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_Rent();
            RentID.Text = "";
            roomPrice.Text = "";
            list.Items.Clear();
            check_trash.Checked = false;
            check_vehicle.Checked = false;
            label_member.Text = "";
        }

        private void edcAndWaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edc_water edc = new edc_water(connectionString, _userID.ToString());
            edc.Show();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Customer customer = new Customer(connectionString, this._userID.ToString()))
            {
                if (customer.ShowDialog(this) == DialogResult.Cancel)
                {
                    showData_customer();
                }
            }
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Room room = new Room(connectionString))
            {
                if (room.ShowDialog(this) == DialogResult.Cancel)
                {
                    CB_roomID.Items.Clear();
                    list_ID_Room();
                }
            }
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice invoice = new invoice(connectionString, this._userID.ToString());
            invoice.Show();
        }

        private void CB_roomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            _getRoom_price();
        }
        private void _getRoom_price()
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select price from Room where ID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = this.CB_roomID.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;

            kd = cmd.ExecuteReader();
            while (kd.Read())
            {
                this.roomPrice.Text = kd["price"].ToString();
            }
            cnn.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            RentID.Text = "";
            CB_roomID.Items.Clear();
            CB_roomID.Text = "";
            list.Items.Clear();
            list.Text = "";
            roomPrice.Text = "";
            check_trash.Checked = false;
            check_vehicle.Checked = false;
            label_member.Text = "";
        }
    }
}
