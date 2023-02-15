using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string ConnectionSource = LB_connectionSource.Text;
            string DatabaseName = LB_databaseName.Text;
            SqlConnection cnn = new 
                SqlConnection(@"Data Source="+ConnectionSource+
                ";Integrated Security=True");
            //";Initial Catalog="+DatabaseName+
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "create database "+ DatabaseName;
            cmd.Connection = cnn;
            cnn.Open();
            try
            {
                string finalConnection = @"Data Source=" + ConnectionSource +
                ";Initial Catalog=" + DatabaseName +";Integrated Security=True";
                cmd.ExecuteNonQuery();
                haveDatabaseFile(finalConnection);
                SetupDatabase(finalConnection);
                Cursor = Cursors.Arrow;
                MessageBox.Show("Success Create Database", "Database");
            }
            catch(Exception ex)
            {
                MessageBox.Show("fail", "Error");
            }
            finally { cnn.Close(); }
        }

        private void haveDatabaseFile(string connectionSource)
        {
            string startupPath = Environment.CurrentDirectory;
            string fileName = startupPath + @"\dbconfig.txt";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(connectionSource);
                    fs.Write(title, 0, title.Length);
                }
                // Open the stream and read it back.    
                //using (StreamReader sr = File.OpenText(fileName))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
        private void SetupDatabase(string connectionString)
        {
            SqlConnection cnn = new
                SqlConnection(connectionString);
            //";Initial Catalog="+DatabaseName+
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = _scriptDB();
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close() ;
        }
        private string _scriptDB()
        {
            return "CREATE TABLE Users (ID int identity(1,1),Name varchar(255),Sex varchar(255),Phone varchar(255),Password varchar(255));create table Room(ID int identity(1,1),Price varchar(255),Name varchar(255));create table Rent(ID int identity(1,1),RoomID int ,UserID int,Trash_price varchar(255),Space_price varchar(255),Roomate varchar(255));create table invoice (ID int identity(1,1),RoomID int ,UserID int ,edc_waterID int,edc_price varchar(255),water_price varchar(255),space_price varchar(255),trash_price varchar(255),Date date,Room_price varchar(255),Total varchar(255));create table edc_water(ID int identity(1,1),RoomId int ,UserID int ,Date date ,edc_new varchar(255),edc_old varchar(255),water_new varchar(255),water_old varchar(255),);create table customer(ID int identity(1,1),Name varchar(255),Sex varchar(10),Age varchar(255),Phone varchar(255),Image image);";
        }
    }
}
