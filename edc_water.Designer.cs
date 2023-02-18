namespace moneyhome
{
    partial class edc_water
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.TB_FilterSearch = new System.Windows.Forms.TextBox();
            this.bt_filteredc = new System.Windows.Forms.Button();
            this.dataview_water = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_roomID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_new_wat = new System.Windows.Forms.TextBox();
            this.TB_new_edc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_old_wat = new System.Windows.Forms.TextBox();
            this.TB_old_edc = new System.Windows.Forms.TextBox();
            this.LB_id = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_userID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_water)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KhmerDLStation TNRB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "EDC Water";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date :";
            // 
            // date_time
            // 
            this.date_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time.Location = new System.Drawing.Point(507, 44);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(143, 22);
            this.date_time.TabIndex = 8;
            // 
            // TB_FilterSearch
            // 
            this.TB_FilterSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_FilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FilterSearch.Location = new System.Drawing.Point(287, 344);
            this.TB_FilterSearch.Multiline = true;
            this.TB_FilterSearch.Name = "TB_FilterSearch";
            this.TB_FilterSearch.Size = new System.Drawing.Size(216, 35);
            this.TB_FilterSearch.TabIndex = 12;
            // 
            // bt_filteredc
            // 
            this.bt_filteredc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_filteredc.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_filteredc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_filteredc.ForeColor = System.Drawing.Color.White;
            this.bt_filteredc.Location = new System.Drawing.Point(290, 304);
            this.bt_filteredc.Name = "bt_filteredc";
            this.bt_filteredc.Size = new System.Drawing.Size(99, 36);
            this.bt_filteredc.TabIndex = 17;
            this.bt_filteredc.Text = "Filter";
            this.bt_filteredc.UseVisualStyleBackColor = false;
            this.bt_filteredc.Click += new System.EventHandler(this.bt_filteredc_Click);
            // 
            // dataview_water
            // 
            this.dataview_water.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview_water.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview_water.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_water.Location = new System.Drawing.Point(12, 385);
            this.dataview_water.Name = "dataview_water";
            this.dataview_water.RowHeadersWidth = 51;
            this.dataview_water.RowTemplate.Height = 24;
            this.dataview_water.Size = new System.Drawing.Size(758, 320);
            this.dataview_water.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(671, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_insert.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_insert.ForeColor = System.Drawing.Color.White;
            this.bt_insert.Location = new System.Drawing.Point(195, 182);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(106, 36);
            this.bt_insert.TabIndex = 20;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = false;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_search.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.White;
            this.bt_search.Location = new System.Drawing.Point(392, 304);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(111, 36);
            this.bt_search.TabIndex = 21;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_update.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(321, 182);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(115, 36);
            this.bt_update.TabIndex = 22;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Room ID :";
            // 
            // CB_roomID
            // 
            this.CB_roomID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CB_roomID.FormattingEnabled = true;
            this.CB_roomID.Location = new System.Drawing.Point(173, 43);
            this.CB_roomID.Name = "CB_roomID";
            this.CB_roomID.Size = new System.Drawing.Size(130, 24);
            this.CB_roomID.TabIndex = 24;
            this.CB_roomID.SelectedValueChanged += new System.EventHandler(this.CB_roomID_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(356, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "Water Old :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(372, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 36);
            this.label8.TabIndex = 25;
            this.label8.Text = "EDC Old :";
            // 
            // TB_new_wat
            // 
            this.TB_new_wat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_new_wat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_new_wat.Location = new System.Drawing.Point(173, 127);
            this.TB_new_wat.Multiline = true;
            this.TB_new_wat.Name = "TB_new_wat";
            this.TB_new_wat.Size = new System.Drawing.Size(130, 35);
            this.TB_new_wat.TabIndex = 32;
            this.TB_new_wat.Text = "0";
            // 
            // TB_new_edc
            // 
            this.TB_new_edc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_new_edc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_new_edc.Location = new System.Drawing.Point(173, 86);
            this.TB_new_edc.Multiline = true;
            this.TB_new_edc.Name = "TB_new_edc";
            this.TB_new_edc.Size = new System.Drawing.Size(130, 35);
            this.TB_new_edc.TabIndex = 31;
            this.TB_new_edc.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 36);
            this.label9.TabIndex = 30;
            this.label9.Text = "Water New :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 36);
            this.label10.TabIndex = 29;
            this.label10.Text = "EDC New :";
            // 
            // TB_old_wat
            // 
            this.TB_old_wat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_old_wat.Enabled = false;
            this.TB_old_wat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_old_wat.Location = new System.Drawing.Point(507, 127);
            this.TB_old_wat.Multiline = true;
            this.TB_old_wat.Name = "TB_old_wat";
            this.TB_old_wat.Size = new System.Drawing.Size(143, 35);
            this.TB_old_wat.TabIndex = 36;
            this.TB_old_wat.Text = "0";
            // 
            // TB_old_edc
            // 
            this.TB_old_edc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_old_edc.Enabled = false;
            this.TB_old_edc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_old_edc.Location = new System.Drawing.Point(507, 86);
            this.TB_old_edc.Multiline = true;
            this.TB_old_edc.Name = "TB_old_edc";
            this.TB_old_edc.Size = new System.Drawing.Size(143, 35);
            this.TB_old_edc.TabIndex = 35;
            this.TB_old_edc.Text = "0";
            // 
            // LB_id
            // 
            this.LB_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_id.AutoSize = true;
            this.LB_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LB_id.Location = new System.Drawing.Point(169, 6);
            this.LB_id.Name = "LB_id";
            this.LB_id.Size = new System.Drawing.Size(48, 25);
            this.LB_id.TabIndex = 38;
            this.LB_id.Text = "___";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(102, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 36);
            this.label11.TabIndex = 39;
            this.label11.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.TB_old_wat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.date_time);
            this.panel1.Controls.Add(this.LB_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CB_roomID);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bt_insert);
            this.panel1.Controls.Add(this.TB_old_edc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TB_new_wat);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TB_new_edc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 231);
            this.panel1.TabIndex = 41;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(453, 182);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 36);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 40;
            this.label2.Text = "management";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(618, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 36);
            this.label4.TabIndex = 40;
            this.label4.Text = "User ID:";
            // 
            // LB_userID
            // 
            this.LB_userID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_userID.AutoSize = true;
            this.LB_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LB_userID.Location = new System.Drawing.Point(722, 9);
            this.LB_userID.Name = "LB_userID";
            this.LB_userID.Size = new System.Drawing.Size(48, 25);
            this.LB_userID.TabIndex = 40;
            this.LB_userID.Text = "___";
            // 
            // edc_water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 717);
            this.ControlBox = false;
            this.Controls.Add(this.LB_userID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataview_water);
            this.Controls.Add(this.bt_filteredc);
            this.Controls.Add(this.TB_FilterSearch);
            this.Controls.Add(this.label1);
            this.Name = "edc_water";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataview_water)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.TextBox TB_FilterSearch;
        private System.Windows.Forms.Button bt_filteredc;
        private System.Windows.Forms.DataGridView dataview_water;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_roomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_new_wat;
        private System.Windows.Forms.TextBox TB_new_edc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_old_wat;
        private System.Windows.Forms.TextBox TB_old_edc;
        private System.Windows.Forms.Label LB_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_userID;
        private System.Windows.Forms.Button btn_clear;
    }
}