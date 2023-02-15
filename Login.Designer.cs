namespace moneyhome
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_username = new System.Windows.Forms.TextBox();
            this.LB_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KhmerDLStation TNRB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(394, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KhmerDLStation TNRB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(119, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KhmerDLStation TNRB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(138, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 77);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // LB_username
            // 
            this.LB_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_username.Location = new System.Drawing.Point(396, 201);
            this.LB_username.Multiline = true;
            this.LB_username.Name = "LB_username";
            this.LB_username.Size = new System.Drawing.Size(443, 69);
            this.LB_username.TabIndex = 3;
            // 
            // LB_password
            // 
            this.LB_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_password.Location = new System.Drawing.Point(396, 347);
            this.LB_password.Multiline = true;
            this.LB_password.Name = "LB_password";
            this.LB_password.PasswordChar = '*';
            this.LB_password.Size = new System.Drawing.Size(443, 69);
            this.LB_password.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_login.BackColor = System.Drawing.Color.Blue;
            this.btn_login.Font = new System.Drawing.Font("KhmerDLStation TNRB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(291, 460);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(192, 73);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_createAccount.BackColor = System.Drawing.Color.Blue;
            this.btn_createAccount.Font = new System.Drawing.Font("KhmerDLStation TNRB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_createAccount.Location = new System.Drawing.Point(489, 460);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(370, 73);
            this.btn_createAccount.TabIndex = 6;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            this.btn_createAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(969, 639);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.LB_password);
            this.Controls.Add(this.LB_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LB_username;
        private System.Windows.Forms.TextBox LB_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Timer timer1;
    }
}

