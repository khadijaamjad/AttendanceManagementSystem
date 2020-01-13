namespace AttendanceMngmt
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSigIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(101, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(300, 45);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Attendance Marker";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(77, 186);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Username:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(77, 285);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(83, 21);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.BorderColorFocused = System.Drawing.Color.Navy;
            this.tbUsername.BorderColorIdle = System.Drawing.Color.Navy;
            this.tbUsername.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.tbUsername.BorderThickness = 3;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.isPassword = false;
            this.tbUsername.Location = new System.Drawing.Point(171, 173);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(259, 44);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderColorFocused = System.Drawing.Color.Navy;
            this.tbPassword.BorderColorIdle = System.Drawing.Color.Navy;
            this.tbPassword.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.tbPassword.BorderThickness = 3;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.isPassword = true;
            this.tbPassword.Location = new System.Drawing.Point(171, 262);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(259, 44);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSigIn
            // 
            this.btnSigIn.ActiveBorderThickness = 1;
            this.btnSigIn.ActiveCornerRadius = 20;
            this.btnSigIn.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnSigIn.ActiveForecolor = System.Drawing.Color.White;
            this.btnSigIn.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnSigIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnSigIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSigIn.BackgroundImage")));
            this.btnSigIn.ButtonText = "Sign in";
            this.btnSigIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigIn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigIn.ForeColor = System.Drawing.Color.Navy;
            this.btnSigIn.IdleBorderThickness = 1;
            this.btnSigIn.IdleCornerRadius = 20;
            this.btnSigIn.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSigIn.IdleForecolor = System.Drawing.Color.Navy;
            this.btnSigIn.IdleLineColor = System.Drawing.Color.Navy;
            this.btnSigIn.Location = new System.Drawing.Point(148, 386);
            this.btnSigIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSigIn.Name = "btnSigIn";
            this.btnSigIn.Size = new System.Drawing.Size(199, 49);
            this.btnSigIn.TabIndex = 5;
            this.btnSigIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSigIn.Click += new System.EventHandler(this.btnSigIn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 474);
            this.Controls.Add(this.btnSigIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSigIn;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

