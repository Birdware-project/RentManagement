namespace moneyhome
{
    partial class invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicle_price = new System.Windows.Forms.TextBox();
            this.trash_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.water_price = new System.Windows.Forms.TextBox();
            this.edc_price = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_roomid = new System.Windows.Forms.ComboBox();
            this.money_room = new System.Windows.Forms.Label();
            this.cb_edc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.total_num_edc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.total_num_water = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.vehicle_space = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trash_service = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LB_invoiceID = new System.Windows.Forms.Label();
            this.Lb_userID = new System.Windows.Forms.Label();
            this.TB_filter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice_ID :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rent_ID :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 36);
            this.label9.TabIndex = 12;
            this.label9.Text = "User_ID :";
            // 
            // date_time
            // 
            this.date_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time.Location = new System.Drawing.Point(772, 78);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(121, 22);
            this.date_time.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 209);
            this.dataGridView1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(983, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_search.BackColor = System.Drawing.Color.Yellow;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(345, 323);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(107, 37);
            this.bt_search.TabIndex = 26;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trash_Price :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vehicle_Price :";
            // 
            // vehicle_price
            // 
            this.vehicle_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vehicle_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_price.Location = new System.Drawing.Point(772, 158);
            this.vehicle_price.Multiline = true;
            this.vehicle_price.Name = "vehicle_price";
            this.vehicle_price.Size = new System.Drawing.Size(100, 32);
            this.vehicle_price.TabIndex = 14;
            // 
            // trash_price
            // 
            this.trash_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trash_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trash_price.Location = new System.Drawing.Point(772, 124);
            this.trash_price.Multiline = true;
            this.trash_price.Name = "trash_price";
            this.trash_price.Size = new System.Drawing.Size(100, 32);
            this.trash_price.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Water_Price :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "EDC_Price :";
            // 
            // water_price
            // 
            this.water_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.water_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_price.Location = new System.Drawing.Point(483, 158);
            this.water_price.Multiline = true;
            this.water_price.Name = "water_price";
            this.water_price.Size = new System.Drawing.Size(100, 32);
            this.water_price.TabIndex = 19;
            // 
            // edc_price
            // 
            this.edc_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edc_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edc_price.Location = new System.Drawing.Point(483, 123);
            this.edc_price.Multiline = true;
            this.edc_price.Name = "edc_price";
            this.edc_price.Size = new System.Drawing.Size(100, 32);
            this.edc_price.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(611, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 37);
            this.button3.TabIndex = 25;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_update.Location = new System.Drawing.Point(716, 328);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(105, 37);
            this.bt_update.TabIndex = 27;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 36);
            this.label10.TabIndex = 31;
            this.label10.Text = "Room_Money :";
            // 
            // CB_roomid
            // 
            this.CB_roomid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CB_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_roomid.FormattingEnabled = true;
            this.CB_roomid.Location = new System.Drawing.Point(178, 76);
            this.CB_roomid.Name = "CB_roomid";
            this.CB_roomid.Size = new System.Drawing.Size(97, 24);
            this.CB_roomid.TabIndex = 33;
            this.CB_roomid.SelectedValueChanged += new System.EventHandler(this.CB_roomid_SelectedValueChanged);
            // 
            // money_room
            // 
            this.money_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.money_room.AutoSize = true;
            this.money_room.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_room.ForeColor = System.Drawing.Color.Red;
            this.money_room.Location = new System.Drawing.Point(187, 123);
            this.money_room.Name = "money_room";
            this.money_room.Size = new System.Drawing.Size(26, 36);
            this.money_room.TabIndex = 34;
            this.money_room.Text = "0";
            // 
            // cb_edc
            // 
            this.cb_edc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_edc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_edc.FormattingEnabled = true;
            this.cb_edc.Location = new System.Drawing.Point(483, 76);
            this.cb_edc.Name = "cb_edc";
            this.cb_edc.Size = new System.Drawing.Size(97, 24);
            this.cb_edc.TabIndex = 36;
            this.cb_edc.SelectedIndexChanged += new System.EventHandler(this.cb_edc_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(301, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 36);
            this.label11.TabIndex = 35;
            this.label11.Text = "EDC_Water ID :";
            // 
            // total_num_edc
            // 
            this.total_num_edc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.total_num_edc.AutoSize = true;
            this.total_num_edc.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_num_edc.ForeColor = System.Drawing.Color.Red;
            this.total_num_edc.Location = new System.Drawing.Point(502, 214);
            this.total_num_edc.Name = "total_num_edc";
            this.total_num_edc.Size = new System.Drawing.Size(26, 36);
            this.total_num_edc.TabIndex = 38;
            this.total_num_edc.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 36);
            this.label13.TabIndex = 37;
            this.label13.Text = "Total EDC Number :";
            // 
            // total_num_water
            // 
            this.total_num_water.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.total_num_water.AutoSize = true;
            this.total_num_water.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_num_water.ForeColor = System.Drawing.Color.Red;
            this.total_num_water.Location = new System.Drawing.Point(502, 250);
            this.total_num_water.Name = "total_num_water";
            this.total_num_water.Size = new System.Drawing.Size(26, 36);
            this.total_num_water.TabIndex = 40;
            this.total_num_water.Text = "0";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(249, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 36);
            this.label15.TabIndex = 39;
            this.label15.Text = "Total Water Number :";
            // 
            // vehicle_space
            // 
            this.vehicle_space.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vehicle_space.AutoSize = true;
            this.vehicle_space.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_space.ForeColor = System.Drawing.Color.Red;
            this.vehicle_space.Location = new System.Drawing.Point(787, 250);
            this.vehicle_space.Name = "vehicle_space";
            this.vehicle_space.Size = new System.Drawing.Size(26, 36);
            this.vehicle_space.TabIndex = 46;
            this.vehicle_space.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(599, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 36);
            this.label16.TabIndex = 45;
            this.label16.Text = "Vehicle Space :";
            // 
            // trash_service
            // 
            this.trash_service.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trash_service.AutoSize = true;
            this.trash_service.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trash_service.ForeColor = System.Drawing.Color.Red;
            this.trash_service.Location = new System.Drawing.Point(787, 214);
            this.trash_service.Name = "trash_service";
            this.trash_service.Size = new System.Drawing.Size(26, 36);
            this.trash_service.TabIndex = 48;
            this.trash_service.Text = "0";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(599, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 36);
            this.label19.TabIndex = 47;
            this.label19.Text = "Trash Service :";
            // 
            // LB_invoiceID
            // 
            this.LB_invoiceID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_invoiceID.AutoSize = true;
            this.LB_invoiceID.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_invoiceID.Location = new System.Drawing.Point(483, 34);
            this.LB_invoiceID.Name = "LB_invoiceID";
            this.LB_invoiceID.Size = new System.Drawing.Size(59, 36);
            this.LB_invoiceID.TabIndex = 54;
            this.LB_invoiceID.Text = "____";
            // 
            // Lb_userID
            // 
            this.Lb_userID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_userID.AutoSize = true;
            this.Lb_userID.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_userID.Location = new System.Drawing.Point(175, 34);
            this.Lb_userID.Name = "Lb_userID";
            this.Lb_userID.Size = new System.Drawing.Size(48, 36);
            this.Lb_userID.TabIndex = 55;
            this.Lb_userID.Text = "___";
            // 
            // TB_filter
            // 
            this.TB_filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_filter.Location = new System.Drawing.Point(8, 328);
            this.TB_filter.Multiline = true;
            this.TB_filter.Name = "TB_filter";
            this.TB_filter.Size = new System.Drawing.Size(215, 32);
            this.TB_filter.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 57;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_print.BackColor = System.Drawing.Color.Lime;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(983, 9);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(99, 37);
            this.btn_print.TabIndex = 58;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1094, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_filter);
            this.Controls.Add(this.Lb_userID);
            this.Controls.Add(this.LB_invoiceID);
            this.Controls.Add(this.trash_service);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.vehicle_space);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.total_num_water);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.total_num_edc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_edc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.money_room);
            this.Controls.Add(this.CB_roomid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edc_price);
            this.Controls.Add(this.water_price);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.trash_price);
            this.Controls.Add(this.vehicle_price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vehicle_price;
        private System.Windows.Forms.TextBox trash_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox water_price;
        private System.Windows.Forms.TextBox edc_price;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_roomid;
        private System.Windows.Forms.Label money_room;
        private System.Windows.Forms.ComboBox cb_edc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label total_num_edc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label total_num_water;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label vehicle_space;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label trash_service;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LB_invoiceID;
        private System.Windows.Forms.Label Lb_userID;
        private System.Windows.Forms.TextBox TB_filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_print;
    }
}