namespace moneyhome
{
    partial class Customer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_cus = new System.Windows.Forms.TextBox();
            this.sex_cus = new System.Windows.Forms.TextBox();
            this.phone_cus = new System.Windows.Forms.TextBox();
            this.age_cus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataview_customer = new System.Windows.Forms.DataGridView();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.filter_cus = new System.Windows.Forms.TextBox();
            this.bt_filter = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_upload = new System.Windows.Forms.Button();
            this.LB_customer = new System.Windows.Forms.Label();
            this.Btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KhmerDLStation TNRB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cus_ID :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cus_Name :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sex :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cus_Phone :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(806, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 41);
            this.label7.TabIndex = 7;
            this.label7.Text = "Photo ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // name_cus
            // 
            this.name_cus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_cus.Location = new System.Drawing.Point(295, 158);
            this.name_cus.Multiline = true;
            this.name_cus.Name = "name_cus";
            this.name_cus.Size = new System.Drawing.Size(220, 34);
            this.name_cus.TabIndex = 9;
            // 
            // sex_cus
            // 
            this.sex_cus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sex_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_cus.Location = new System.Drawing.Point(643, 154);
            this.sex_cus.Multiline = true;
            this.sex_cus.Name = "sex_cus";
            this.sex_cus.Size = new System.Drawing.Size(81, 34);
            this.sex_cus.TabIndex = 10;
            // 
            // phone_cus
            // 
            this.phone_cus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_cus.Location = new System.Drawing.Point(295, 206);
            this.phone_cus.Multiline = true;
            this.phone_cus.Name = "phone_cus";
            this.phone_cus.Size = new System.Drawing.Size(225, 34);
            this.phone_cus.TabIndex = 11;
            // 
            // age_cus
            // 
            this.age_cus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.age_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_cus.Location = new System.Drawing.Point(643, 206);
            this.age_cus.Multiline = true;
            this.age_cus.Name = "age_cus";
            this.age_cus.Size = new System.Drawing.Size(81, 34);
            this.age_cus.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(765, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataview_customer
            // 
            this.dataview_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_customer.Location = new System.Drawing.Point(7, 383);
            this.dataview_customer.Name = "dataview_customer";
            this.dataview_customer.RowHeadersWidth = 51;
            this.dataview_customer.RowTemplate.Height = 24;
            this.dataview_customer.Size = new System.Drawing.Size(1062, 194);
            this.dataview_customer.TabIndex = 14;
            // 
            // bt_insert
            // 
            this.bt_insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_insert.BackColor = System.Drawing.Color.Blue;
            this.bt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_insert.Location = new System.Drawing.Point(495, 336);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(99, 42);
            this.bt_insert.TabIndex = 15;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = false;
            this.bt_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_search.BackColor = System.Drawing.Color.Yellow;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(305, 334);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(104, 42);
            this.bt_search.TabIndex = 16;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_update.Location = new System.Drawing.Point(600, 337);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(108, 42);
            this.bt_update.TabIndex = 17;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_delete.BackColor = System.Drawing.Color.Red;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_delete.Location = new System.Drawing.Point(714, 336);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(99, 42);
            this.bt_delete.TabIndex = 18;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // filter_cus
            // 
            this.filter_cus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filter_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_cus.Location = new System.Drawing.Point(7, 339);
            this.filter_cus.Multiline = true;
            this.filter_cus.Name = "filter_cus";
            this.filter_cus.Size = new System.Drawing.Size(182, 34);
            this.filter_cus.TabIndex = 19;
            // 
            // bt_filter
            // 
            this.bt_filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_filter.ForeColor = System.Drawing.Color.Red;
            this.bt_filter.Location = new System.Drawing.Point(195, 336);
            this.bt_filter.Name = "bt_filter";
            this.bt_filter.Size = new System.Drawing.Size(99, 39);
            this.bt_filter.TabIndex = 20;
            this.bt_filter.Text = "Filter";
            this.bt_filter.UseVisualStyleBackColor = false;
            this.bt_filter.Click += new System.EventHandler(this.bt_filter_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(970, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 40);
            this.button6.TabIndex = 21;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bt_upload
            // 
            this.bt_upload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_upload.Location = new System.Drawing.Point(803, 272);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(119, 42);
            this.bt_upload.TabIndex = 22;
            this.bt_upload.Text = "Upload";
            this.bt_upload.UseVisualStyleBackColor = false;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // LB_customer
            // 
            this.LB_customer.AutoSize = true;
            this.LB_customer.Font = new System.Drawing.Font("KhmerDLStation TNRB", 13.8F, System.Drawing.FontStyle.Bold);
            this.LB_customer.Location = new System.Drawing.Point(298, 104);
            this.LB_customer.Name = "LB_customer";
            this.LB_customer.Size = new System.Drawing.Size(70, 41);
            this.LB_customer.TabIndex = 23;
            this.LB_customer.Text = "____";
            // 
            // Btn_clear
            // 
            this.Btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_clear.BackColor = System.Drawing.Color.Black;
            this.Btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_clear.Location = new System.Drawing.Point(374, 104);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(99, 40);
            this.Btn_clear.TabIndex = 24;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1076, 582);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.LB_customer);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt_filter);
            this.Controls.Add(this.filter_cus);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.dataview_customer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.age_cus);
            this.Controls.Add(this.phone_cus);
            this.Controls.Add(this.sex_cus);
            this.Controls.Add(this.name_cus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_cus;
        private System.Windows.Forms.TextBox sex_cus;
        private System.Windows.Forms.TextBox phone_cus;
        private System.Windows.Forms.TextBox age_cus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataview_customer;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox filter_cus;
        private System.Windows.Forms.Button bt_filter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.Label LB_customer;
        private System.Windows.Forms.Button Btn_clear;
    }
}