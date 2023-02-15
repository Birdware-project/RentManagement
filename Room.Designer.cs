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
            this.price_room = new System.Windows.Forms.TextBox();
            this.name_room = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataview_room1 = new System.Windows.Forms.DataGridView();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_room = new System.Windows.Forms.Label();
            this.Bt_filter = new System.Windows.Forms.Button();
            this.filter_room = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_room1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Price  :";
            // 
            // price_room
            // 
            this.price_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.price_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_room.Location = new System.Drawing.Point(441, 143);
            this.price_room.Multiline = true;
            this.price_room.Name = "price_room";
            this.price_room.Size = new System.Drawing.Size(220, 34);
            this.price_room.TabIndex = 10;
            // 
            // name_room
            // 
            this.name_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_room.Location = new System.Drawing.Point(441, 88);
            this.name_room.Multiline = true;
            this.name_room.Name = "name_room";
            this.name_room.Size = new System.Drawing.Size(220, 34);
            this.name_room.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KhmerDLStation TNRB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 86);
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
            this.label5.Location = new System.Drawing.Point(285, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Room ID :";
            // 
            // dataview_room1
            // 
            this.dataview_room1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview_room1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_room1.Location = new System.Drawing.Point(12, 287);
            this.dataview_room1.Name = "dataview_room1";
            this.dataview_room1.RowHeadersWidth = 51;
            this.dataview_room1.RowTemplate.Height = 24;
            this.dataview_room1.Size = new System.Drawing.Size(1168, 378);
            this.dataview_room1.TabIndex = 19;
            // 
            // bt_Insert
            // 
            this.bt_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_Insert.BackColor = System.Drawing.Color.Blue;
            this.bt_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Insert.Location = new System.Drawing.Point(687, 37);
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
            this.bt_search.BackColor = System.Drawing.Color.Yellow;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(687, 89);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(147, 33);
            this.bt_search.TabIndex = 21;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(687, 146);
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
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1079, 233);
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
            this.id_room.Location = new System.Drawing.Point(444, 36);
            this.id_room.Name = "id_room";
            this.id_room.Size = new System.Drawing.Size(59, 36);
            this.id_room.TabIndex = 24;
            this.id_room.Text = "____";
            // 
            // Bt_filter
            // 
            this.Bt_filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bt_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bt_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_filter.ForeColor = System.Drawing.Color.Red;
            this.Bt_filter.Location = new System.Drawing.Point(912, 233);
            this.Bt_filter.Name = "Bt_filter";
            this.Bt_filter.Size = new System.Drawing.Size(147, 33);
            this.Bt_filter.TabIndex = 26;
            this.Bt_filter.Text = "FILTER";
            this.Bt_filter.UseVisualStyleBackColor = false;
            this.Bt_filter.Click += new System.EventHandler(this.button2_Click);
            // 
            // filter_room
            // 
            this.filter_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filter_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_room.Location = new System.Drawing.Point(666, 230);
            this.filter_room.Multiline = true;
            this.filter_room.Name = "filter_room";
            this.filter_room.Size = new System.Drawing.Size(220, 34);
            this.filter_room.TabIndex = 25;
            // 
            // Room1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1192, 677);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_filter);
            this.Controls.Add(this.filter_room);
            this.Controls.Add(this.id_room);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_Insert);
            this.Controls.Add(this.dataview_room1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_room);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_room);
            this.Controls.Add(this.label2);
            this.Name = "Room1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataview_room1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_room;
        private System.Windows.Forms.TextBox name_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataview_room1;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_room;
        private System.Windows.Forms.Button Bt_filter;
        private System.Windows.Forms.TextBox filter_room;
    }
}