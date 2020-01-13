namespace AttendanceMngmt
{
    partial class ViewAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttendance));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvAttendance = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddOption = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbVal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnShow = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnBack
            // 
            this.btnBack.ActiveBorderThickness = 1;
            this.btnBack.ActiveCornerRadius = 20;
            this.btnBack.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnBack.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Navy;
            this.btnBack.IdleBorderThickness = 1;
            this.btnBack.IdleCornerRadius = 20;
            this.btnBack.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.IdleForecolor = System.Drawing.Color.Navy;
            this.btnBack.IdleLineColor = System.Drawing.Color.Navy;
            this.btnBack.Location = new System.Drawing.Point(523, 446);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 46);
            this.btnBack.TabIndex = 17;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(196, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(266, 45);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "View Attendance";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.DoubleBuffered = true;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.HeaderBgColor = System.Drawing.Color.Navy;
            this.dgvAttendance.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAttendance.Location = new System.Drawing.Point(108, 179);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttendance.Size = new System.Drawing.Size(393, 258);
            this.dgvAttendance.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(613, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 19;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(61, 82);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(143, 21);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Sort attendance by:";
            // 
            // ddOption
            // 
            this.ddOption.BackColor = System.Drawing.Color.Transparent;
            this.ddOption.BorderRadius = 3;
            this.ddOption.DisabledColor = System.Drawing.Color.Gray;
            this.ddOption.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddOption.ForeColor = System.Drawing.Color.White;
            this.ddOption.Items = new string[] {
        "EmployeeID",
        "Department",
        "Designation",
        "Date"};
            this.ddOption.Location = new System.Drawing.Point(242, 75);
            this.ddOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddOption.Name = "ddOption";
            this.ddOption.NomalColor = System.Drawing.Color.Navy;
            this.ddOption.onHoverColor = System.Drawing.Color.Navy;
            this.ddOption.selectedIndex = -1;
            this.ddOption.Size = new System.Drawing.Size(259, 28);
            this.ddOption.TabIndex = 21;
            this.ddOption.onItemSelected += new System.EventHandler(this.ddDept_onItemSelected);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(61, 127);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(106, 21);
            this.bunifuCustomLabel3.TabIndex = 22;
            this.bunifuCustomLabel3.Text = "Provide value:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // tbVal
            // 
            this.tbVal.BorderColorFocused = System.Drawing.Color.Navy;
            this.tbVal.BorderColorIdle = System.Drawing.Color.Navy;
            this.tbVal.BorderColorMouseHover = System.Drawing.Color.Navy;
            this.tbVal.BorderThickness = 3;
            this.tbVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVal.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVal.isPassword = false;
            this.tbVal.Location = new System.Drawing.Point(242, 116);
            this.tbVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(259, 32);
            this.tbVal.TabIndex = 23;
            this.tbVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnShow
            // 
            this.btnShow.ActiveBorderThickness = 1;
            this.btnShow.ActiveCornerRadius = 20;
            this.btnShow.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnShow.ActiveForecolor = System.Drawing.Color.White;
            this.btnShow.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.ButtonText = "Show";
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Navy;
            this.btnShow.IdleBorderThickness = 1;
            this.btnShow.IdleCornerRadius = 20;
            this.btnShow.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShow.IdleForecolor = System.Drawing.Color.Navy;
            this.btnShow.IdleLineColor = System.Drawing.Color.Navy;
            this.btnShow.Location = new System.Drawing.Point(523, 400);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(118, 46);
            this.btnShow.TabIndex = 24;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 507);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.ddOption);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAttendance;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown ddOption;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbVal;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShow;
    }
}