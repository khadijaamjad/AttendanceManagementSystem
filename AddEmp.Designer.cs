namespace AttendanceMngmt
{
    partial class AddEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbLname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbFname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddDept = new Bunifu.Framework.UI.BunifuDropdown();
            this.ddDesignation = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Navy;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(274, 384);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 49);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbLname
            // 
            this.tbLname.BorderColorFocused = System.Drawing.Color.Navy;
            this.tbLname.BorderColorIdle = System.Drawing.Color.Navy;
            this.tbLname.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.tbLname.BorderThickness = 3;
            this.tbLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLname.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLname.isPassword = false;
            this.tbLname.Location = new System.Drawing.Point(164, 175);
            this.tbLname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(259, 32);
            this.tbLname.TabIndex = 10;
            this.tbLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbFname
            // 
            this.tbFname.BorderColorFocused = System.Drawing.Color.Navy;
            this.tbFname.BorderColorIdle = System.Drawing.Color.Navy;
            this.tbFname.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.tbFname.BorderThickness = 3;
            this.tbFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFname.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFname.isPassword = false;
            this.tbFname.Location = new System.Drawing.Point(164, 114);
            this.tbFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(259, 32);
            this.tbFname.TabIndex = 9;
            this.tbFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(56, 188);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 21);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Last name:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(52, 125);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(89, 21);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "First name:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(119, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(229, 45);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Add Employee";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(56, 313);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(101, 21);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Designation:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(52, 250);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 21);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Department:";
            // 
            // ddDept
            // 
            this.ddDept.BackColor = System.Drawing.Color.Transparent;
            this.ddDept.BorderRadius = 3;
            this.ddDept.DisabledColor = System.Drawing.Color.Gray;
            this.ddDept.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddDept.ForeColor = System.Drawing.Color.White;
            this.ddDept.Items = new string[] {
        "SE",
        "EE",
        "CE",
        "CS",
        "IT",
        "IPP",
        "BBA",
        "NCMPR"};
            this.ddDept.Location = new System.Drawing.Point(164, 243);
            this.ddDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddDept.Name = "ddDept";
            this.ddDept.NomalColor = System.Drawing.Color.Navy;
            this.ddDept.onHoverColor = System.Drawing.Color.Navy;
            this.ddDept.selectedIndex = -1;
            this.ddDept.Size = new System.Drawing.Size(259, 28);
            this.ddDept.TabIndex = 14;
            // 
            // ddDesignation
            // 
            this.ddDesignation.BackColor = System.Drawing.Color.Transparent;
            this.ddDesignation.BorderRadius = 3;
            this.ddDesignation.DisabledColor = System.Drawing.Color.Gray;
            this.ddDesignation.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddDesignation.ForeColor = System.Drawing.Color.White;
            this.ddDesignation.Items = new string[] {
        "HOD",
        "CLUSTER HEAD",
        "TEACHER",
        "LAB ENGINEER",
        "TRG"};
            this.ddDesignation.Location = new System.Drawing.Point(164, 311);
            this.ddDesignation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddDesignation.Name = "ddDesignation";
            this.ddDesignation.NomalColor = System.Drawing.Color.Navy;
            this.ddDesignation.onHoverColor = System.Drawing.Color.Navy;
            this.ddDesignation.selectedIndex = -1;
            this.ddDesignation.Size = new System.Drawing.Size(259, 31);
            this.ddDesignation.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(423, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 463);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ddDesignation);
            this.Controls.Add(this.ddDept);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmp";
            this.Text = "AddEmp";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbLname;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbFname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDropdown ddDesignation;
        private Bunifu.Framework.UI.BunifuDropdown ddDept;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}