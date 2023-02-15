namespace moneyhome
{
    partial class User
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
            this.phone_user = new System.Windows.Forms.TextBox();
            this.name_user = new System.Windows.Forms.TextBox();
            this.password_user = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sex_user = new System.Windows.Forms.TextBox();
            this.text_filter = new System.Windows.Forms.TextBox();
            this.bt_filter = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.dataview_user = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.id_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KhmerDLStation TNRB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "User_ID :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "User_Name :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "User_Phone :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "User_Password :";
            // 
            // phone_user
            // 
            this.phone_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_user.Location = new System.Drawing.Point(512, 110);
            this.phone_user.Multiline = true;
            this.phone_user.Name = "phone_user";
            this.phone_user.Size = new System.Drawing.Size(154, 35);
            this.phone_user.TabIndex = 8;
            // 
            // name_user
            // 
            this.name_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_user.Location = new System.Drawing.Point(190, 173);
            this.name_user.Multiline = true;
            this.name_user.Name = "name_user";
            this.name_user.Size = new System.Drawing.Size(154, 35);
            this.name_user.TabIndex = 9;
            // 
            // password_user
            // 
            this.password_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_user.Location = new System.Drawing.Point(610, 173);
            this.password_user.Multiline = true;
            this.password_user.Name = "password_user";
            this.password_user.Size = new System.Drawing.Size(154, 35);
            this.password_user.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(804, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "User_Sex :";
            // 
            // sex_user
            // 
            this.sex_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sex_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_user.Location = new System.Drawing.Point(925, 173);
            this.sex_user.Multiline = true;
            this.sex_user.Name = "sex_user";
            this.sex_user.Size = new System.Drawing.Size(64, 35);
            this.sex_user.TabIndex = 12;
            // 
            // text_filter
            // 
            this.text_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filter.Location = new System.Drawing.Point(793, 108);
            this.text_filter.Multiline = true;
            this.text_filter.Name = "text_filter";
            this.text_filter.Size = new System.Drawing.Size(154, 35);
            this.text_filter.TabIndex = 13;
            // 
            // bt_filter
            // 
            this.bt_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_filter.ForeColor = System.Drawing.Color.Red;
            this.bt_filter.Location = new System.Drawing.Point(953, 103);
            this.bt_filter.Name = "bt_filter";
            this.bt_filter.Size = new System.Drawing.Size(99, 42);
            this.bt_filter.TabIndex = 16;
            this.bt_filter.Text = "Filter";
            this.bt_filter.UseVisualStyleBackColor = false;
            this.bt_filter.Click += new System.EventHandler(this.bt_filter_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_insert.BackColor = System.Drawing.Color.Blue;
            this.bt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_insert.Location = new System.Drawing.Point(326, 240);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(99, 42);
            this.bt_insert.TabIndex = 17;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = false;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_search.BackColor = System.Drawing.Color.Yellow;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(431, 240);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(109, 42);
            this.bt_search.TabIndex = 18;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(546, 240);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(110, 42);
            this.bt_update.TabIndex = 19;
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
            this.bt_delete.Location = new System.Drawing.Point(662, 240);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(102, 42);
            this.bt_delete.TabIndex = 20;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // dataview_user
            // 
            this.dataview_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_user.Location = new System.Drawing.Point(12, 288);
            this.dataview_user.Name = "dataview_user";
            this.dataview_user.RowHeadersWidth = 51;
            this.dataview_user.RowTemplate.Height = 24;
            this.dataview_user.Size = new System.Drawing.Size(1073, 355);
            this.dataview_user.TabIndex = 21;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(983, 240);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(102, 42);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.button6_Click);
            // 
            // id_user
            // 
            this.id_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_user.AutoSize = true;
            this.id_user.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_user.Location = new System.Drawing.Point(191, 110);
            this.id_user.Name = "id_user";
            this.id_user.Size = new System.Drawing.Size(59, 36);
            this.id_user.TabIndex = 23;
            this.id_user.Text = "____";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1097, 655);
            this.ControlBox = false;
            this.Controls.Add(this.id_user);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataview_user);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.bt_filter);
            this.Controls.Add(this.text_filter);
            this.Controls.Add(this.sex_user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password_user);
            this.Controls.Add(this.name_user);
            this.Controls.Add(this.phone_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataview_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_user;
        private System.Windows.Forms.TextBox name_user;
        private System.Windows.Forms.TextBox password_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sex_user;
        private System.Windows.Forms.TextBox text_filter;
        private System.Windows.Forms.Button bt_filter;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dataview_user;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label id_user;
    }
}