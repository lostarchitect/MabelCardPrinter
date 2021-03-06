﻿namespace MabelCardPrinter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToMABELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromMABELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPrinterStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbMabelStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrinterLastMessage = new System.Windows.Forms.TextBox();
            this.tbPrinterStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrinterName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbQueueSize = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progbarPrinting = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMagId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCardId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMemberId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.cbUnattended = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbStatusBar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbCardBack = new System.Windows.Forms.PictureBox();
            this.pbCardFront = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lvLog = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgManagerWorker = new System.ComponentModel.BackgroundWorker();
            this.managerPollTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardFront)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToMABELToolStripMenuItem,
            this.disconnectFromMABELToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewPrinterStatusToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToMABELToolStripMenuItem
            // 
            this.connectToMABELToolStripMenuItem.Name = "connectToMABELToolStripMenuItem";
            this.connectToMABELToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.connectToMABELToolStripMenuItem.Text = "&Connect to MABEL";
            this.connectToMABELToolStripMenuItem.Click += new System.EventHandler(this.connectToMABELToolStripMenuItem_Click);
            // 
            // disconnectFromMABELToolStripMenuItem
            // 
            this.disconnectFromMABELToolStripMenuItem.Enabled = false;
            this.disconnectFromMABELToolStripMenuItem.Name = "disconnectFromMABELToolStripMenuItem";
            this.disconnectFromMABELToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.disconnectFromMABELToolStripMenuItem.Text = "&Disconnect from MABEL";
            this.disconnectFromMABELToolStripMenuItem.Click += new System.EventHandler(this.disconnectFromMABELToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // viewPrinterStatusToolStripMenuItem
            // 
            this.viewPrinterStatusToolStripMenuItem.Name = "viewPrinterStatusToolStripMenuItem";
            this.viewPrinterStatusToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewPrinterStatusToolStripMenuItem.Text = "&View Printer Status";
            this.viewPrinterStatusToolStripMenuItem.Click += new System.EventHandler(this.viewPrinterStatusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbMabelStatus, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbPrinterLastMessage, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbPrinterStatus, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbPrinterName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbQueueSize, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(536, 145);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 144);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // tbMabelStatus
            // 
            this.tbMabelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMabelStatus.Location = new System.Drawing.Point(127, 74);
            this.tbMabelStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMabelStatus.Name = "tbMabelStatus";
            this.tbMabelStatus.ReadOnly = true;
            this.tbMabelStatus.Size = new System.Drawing.Size(240, 20);
            this.tbMabelStatus.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Printer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(2, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "MABEL Status";
            // 
            // tbPrinterLastMessage
            // 
            this.tbPrinterLastMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrinterLastMessage.Location = new System.Drawing.Point(127, 50);
            this.tbPrinterLastMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrinterLastMessage.Name = "tbPrinterLastMessage";
            this.tbPrinterLastMessage.ReadOnly = true;
            this.tbPrinterLastMessage.Size = new System.Drawing.Size(240, 20);
            this.tbPrinterLastMessage.TabIndex = 18;
            // 
            // tbPrinterStatus
            // 
            this.tbPrinterStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrinterStatus.Location = new System.Drawing.Point(127, 26);
            this.tbPrinterStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrinterStatus.Name = "tbPrinterStatus";
            this.tbPrinterStatus.ReadOnly = true;
            this.tbPrinterStatus.Size = new System.Drawing.Size(240, 20);
            this.tbPrinterStatus.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Last Message";
            // 
            // tbPrinterName
            // 
            this.tbPrinterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrinterName.Location = new System.Drawing.Point(127, 2);
            this.tbPrinterName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrinterName.Name = "tbPrinterName";
            this.tbPrinterName.ReadOnly = true;
            this.tbPrinterName.Size = new System.Drawing.Size(240, 20);
            this.tbPrinterName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(2, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Printer Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Card Queue";
            // 
            // tbQueueSize
            // 
            this.tbQueueSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbQueueSize.Location = new System.Drawing.Point(127, 98);
            this.tbQueueSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQueueSize.Name = "tbQueueSize";
            this.tbQueueSize.ReadOnly = true;
            this.tbQueueSize.Size = new System.Drawing.Size(240, 20);
            this.tbQueueSize.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progbarPrinting, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbMagId, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbCardId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMemberId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProgressText, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(536, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 136);
            this.tableLayoutPanel1.TabIndex = 35;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // progbarPrinting
            // 
            this.progbarPrinting.Dock = System.Windows.Forms.DockStyle.Top;
            this.progbarPrinting.Location = new System.Drawing.Point(127, 74);
            this.progbarPrinting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progbarPrinting.Name = "progbarPrinting";
            this.progbarPrinting.Size = new System.Drawing.Size(240, 22);
            this.progbarPrinting.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Progress";
            // 
            // tbMagId
            // 
            this.tbMagId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMagId.Location = new System.Drawing.Point(127, 50);
            this.tbMagId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMagId.Name = "tbMagId";
            this.tbMagId.ReadOnly = true;
            this.tbMagId.Size = new System.Drawing.Size(240, 20);
            this.tbMagId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Magstripe ID";
            // 
            // tbCardId
            // 
            this.tbCardId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCardId.Location = new System.Drawing.Point(127, 26);
            this.tbCardId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCardId.Name = "tbCardId";
            this.tbCardId.ReadOnly = true;
            this.tbCardId.Size = new System.Drawing.Size(240, 20);
            this.tbCardId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Card ID";
            // 
            // tbMemberId
            // 
            this.tbMemberId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMemberId.Location = new System.Drawing.Point(127, 2);
            this.tbMemberId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMemberId.Name = "tbMemberId";
            this.tbMemberId.ReadOnly = true;
            this.tbMemberId.Size = new System.Drawing.Size(240, 20);
            this.tbMemberId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member UUID";
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProgressText.Location = new System.Drawing.Point(127, 98);
            this.lblProgressText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(240, 13);
            this.lblProgressText.TabIndex = 11;
            this.lblProgressText.Text = "Progress";
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 294);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnAbort, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnRetry, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbUnattended, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnPrint, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(536, 295);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(369, 144);
            this.tableLayoutPanel3.TabIndex = 37;
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.DarkRed;
            this.btnAbort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbort.Location = new System.Drawing.Point(186, 61);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(181, 55);
            this.btnAbort.TabIndex = 24;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Gold;
            this.btnRetry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetry.Location = new System.Drawing.Point(2, 61);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(180, 55);
            this.btnRetry.TabIndex = 23;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // cbUnattended
            // 
            this.cbUnattended.AutoSize = true;
            this.cbUnattended.Location = new System.Drawing.Point(187, 121);
            this.cbUnattended.Name = "cbUnattended";
            this.cbUnattended.Size = new System.Drawing.Size(112, 17);
            this.cbUnattended.TabIndex = 25;
            this.cbUnattended.Text = "Unattended Mode";
            this.cbUnattended.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.PaleGreen;
            this.tableLayoutPanel3.SetColumnSpan(this.btnPrint, 2);
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(2, 2);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(365, 55);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbStatusBar
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.tbStatusBar, 2);
            this.tbStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStatusBar.Location = new System.Drawing.Point(2, 444);
            this.tbStatusBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStatusBar.Name = "tbStatusBar";
            this.tbStatusBar.ReadOnly = true;
            this.tbStatusBar.Size = new System.Drawing.Size(904, 20);
            this.tbStatusBar.TabIndex = 34;
            this.tbStatusBar.Text = "Status ...";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pbCardBack, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbCardFront, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(527, 136);
            this.tableLayoutPanel4.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Card Back";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Card Front";
            // 
            // pbCardBack
            // 
            this.pbCardBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCardBack.Location = new System.Drawing.Point(269, 2);
            this.pbCardBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCardBack.Name = "pbCardBack";
            this.pbCardBack.Size = new System.Drawing.Size(256, 104);
            this.pbCardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardBack.TabIndex = 2;
            this.pbCardBack.TabStop = false;
            // 
            // pbCardFront
            // 
            this.pbCardFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCardFront.Location = new System.Drawing.Point(2, 2);
            this.pbCardFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCardFront.Name = "pbCardFront";
            this.pbCardFront.Size = new System.Drawing.Size(263, 104);
            this.pbCardFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardFront.TabIndex = 1;
            this.pbCardFront.TabStop = false;
            this.pbCardFront.Click += new System.EventHandler(this.pbCardFront_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel5.Controls.Add(this.lvLog, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbStatusBar, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(908, 462);
            this.tableLayoutPanel5.TabIndex = 39;
            // 
            // lvLog
            // 
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Message});
            this.lvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLog.Location = new System.Drawing.Point(2, 144);
            this.lvLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(529, 146);
            this.lvLog.TabIndex = 40;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 135;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 1200;
            // 
            // bgManagerWorker
            // 
            this.bgManagerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgManagerWorker_DoWork);
            // 
            // managerPollTimer
            // 
            this.managerPollTimer.Enabled = true;
            this.managerPollTimer.Interval = 2500;
            this.managerPollTimer.Tick += new System.EventHandler(this.managerPollTimer_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 486);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(842, 453);
            this.Name = "MainForm";
            this.Text = "MABEL Card Printer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardFront)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToMABELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPrinterStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromMABELToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbMabelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrinterLastMessage;
        private System.Windows.Forms.TextBox tbPrinterStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrinterName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progbarPrinting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMagId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCardId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMemberId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox cbUnattended;
        private System.Windows.Forms.TextBox tbStatusBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbCardBack;
        private System.Windows.Forms.PictureBox pbCardFront;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbQueueSize;
        private System.ComponentModel.BackgroundWorker bgManagerWorker;
        private System.Windows.Forms.Timer managerPollTimer;
    }
}