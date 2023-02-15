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
using System.Drawing.Imaging;

namespace moneyhome
{
    public partial class Customer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-FA6BV2O\SQLEXPRESS;Initial Catalog=program_c;Integrated Security=True";
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;

        private string _userID;
        public Customer(string Id)
        {
            _userID = Id;
            
            InitializeComponent();
            showData_customer();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int item = 0; item < dataview_customer.Rows.Count - 1; item++)
            //{
            //    if (id_cus.Text == dataview_customer.Rows[item].Cells[0].Value.ToString())
            //    {
            //        MessageBox.Show("ID Duplicate");
            //        cnn.Close();
            //        return;
            //    }

            //}
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            MemoryStream ms;
            myhome.CommandText = "INSERT INTO  Tb_Customer(Cus_Name,Cus_Sex,Cus_Age,Cus_Phone,Photo) VALUES (@param2,@param3,@param4,@param5,@picture1)";

            if (pictureBox1.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                myhome.Parameters.AddWithValue("@picture1", photo_aray);
            }
            myhome.Parameters.Add("@param2", SqlDbType.VarChar,250).Value = this.name_cus.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = this.sex_cus.Text;
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = this.age_cus.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar,250).Value = this.phone_cus.Text;
            myhome.Connection = cnn;
            cnn.Open();
            int aff = myhome.ExecuteNonQuery();
            MessageBox.Show(aff + " rows were affected.");
            cnn.Close();
            showData_customer();
            name_cus.Text = "";
            age_cus.Text = "";
            sex_cus.Text = "";
            phone_cus.Text = "";
            pictureBox1.Image = null;
           
        }
        private void showData_customer()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_Customer", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_customer.DataSource = dt;
            dataview_customer.Sort(dataview_customer.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
            MessageBox.Show(opnfd.FileName);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            myhome.CommandText = "select * from Tb_Customer where Cus_ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.filter_cus.Text;
            myhome.Connection = cnn;

            cnn.Open();
            SqlDataReader kd;

            
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.LB_customer.Text = kd["Cus_ID"].ToString();
                    this.name_cus.Text = kd["Cus_Name"].ToString();
                    this.sex_cus.Text = kd["Cus_Sex"].ToString();
                    this.age_cus.Text = kd["Cus_Age"].ToString();
                    this.phone_cus.Text = kd["Cus_Phone"].ToString();

                    byte[] photo_aray = (byte[])kd["Photo"];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                showData_customer();
           
                cnn.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            myhome = new SqlCommand();
            MemoryStream ms;
            myhome.CommandText = "update Tb_Customer set Cus_Name=@param2,Cus_Sex=@param3,Cus_Age=@param4,Cus_Phone=@param5,Photo=@picture1 where Cus_ID=@param1";
            if (pictureBox1.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                myhome.Parameters.AddWithValue("@picture1", photo_aray);
            }
            myhome.Parameters.Add("@param1", SqlDbType.Int).Value = this.LB_customer.Text;
            myhome.Parameters.Add("@param2", SqlDbType.VarChar,250).Value = this.name_cus.Text;
            myhome.Parameters.Add("@param3", SqlDbType.VarChar, 250).Value = this.sex_cus.Text;
            myhome.Parameters.Add("@param4", SqlDbType.VarChar, 250).Value = this.age_cus.Text;
            myhome.Parameters.Add("@param5", SqlDbType.VarChar,250).Value = this.phone_cus.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            LB_customer.Text = "";
            name_cus.Text = "";
            age_cus.Text = "";
            sex_cus.Text = "";
            phone_cus.Text = "";
            pictureBox1.Image = null;
            showData_customer();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete " + LB_customer.Text;
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                cnn = new SqlConnection(connectionString);
                myhome = new SqlCommand();
                myhome.CommandText = " delete  from Tb_Customer where Cus_ID =" + label1.Text + "";
                cnn.Open();
                myhome.Connection = cnn;
                myhome.ExecuteNonQuery();
                cnn.Close();
                showData_customer();
                MessageBox.Show("Data delete Success!");
            }
        }

        private void bt_filter_Click(object sender, EventArgs e)
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select * from Tb_Customer where Cus_Name like '%" + filter_cus.Text + "%'", cnn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataview_customer.DataSource = dt;
            dataview_customer.Sort(dataview_customer.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            LB_customer.Text = "";
            name_cus.Text = "";
            age_cus.Text = "";
            sex_cus.Text = "";
            phone_cus.Text = "";
            pictureBox1.Image = null;
            filter_cus.Text = "";
        }
    }
}
