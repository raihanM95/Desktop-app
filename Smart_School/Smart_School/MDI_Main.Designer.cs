namespace Smart_School
{
    partial class MDI_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSEstablish = new System.Windows.Forms.Label();
            this.lblSLocation = new System.Windows.Forms.Label();
            this.headTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistantTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(709, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.viewStudentsToolStripMenuItem});
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.studentToolStripMenuItem.Text = "Students";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewStudentToolStripMenuItem.Image")));
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add New Students";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentsToolStripMenuItem.Image")));
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headTeacherToolStripMenuItem,
            this.assistantTeacherToolStripMenuItem});
            this.teacherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherToolStripMenuItem.Image")));
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.teacherToolStripMenuItem.Text = "Teachers";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emailToolStripMenuItem.Image")));
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.schoolInfoToolStripMenuItem});
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // schoolInfoToolStripMenuItem
            // 
            this.schoolInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schoolInfoToolStripMenuItem.Image")));
            this.schoolInfoToolStripMenuItem.Name = "schoolInfoToolStripMenuItem";
            this.schoolInfoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.schoolInfoToolStripMenuItem.Text = "School Info";
            this.schoolInfoToolStripMenuItem.Click += new System.EventHandler(this.schoolInfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(709, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.Location = new System.Drawing.Point(3, 397);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(120, 31);
            this.clock.TabIndex = 7;
            this.clock.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.BackColor = System.Drawing.Color.Transparent;
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.Location = new System.Drawing.Point(12, 35);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(68, 25);
            this.lblSName.TabIndex = 9;
            this.lblSName.Text = "Name";
            this.lblSName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSEstablish
            // 
            this.lblSEstablish.AutoSize = true;
            this.lblSEstablish.BackColor = System.Drawing.Color.Transparent;
            this.lblSEstablish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEstablish.Location = new System.Drawing.Point(14, 69);
            this.lblSEstablish.Name = "lblSEstablish";
            this.lblSEstablish.Size = new System.Drawing.Size(63, 16);
            this.lblSEstablish.TabIndex = 10;
            this.lblSEstablish.Text = "Establish";
            this.lblSEstablish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSLocation
            // 
            this.lblSLocation.AutoSize = true;
            this.lblSLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblSLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLocation.Location = new System.Drawing.Point(14, 85);
            this.lblSLocation.Name = "lblSLocation";
            this.lblSLocation.Size = new System.Drawing.Size(59, 16);
            this.lblSLocation.TabIndex = 11;
            this.lblSLocation.Text = "Location";
            this.lblSLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // headTeacherToolStripMenuItem
            // 
            this.headTeacherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("headTeacherToolStripMenuItem.Image")));
            this.headTeacherToolStripMenuItem.Name = "headTeacherToolStripMenuItem";
            this.headTeacherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.headTeacherToolStripMenuItem.Text = "Join Teacher";
            this.headTeacherToolStripMenuItem.Click += new System.EventHandler(this.headTeacherToolStripMenuItem_Click);
            // 
            // assistantTeacherToolStripMenuItem
            // 
            this.assistantTeacherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("assistantTeacherToolStripMenuItem.Image")));
            this.assistantTeacherToolStripMenuItem.Name = "assistantTeacherToolStripMenuItem";
            this.assistantTeacherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assistantTeacherToolStripMenuItem.Text = "View Teachers";
            this.assistantTeacherToolStripMenuItem.Click += new System.EventHandler(this.assistantTeacherToolStripMenuItem_Click);
            // 
            // MDI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 453);
            this.Controls.Add(this.lblSLocation);
            this.Controls.Add(this.lblSEstablish);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDI_Main";
            this.Text = "Main Manu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem schoolInfoToolStripMenuItem;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSEstablish;
        private System.Windows.Forms.Label lblSLocation;
        private System.Windows.Forms.ToolStripMenuItem headTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistantTeacherToolStripMenuItem;
    }
}



