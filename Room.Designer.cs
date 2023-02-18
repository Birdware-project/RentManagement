namespace moneyhome
{
    partial class Room
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
            this.LB_roomPrice = new System.Windows.Forms.TextBox();
            this.LB_RoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataview_room1 = new System.Windows.Forms.DataGridView();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_room = new System.Windows.Forms.Label();
            this.Bt_filter = new System.Windows.Forms.Button();
            this.TB_FilterSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_room1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Price  :";
            // 
            // LB_roomPrice
            // 
            this.LB_roomPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_roomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_roomPrice.Location = new System.Drawing.Point(174, 114);
            this.LB_roomPrice.Multiline = true;
            this.LB_roomPrice.Name = "LB_roomPrice";
            this.LB_roomPrice.Size = new System.Drawing.Size(220, 34);
            this.LB_roomPrice.TabIndex = 10;
            // 
            // LB_RoomName
            // 
            this.LB_RoomName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_RoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RoomName.Location = new System.Drawing.Point(174, 59);
            this.LB_RoomName.Multiline = true;
            this.LB_RoomName.Name = "LB_RoomName";
            this.LB_RoomName.Size = new System.Drawing.Size(220, 34);
            this.LB_RoomName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Room Name :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Room ID :";
            // 
            // dataview_room1
            // 
            this.dataview_room1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview_room1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_room1.Location = new System.Drawing.Point(11, 393);
            this.dataview_room1.Name = "dataview_room1";
            this.dataview_room1.RowHeadersWidth = 51;
            this.dataview_room1.RowTemplate.Height = 24;
            this.dataview_room1.Size = new System.Drawing.Size(758, 177);
            this.dataview_room1.TabIndex = 19;
            // 
            // bt_Insert
            // 
            this.bt_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_Insert.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Insert.ForeColor = System.Drawing.Color.White;
            this.bt_Insert.Location = new System.Drawing.Point(166, 182);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(147, 35);
            this.bt_Insert.TabIndex = 20;
            this.bt_Insert.Text = "INSERT";
            this.bt_Insert.UseVisualStyleBackColor = false;
            this.bt_Insert.Click += new System.EventHandler(this.bt_Insert_Click);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_search.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.White;
            this.bt_search.Location = new System.Drawing.Point(408, 308);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(121, 33);
            this.bt_search.TabIndex = 21;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_update.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(325, 183);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(147, 33);
            this.bt_update.TabIndex = 22;
            this.bt_update.Text = "UPDATE";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(659, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_room
            // 
            this.id_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_room.AutoSize = true;
            this.id_room.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_room.Location = new System.Drawing.Point(177, 7);
            this.id_room.Name = "id_room";
            this.id_room.Size = new System.Drawing.Size(59, 36);
            this.id_room.TabIndex = 24;
            this.id_room.Text = "____";
            // 
            // Bt_filter
            // 
            this.Bt_filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bt_filter.BackColor = System.Drawing.Color.SteelBlue;
            this.Bt_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_filter.ForeColor = System.Drawing.Color.White;
            this.Bt_filter.Location = new System.Drawing.Point(277, 308);
            this.Bt_filter.Name = "Bt_filter";
            this.Bt_filter.Size = new System.Drawing.Size(125, 33);
            this.Bt_filter.TabIndex = 26;
            this.Bt_filter.Text = "FILTER";
            this.Bt_filter.UseVisualStyleBackColor = false;
            this.Bt_filter.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_FilterSearch
            // 
            this.TB_FilterSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_FilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FilterSearch.Location = new System.Drawing.Point(277, 347);
            this.TB_FilterSearch.Multiline = true;
            this.TB_FilterSearch.Name = "TB_FilterSearch";
            this.TB_FilterSearch.Size = new System.Drawing.Size(252, 34);
            this.TB_FilterSearch.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.LB_RoomName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LB_roomPrice);
            this.panel1.Controls.Add(this.id_room);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Insert);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 234);
            this.panel1.TabIndex = 27;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(488, 183);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 33);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KhmerDLStation TNRB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 55);
            this.label3.TabIndex = 28;
            this.label3.Text = "Room";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "management";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 582);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bt_filter);
            this.Controls.Add(this.TB_FilterSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.dataview_room1);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataview_room1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LB_roomPrice;
        private System.Windows.Forms.TextBox LB_RoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataview_room1;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_room;
        private System.Windows.Forms.Button Bt_filter;
        private System.Windows.Forms.TextBox TB_FilterSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
    }
}