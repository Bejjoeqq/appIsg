namespace AplikasiIsg
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedullerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnSetting = new MetroFramework.Controls.MetroPanel();
            this.pnHome = new MetroFramework.Controls.MetroPanel();
            this.pnScheduller = new MetroFramework.Controls.MetroPanel();
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtNext = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtJam = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Basic = new System.Windows.Forms.GroupBox();
            this.btnDirError = new MetroFramework.Controls.MetroButton();
            this.btnDirOutbox = new MetroFramework.Controls.MetroButton();
            this.btnDirInbox = new MetroFramework.Controls.MetroButton();
            this.txtDirError = new MetroFramework.Controls.MetroTextBox();
            this.txtDirOutbox = new MetroFramework.Controls.MetroTextBox();
            this.txtDirInbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.pnSetting.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnScheduller.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.schedullerToolStripMenuItem1,
            this.settingToolStripMenuItem1,
            this.logToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // schedullerToolStripMenuItem1
            // 
            this.schedullerToolStripMenuItem1.Name = "schedullerToolStripMenuItem1";
            this.schedullerToolStripMenuItem1.Size = new System.Drawing.Size(101, 23);
            this.schedullerToolStripMenuItem1.Text = "Scheduller";
            this.schedullerToolStripMenuItem1.Click += new System.EventHandler(this.schedullerToolStripMenuItem1_Click);
            // 
            // settingToolStripMenuItem1
            // 
            this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
            this.settingToolStripMenuItem1.Size = new System.Drawing.Size(74, 23);
            this.settingToolStripMenuItem1.Text = "Setting";
            this.settingToolStripMenuItem1.Click += new System.EventHandler(this.settingToolStripMenuItem1_Click);
            // 
            // logToolStripMenuItem1
            // 
            this.logToolStripMenuItem1.Name = "logToolStripMenuItem1";
            this.logToolStripMenuItem1.Size = new System.Drawing.Size(50, 23);
            this.logToolStripMenuItem1.Text = "Log";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(65, 23);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // pnSetting
            // 
            this.pnSetting.Controls.Add(this.pnHome);
            this.pnSetting.Controls.Add(this.Basic);
            this.pnSetting.HorizontalScrollbarBarColor = true;
            this.pnSetting.HorizontalScrollbarHighlightOnWheel = false;
            this.pnSetting.HorizontalScrollbarSize = 10;
            this.pnSetting.Location = new System.Drawing.Point(20, 108);
            this.pnSetting.Name = "pnSetting";
            this.pnSetting.Size = new System.Drawing.Size(1222, 689);
            this.pnSetting.TabIndex = 10;
            this.pnSetting.VerticalScrollbarBarColor = true;
            this.pnSetting.VerticalScrollbarHighlightOnWheel = false;
            this.pnSetting.VerticalScrollbarSize = 10;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.pnScheduller);
            this.pnHome.Controls.Add(this.pictureBox1);
            this.pnHome.HorizontalScrollbarBarColor = true;
            this.pnHome.HorizontalScrollbarHighlightOnWheel = false;
            this.pnHome.HorizontalScrollbarSize = 10;
            this.pnHome.Location = new System.Drawing.Point(3, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1216, 686);
            this.pnHome.TabIndex = 3;
            this.pnHome.VerticalScrollbarBarColor = true;
            this.pnHome.VerticalScrollbarHighlightOnWheel = false;
            this.pnHome.VerticalScrollbarSize = 10;
            // 
            // pnScheduller
            // 
            this.pnScheduller.Controls.Add(this.txtLog);
            this.pnScheduller.Controls.Add(this.button4);
            this.pnScheduller.Controls.Add(this.button3);
            this.pnScheduller.Controls.Add(this.button2);
            this.pnScheduller.Controls.Add(this.button1);
            this.pnScheduller.Controls.Add(this.groupBox1);
            this.pnScheduller.HorizontalScrollbarBarColor = true;
            this.pnScheduller.HorizontalScrollbarHighlightOnWheel = false;
            this.pnScheduller.HorizontalScrollbarSize = 10;
            this.pnScheduller.Location = new System.Drawing.Point(3, 3);
            this.pnScheduller.Name = "pnScheduller";
            this.pnScheduller.Size = new System.Drawing.Size(1216, 686);
            this.pnScheduller.TabIndex = 11;
            this.pnScheduller.VerticalScrollbarBarColor = true;
            this.pnScheduller.VerticalScrollbarHighlightOnWheel = false;
            this.pnScheduller.VerticalScrollbarSize = 10;
            // 
            // txtLog
            // 
            // 
            // 
            // 
            this.txtLog.CustomButton.Image = null;
            this.txtLog.CustomButton.Location = new System.Drawing.Point(682, 1);
            this.txtLog.CustomButton.Name = "";
            this.txtLog.CustomButton.Size = new System.Drawing.Size(473, 473);
            this.txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLog.CustomButton.TabIndex = 1;
            this.txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLog.CustomButton.UseSelectable = true;
            this.txtLog.CustomButton.Visible = false;
            this.txtLog.Lines = new string[0];
            this.txtLog.Location = new System.Drawing.Point(31, 190);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.SelectedText = "";
            this.txtLog.SelectionLength = 0;
            this.txtLog.SelectionStart = 0;
            this.txtLog.ShortcutsEnabled = true;
            this.txtLog.Size = new System.Drawing.Size(1156, 475);
            this.txtLog.TabIndex = 8;
            this.txtLog.UseSelectable = true;
            this.txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(933, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Kirim Flat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(900, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Konversi Xls New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1081, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Konversi XLS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1092, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtNext);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtJam);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(331, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIMER";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.metroLabel6.Location = new System.Drawing.Point(336, 64);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(17, 25);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = ":";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.Magenta;
            this.metroLabel7.Location = new System.Drawing.Point(265, 66);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 25);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Next";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // txtNext
            // 
            this.txtNext.AutoSize = true;
            this.txtNext.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtNext.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtNext.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNext.Location = new System.Drawing.Point(363, 66);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(88, 25);
            this.txtNext.TabIndex = 6;
            this.txtNext.Text = "00:00:00";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(336, 31);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(17, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = ":";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(265, 33);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Time ";
            // 
            // txtJam
            // 
            this.txtJam.AutoSize = true;
            this.txtJam.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtJam.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtJam.Location = new System.Drawing.Point(363, 33);
            this.txtJam.Name = "txtJam";
            this.txtJam.Size = new System.Drawing.Size(88, 25);
            this.txtJam.TabIndex = 3;
            this.txtJam.Text = "00:00:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(29, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 72);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(190, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 224);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Basic
            // 
            this.Basic.Controls.Add(this.btnDirError);
            this.Basic.Controls.Add(this.btnDirOutbox);
            this.Basic.Controls.Add(this.btnDirInbox);
            this.Basic.Controls.Add(this.txtDirError);
            this.Basic.Controls.Add(this.txtDirOutbox);
            this.Basic.Controls.Add(this.txtDirInbox);
            this.Basic.Controls.Add(this.metroLabel3);
            this.Basic.Controls.Add(this.metroLabel2);
            this.Basic.Controls.Add(this.metroLabel1);
            this.Basic.Location = new System.Drawing.Point(23, 16);
            this.Basic.Name = "Basic";
            this.Basic.Size = new System.Drawing.Size(475, 157);
            this.Basic.TabIndex = 2;
            this.Basic.TabStop = false;
            this.Basic.Text = "Basic";
            // 
            // btnDirError
            // 
            this.btnDirError.Location = new System.Drawing.Point(410, 90);
            this.btnDirError.Name = "btnDirError";
            this.btnDirError.Size = new System.Drawing.Size(45, 23);
            this.btnDirError.TabIndex = 7;
            this.btnDirError.Text = "...";
            this.btnDirError.UseSelectable = true;
            // 
            // btnDirOutbox
            // 
            this.btnDirOutbox.Location = new System.Drawing.Point(409, 61);
            this.btnDirOutbox.Name = "btnDirOutbox";
            this.btnDirOutbox.Size = new System.Drawing.Size(45, 23);
            this.btnDirOutbox.TabIndex = 7;
            this.btnDirOutbox.Text = "...";
            this.btnDirOutbox.UseSelectable = true;
            // 
            // btnDirInbox
            // 
            this.btnDirInbox.Location = new System.Drawing.Point(410, 32);
            this.btnDirInbox.Name = "btnDirInbox";
            this.btnDirInbox.Size = new System.Drawing.Size(45, 23);
            this.btnDirInbox.TabIndex = 6;
            this.btnDirInbox.Text = "...";
            this.btnDirInbox.UseSelectable = true;
            // 
            // txtDirError
            // 
            // 
            // 
            // 
            this.txtDirError.CustomButton.Image = null;
            this.txtDirError.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtDirError.CustomButton.Name = "";
            this.txtDirError.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDirError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDirError.CustomButton.TabIndex = 1;
            this.txtDirError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDirError.CustomButton.UseSelectable = true;
            this.txtDirError.CustomButton.Visible = false;
            this.txtDirError.Lines = new string[0];
            this.txtDirError.Location = new System.Drawing.Point(170, 90);
            this.txtDirError.MaxLength = 32767;
            this.txtDirError.Name = "txtDirError";
            this.txtDirError.PasswordChar = '\0';
            this.txtDirError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirError.SelectedText = "";
            this.txtDirError.SelectionLength = 0;
            this.txtDirError.SelectionStart = 0;
            this.txtDirError.ShortcutsEnabled = true;
            this.txtDirError.Size = new System.Drawing.Size(233, 23);
            this.txtDirError.TabIndex = 5;
            this.txtDirError.UseSelectable = true;
            this.txtDirError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirError.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDirOutbox
            // 
            // 
            // 
            // 
            this.txtDirOutbox.CustomButton.Image = null;
            this.txtDirOutbox.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtDirOutbox.CustomButton.Name = "";
            this.txtDirOutbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDirOutbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDirOutbox.CustomButton.TabIndex = 1;
            this.txtDirOutbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDirOutbox.CustomButton.UseSelectable = true;
            this.txtDirOutbox.CustomButton.Visible = false;
            this.txtDirOutbox.Lines = new string[0];
            this.txtDirOutbox.Location = new System.Drawing.Point(170, 61);
            this.txtDirOutbox.MaxLength = 32767;
            this.txtDirOutbox.Name = "txtDirOutbox";
            this.txtDirOutbox.PasswordChar = '\0';
            this.txtDirOutbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirOutbox.SelectedText = "";
            this.txtDirOutbox.SelectionLength = 0;
            this.txtDirOutbox.SelectionStart = 0;
            this.txtDirOutbox.ShortcutsEnabled = true;
            this.txtDirOutbox.Size = new System.Drawing.Size(233, 23);
            this.txtDirOutbox.TabIndex = 4;
            this.txtDirOutbox.UseSelectable = true;
            this.txtDirOutbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirOutbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDirInbox
            // 
            // 
            // 
            // 
            this.txtDirInbox.CustomButton.Image = null;
            this.txtDirInbox.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtDirInbox.CustomButton.Name = "";
            this.txtDirInbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDirInbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDirInbox.CustomButton.TabIndex = 1;
            this.txtDirInbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDirInbox.CustomButton.UseSelectable = true;
            this.txtDirInbox.CustomButton.Visible = false;
            this.txtDirInbox.Lines = new string[0];
            this.txtDirInbox.Location = new System.Drawing.Point(170, 32);
            this.txtDirInbox.MaxLength = 32767;
            this.txtDirInbox.Name = "txtDirInbox";
            this.txtDirInbox.PasswordChar = '\0';
            this.txtDirInbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirInbox.SelectedText = "";
            this.txtDirInbox.SelectionLength = 0;
            this.txtDirInbox.SelectionStart = 0;
            this.txtDirInbox.ShortcutsEnabled = true;
            this.txtDirInbox.Size = new System.Drawing.Size(233, 23);
            this.txtDirInbox.TabIndex = 3;
            this.txtDirInbox.UseSelectable = true;
            this.txtDirInbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirInbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Direktori Error";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Direktori Outbox";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Direktori Inbox";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 820);
            this.Controls.Add(this.pnSetting);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Interface Unilever Oleochemical Indonesia";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnSetting.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnScheduller.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Basic.ResumeLayout(false);
            this.Basic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedullerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private MetroFramework.Controls.MetroPanel pnSetting;
        private System.Windows.Forms.GroupBox Basic;
        private MetroFramework.Controls.MetroButton btnDirError;
        private MetroFramework.Controls.MetroButton btnDirOutbox;
        private MetroFramework.Controls.MetroButton btnDirInbox;
        private MetroFramework.Controls.MetroTextBox txtDirError;
        private MetroFramework.Controls.MetroTextBox txtDirOutbox;
        private MetroFramework.Controls.MetroTextBox txtDirInbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel pnScheduller;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel txtJam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel txtNext;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtLog;
    }
}

