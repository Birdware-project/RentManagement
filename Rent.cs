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
    public partial class Rent : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True";
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        DataTable dt;

        private int _userID;

        public Rent(string UserID)
        {
            
            InitializeComponent();
            showData_customer();
            showData_Room();
            LB_userID.Text = UserID;
            _userID = Int32.Parse(UserID);
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_addlist_Click(object sender, EventArgs e)
        {
            list.Items.Add(add_list.Text);
            add_list.Text = "";
            this.label_member.Text = list.Items.Count.ToString();
        }

        private void bt_removelist_Click(object sender, EventArgs e)
        {
            list.Items.Remove(list.SelectedItem);
            add_list.Text = "";
            this.label_member.Text = list.Items.Count.ToString();
        }

        private void bt_filtercus_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_Customer where Cus_Name like '%" + filter_cus.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            datagv_customer.DataSource = dt;
            datagv_customer.Sort(datagv_customer.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void showData_customer()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select cus_ID,Cus_name from Tb_Customer", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            datagv_customer.DataSource = dt;
            datagv_customer.Sort(datagv_customer.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            // note duplicate
            for (int item = 0; item < dataview_Room.Rows.Count - 1; item++)
            {
                if (id_room.Text == dataview_Room.Rows[item].Cells[0].Value.ToString())
                {
                    MessageBox.Show("ID Duplicate");
                    cnn.Close();
                    return;
                }

            }
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
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
            while ( x < list.Items.Count)
            {
                _roomate += list.Items[x] + ",";
                x++;
            }
            myhome.CommandText = "insert into Tb_menu" +
                "(Room_Name,Room_Money,Trash_service,Vehicle_Space,Roomate,User_ID)values(@param2,@param3,@param5,@param6,@param7,@UserID)";
            
            myhome.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = name_room.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = money_room.Text;
            myhome.Parameters.Add("@param5", SqlDbType.Int).Value = _trash;
            myhome.Parameters.Add("@param6", SqlDbType.Int).Value = _vehicle;
            myhome.Parameters.Add("@param7", SqlDbType.VarChar,250).Value = _roomate;
            myhome.Parameters.Add("@UserID", SqlDbType.Int).Value = _userID;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            id_room.Text = "";
            name_room.Text = "";
            money_room.Text = "";
            list.Items.Clear();
            check_trash.Checked = false;
            check_vehicle.Checked = false;
            label_member.Text = "";
            MessageBox.Show("Data insert Success");
            showData_Room();
        }
        private void showData_Room()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_menu", cnn);
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
            adapter2 = new SqlDataAdapter("select * from Tb_menu where Room_Name like '%" + filter_room.Text + "%'", cnn);
            dt = new DataTable();
            adapter2.Fill(dt);
            dataview_Room.DataSource = dt;
            dataview_Room.Sort(dataview_Room.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_menu where Room_ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.filter_room.Text;
            myhome.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            try
            {
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.id_room.Text = kd["Room_ID"].ToString();
                    this.name_room.Text = kd["Room_Name"].ToString();
                    this.money_room.Text = kd["Room_Money"].ToString();
                    this.check_trash.Checked = Convert.ToInt32(kd["Trash_Service"].ToString()) == 1?true:false;
                    this.check_vehicle.Checked = Convert.ToInt32(kd["Vehicle_Space"].ToString()) == 1 ? true : false;
                    this.LB_userID.Text = kd["User_ID"].ToString();

                    String str = kd["Roomate"].ToString();
                    char[] spearator = { ','};
                    // Using the Method
                    String[] strlist = str.Split(spearator,
                           StringSplitOptions.None);
                    foreach (String s in strlist)
                    {
                        this.list.Items.Add(s);
                    }
                    

                }
                showData_Room();
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
            myhome = new SqlCommand();
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
            myhome.CommandText = "update Tb_menu set Room_Name=@param2,Room_Money=@param3,Trash_Service=@param5,Vehicle_Space=@param6,Roomate=@param7 where Room_ID=@param1";
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = id_room.Text;
            myhome.Parameters.Add("@param2", SqlDbType.VarChar, 250).Value = name_room.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = money_room.Text;
            myhome.Parameters.Add("@param5", SqlDbType.Int).Value = _trash;
            myhome.Parameters.Add("@param6", SqlDbType.Int).Value = _vehicle;
            myhome.Parameters.Add("@param7", SqlDbType.VarChar,250).Value = _roomate;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            showData_Room();
            id_room.Text = "";
            name_room.Text = "";
            money_room.Text = "";
            list.Items.Clear();
            check_trash.Checked = false;
            check_vehicle.Checked = false;
            label_member.Text = "";
        }

        private void edcAndWaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edc_water edc = new edc_water();
            edc.Show();
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(this._userID.ToString());
            customer.Show();
            showData_customer();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice invoice = new invoice(this._userID.ToString());
            invoice.Show();
        }
    }
}
