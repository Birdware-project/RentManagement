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
        string connectionString;
        SqlCommand myhome;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable dt;

        private string _userID;
        public Customer(string connection,string Id)
        {
            _userID = Id;
            connectionString= connection;
            InitializeComponent();
            Lb_userID.Text = Id;
            showData_customer();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            myhome = new SqlCommand();
            MemoryStream ms;
            myhome.CommandText = "INSERT INTO " +
                "Customer(Name,Sex,Age,Phone,image) " +
                "VALUES(@name,@sex,@age,@phone,@picture)";

            if (pictureBox1.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                myhome.Parameters.AddWithValue("@picture", photo_aray);
            }
            myhome.Parameters.Add("@name", SqlDbType.VarChar,250).Value = this.name_cus.Text;
            myhome.Parameters.Add("@sex", SqlDbType.VarChar, 250).Value = this.CB_sex.Text;
            myhome.Parameters.Add("@age", SqlDbType.VarChar, 250).Value = this.age_cus.Text;
            myhome.Parameters.Add("@phone", SqlDbType.VarChar,250).Value = this.phone_cus.Text;
            myhome.Connection = cnn;
            cnn.Open();
            int aff = myhome.ExecuteNonQuery();
            MessageBox.Show(aff + " rows were affected.");
            cnn.Close();
            showData_customer();
            name_cus.Text = "";
            age_cus.Text = "";
            CB_sex.Text = "";
            phone_cus.Text = "";
            pictureBox1.Image = null;
           
        }
        private void showData_customer()
        {
            cnn = cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select Id,name,age,sex,phone from Customer", cnn);
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
            myhome.CommandText = "select * from Customer where ID=@ID";
            myhome.Parameters.Add("@ID", SqlDbType.Int).Value = this.TB_filterSearch.Text;
            myhome.Connection = cnn;

            cnn.Open();
            SqlDataReader kd;

            
                kd = myhome.ExecuteReader();
                while (kd.Read())
                {
                    this.LB_customer.Text = kd["ID"].ToString();
                    this.name_cus.Text = kd["Name"].ToString();
                    this.CB_sex.Text = kd["Sex"].ToString();
                    this.age_cus.Text = kd["Age"].ToString();
                    this.phone_cus.Text = kd["Phone"].ToString();

                    byte[] photo_aray = (byte[])kd["image"];
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
            myhome.CommandText = "update Customer set " +
                "Name=@name,Sex=@sex,Age=@age,Phone=@phone,image=@picture1 where ID=@id";
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
            myhome.Parameters.Add("@id", SqlDbType.Int).Value = this.LB_customer.Text;
            myhome.Parameters.Add("@name", SqlDbType.VarChar,250).Value = this.name_cus.Text;
            myhome.Parameters.Add("@sex", SqlDbType.VarChar, 250).Value = this.CB_sex.Text;
            myhome.Parameters.Add("@age", SqlDbType.VarChar, 250).Value = this.age_cus.Text;
            myhome.Parameters.Add("@phone", SqlDbType.VarChar,250).Value = this.phone_cus.Text;
            cnn.Open();
            myhome.Connection = cnn;
            myhome.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Date Update Success!");
            LB_customer.Text = "";
            name_cus.Text = "";
            age_cus.Text = "";
            CB_sex.Text = "";
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
                myhome.CommandText = " delete  from Customer where ID =" + label1.Text + "";
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
            adapter = new SqlDataAdapter("select * from Customer where Name like '%" + TB_filterSearch.Text + "%'", cnn);
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
            CB_sex.Text = "";
            phone_cus.Text = "";
            pictureBox1.Image = null;
            TB_filterSearch.Text = "";
        }
    }
}
