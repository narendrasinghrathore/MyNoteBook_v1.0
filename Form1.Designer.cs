namespace MyNoteBook_v1._0
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mydocsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetForReportViewer = new MyNoteBook_v1._0.DatasetForReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.prenotes = new System.Windows.Forms.ListBox();
            this.mydate = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextFileToNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportInDocumnetFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reminddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblreminder = new System.Windows.Forms.Label();
            this.ReminderLabel = new System.Windows.Forms.Label();
            this.reminderlist = new System.Windows.Forms.ListBox();
            this.ReminderLabelTotal = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.showInternetbtn = new System.Windows.Forms.Button();
            this.BrowserForwardBtn = new System.Windows.Forms.Button();
            this.BrowserBackBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ActiviyLogStatus = new System.Windows.Forms.ListBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveButton_ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.getPDFbtn_ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noteTitle_ = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mydocsTableAdapter = new MyNoteBook_v1._0.DatasetForReportViewerTableAdapters.mydocsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.showReminderbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mydocsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetForReportViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mydocsBindingSource
            // 
            this.mydocsBindingSource.DataMember = "mydocs";
            this.mydocsBindingSource.DataSource = this.DatasetForReportViewer;
            // 
            // DatasetForReportViewer
            // 
            this.DatasetForReportViewer.DataSetName = "DatasetForReportViewer";
            this.DatasetForReportViewer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(895, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Previous saved notes, select to see/edit.";
            // 
            // prenotes
            // 
            this.prenotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prenotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prenotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenotes.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.prenotes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prenotes.FormattingEnabled = true;
            this.prenotes.ItemHeight = 25;
            this.prenotes.Location = new System.Drawing.Point(900, 88);
            this.prenotes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.prenotes.Name = "prenotes";
            this.prenotes.Size = new System.Drawing.Size(326, 27);
            this.prenotes.Sorted = true;
            this.prenotes.TabIndex = 6;
            this.prenotes.SelectedIndexChanged += new System.EventHandler(this.prenotes_SelectedIndexChanged);
            // 
            // mydate
            // 
            this.mydate.AutoSize = true;
            this.mydate.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mydate.ForeColor = System.Drawing.Color.DimGray;
            this.mydate.Location = new System.Drawing.Point(7, 545);
            this.mydate.Name = "mydate";
            this.mydate.Size = new System.Drawing.Size(108, 25);
            this.mydate.TabIndex = 10;
            this.mydate.Text = "Last edited: ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(13, 12);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1238, 718);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape4.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape4.BorderColor = System.Drawing.Color.Silver;
            this.rectangleShape4.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShape4.FillGradientColor = System.Drawing.Color.DarkRed;
            this.rectangleShape4.Location = new System.Drawing.Point(884, 199);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape4.Size = new System.Drawing.Size(332, 31);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape2.BackColor = System.Drawing.Color.Silver;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.Silver;
            this.rectangleShape2.Location = new System.Drawing.Point(887, 71);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(325, 4);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(3, 663);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1227, 67);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFomToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(13, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1238, 26);
            this.menuStrip1.TabIndex = 14;
            // 
            // saveFomToolStripMenuItem
            // 
            this.saveFomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTextFileToNoteToolStripMenuItem,
            this.pDFToNotesToolStripMenuItem});
            this.saveFomToolStripMenuItem.ForeColor = System.Drawing.Color.SlateGray;
            this.saveFomToolStripMenuItem.Name = "saveFomToolStripMenuItem";
            this.saveFomToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveFomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.saveFomToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.saveFomToolStripMenuItem.Text = "Menu";
            // 
            // saveTextFileToNoteToolStripMenuItem
            // 
            this.saveTextFileToNoteToolStripMenuItem.AutoToolTip = true;
            this.saveTextFileToNoteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveTextFileToNoteToolStripMenuItem.Name = "saveTextFileToNoteToolStripMenuItem";
            this.saveTextFileToNoteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saveTextFileToNoteToolStripMenuItem.Text = "(1) Open Text File to Notes";
            this.saveTextFileToNoteToolStripMenuItem.ToolTipText = "Open a text file and save to your Note Database.";
            this.saveTextFileToNoteToolStripMenuItem.Click += new System.EventHandler(this.saveTextFileToNoteToolStripMenuItem_Click);
            // 
            // pDFToNotesToolStripMenuItem
            // 
            this.pDFToNotesToolStripMenuItem.Name = "pDFToNotesToolStripMenuItem";
            this.pDFToNotesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.pDFToNotesToolStripMenuItem.Text = "(2 ) PDF To Notes";
            this.pDFToNotesToolStripMenuItem.Click += new System.EventHandler(this.pDFToNotesToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exportInDocumnetFormatToolStripMenuItem});
            this.backupToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.ToolTipText = "Backup your Data";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exportToolStripMenuItem.Text = "1) Export in PDF format";
            this.exportToolStripMenuItem.ToolTipText = "All files in Pdf format";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportInDocumnetFormatToolStripMenuItem
            // 
            this.exportInDocumnetFormatToolStripMenuItem.Name = "exportInDocumnetFormatToolStripMenuItem";
            this.exportInDocumnetFormatToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exportInDocumnetFormatToolStripMenuItem.Text = "2) Export in Document format";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoToolTip = true;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit Application.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reminddateTimePicker1
            // 
            this.reminddateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.Desktop;
            this.reminddateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.reminddateTimePicker1.Checked = false;
            this.reminddateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reminddateTimePicker1.CustomFormat = "";
            this.reminddateTimePicker1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.reminddateTimePicker1.Location = new System.Drawing.Point(116, 472);
            this.reminddateTimePicker1.Name = "reminddateTimePicker1";
            this.reminddateTimePicker1.ShowCheckBox = true;
            this.reminddateTimePicker1.Size = new System.Drawing.Size(252, 26);
            this.reminddateTimePicker1.TabIndex = 15;
            this.reminddateTimePicker1.Value = new System.DateTime(2014, 7, 25, 0, 0, 0, 0);
            // 
            // lblreminder
            // 
            this.lblreminder.AutoSize = true;
            this.lblreminder.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lblreminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblreminder.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lblreminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblreminder.Location = new System.Drawing.Point(8, 472);
            this.lblreminder.Name = "lblreminder";
            this.lblreminder.Size = new System.Drawing.Size(102, 19);
            this.lblreminder.TabIndex = 16;
            this.lblreminder.Text = "Remind me on:";
            // 
            // ReminderLabel
            // 
            this.ReminderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReminderLabel.AutoSize = true;
            this.ReminderLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReminderLabel.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.ReminderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReminderLabel.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ReminderLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ReminderLabel.Location = new System.Drawing.Point(943, 218);
            this.ReminderLabel.Name = "ReminderLabel";
            this.ReminderLabel.Size = new System.Drawing.Size(149, 20);
            this.ReminderLabel.TabIndex = 18;
            this.ReminderLabel.Text = "UpComing Reminders";
            // 
            // reminderlist
            // 
            this.reminderlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderlist.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.reminderlist.ForeColor = System.Drawing.Color.Gray;
            this.reminderlist.FormattingEnabled = true;
            this.reminderlist.ItemHeight = 20;
            this.reminderlist.Location = new System.Drawing.Point(900, 257);
            this.reminderlist.Name = "reminderlist";
            this.reminderlist.Size = new System.Drawing.Size(333, 64);
            this.reminderlist.TabIndex = 19;
            // 
            // ReminderLabelTotal
            // 
            this.ReminderLabelTotal.AllowDrop = true;
            this.ReminderLabelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReminderLabelTotal.AutoEllipsis = true;
            this.ReminderLabelTotal.AutoSize = true;
            this.ReminderLabelTotal.BackColor = System.Drawing.Color.Black;
            this.ReminderLabelTotal.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.ReminderLabelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReminderLabelTotal.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ReminderLabelTotal.ForeColor = System.Drawing.Color.White;
            this.ReminderLabelTotal.Location = new System.Drawing.Point(906, 207);
            this.ReminderLabelTotal.Name = "ReminderLabelTotal";
            this.ReminderLabelTotal.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ReminderLabelTotal.Size = new System.Drawing.Size(24, 40);
            this.ReminderLabelTotal.TabIndex = 20;
            this.ReminderLabelTotal.Text = "-";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Application Running";
            this.notifyIcon1.BalloonTipTitle = "Application Info";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "My NoteBook v1.0 - Running";
            this.notifyIcon1.Visible = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.showInternetbtn);
            this.tabPage5.Controls.Add(this.BrowserForwardBtn);
            this.tabPage5.Controls.Add(this.BrowserBackBtn);
            this.tabPage5.Controls.Add(this.webBrowser1);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(865, 602);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Web Browser";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // showInternetbtn
            // 
            this.showInternetbtn.FlatAppearance.BorderSize = 0;
            this.showInternetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInternetbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.showInternetbtn.Location = new System.Drawing.Point(501, 7);
            this.showInternetbtn.Name = "showInternetbtn";
            this.showInternetbtn.Size = new System.Drawing.Size(126, 31);
            this.showInternetbtn.TabIndex = 11;
            this.showInternetbtn.Text = "Start Internet";
            this.showInternetbtn.UseVisualStyleBackColor = true;
            this.showInternetbtn.Click += new System.EventHandler(this.showInternetbtn_Click);
            // 
            // BrowserForwardBtn
            // 
            this.BrowserForwardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BrowserForwardBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BrowserForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserForwardBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BrowserForwardBtn.Location = new System.Drawing.Point(740, 7);
            this.BrowserForwardBtn.Name = "BrowserForwardBtn";
            this.BrowserForwardBtn.Size = new System.Drawing.Size(75, 32);
            this.BrowserForwardBtn.TabIndex = 10;
            this.BrowserForwardBtn.Text = "Forward";
            this.BrowserForwardBtn.UseVisualStyleBackColor = false;
            this.BrowserForwardBtn.Click += new System.EventHandler(this.BrowserForwardBtn_Click);
            // 
            // BrowserBackBtn
            // 
            this.BrowserBackBtn.BackColor = System.Drawing.Color.Gray;
            this.BrowserBackBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BrowserBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserBackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BrowserBackBtn.Location = new System.Drawing.Point(641, 7);
            this.BrowserBackBtn.Name = "BrowserBackBtn";
            this.BrowserBackBtn.Size = new System.Drawing.Size(75, 32);
            this.BrowserBackBtn.TabIndex = 9;
            this.BrowserBackBtn.Text = "Back";
            this.BrowserBackBtn.UseVisualStyleBackColor = false;
            this.BrowserBackBtn.Click += new System.EventHandler(this.BrowserBackBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(7, 45);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(852, 397);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://google.co.in", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ActiviyLogStatus);
            this.tabPage3.Controls.Add(this.shapeContainer3);
            this.tabPage3.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(865, 602);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Activity Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ActiviyLogStatus
            // 
            this.ActiviyLogStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActiviyLogStatus.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ActiviyLogStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ActiviyLogStatus.FormattingEnabled = true;
            this.ActiviyLogStatus.ItemHeight = 23;
            this.ActiviyLogStatus.Location = new System.Drawing.Point(8, 18);
            this.ActiviyLogStatus.Name = "ActiviyLogStatus";
            this.ActiviyLogStatus.Size = new System.Drawing.Size(851, 161);
            this.ActiviyLogStatus.TabIndex = 0;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5});
            this.shapeContainer3.Size = new System.Drawing.Size(859, 596);
            this.shapeContainer3.TabIndex = 1;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BackColor = System.Drawing.Color.SteelBlue;
            this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape5.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape5.Location = new System.Drawing.Point(5, 2);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(851, 11);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource4.Name = "ReportViewerDataset";
            reportDataSource4.Value = this.mydocsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyNoteBook_v1._0.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(859, 596);
            this.reportViewer1.TabIndex = 23;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.mydate);
            this.tabPage1.Controls.Add(this.reminddateTimePicker1);
            this.tabPage1.Controls.Add(this.lblreminder);
            this.tabPage1.Controls.Add(this.delete_);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.saveButton_);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.notes);
            this.tabPage1.Controls.Add(this.getPDFbtn_);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.noteTitle_);
            this.tabPage1.Controls.Add(this.shapeContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Save/Update";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delete_
            // 
            this.delete_.BackColor = System.Drawing.Color.Transparent;
            this.delete_.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_.FlatAppearance.BorderSize = 2;
            this.delete_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.delete_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_.Location = new System.Drawing.Point(631, 300);
            this.delete_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_.Name = "delete_";
            this.delete_.Padding = new System.Windows.Forms.Padding(5);
            this.delete_.Size = new System.Drawing.Size(118, 45);
            this.delete_.TabIndex = 8;
            this.delete_.Text = "Delete";
            this.delete_.UseVisualStyleBackColor = false;
            this.delete_.Click += new System.EventHandler(this.delete__Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(631, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.progressBar1.Location = new System.Drawing.Point(631, 104);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 44);
            this.progressBar1.TabIndex = 21;
            // 
            // saveButton_
            // 
            this.saveButton_.BackColor = System.Drawing.Color.Transparent;
            this.saveButton_.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.saveButton_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.saveButton_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton_.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.saveButton_.ForeColor = System.Drawing.Color.Black;
            this.saveButton_.Location = new System.Drawing.Point(631, 164);
            this.saveButton_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton_.Name = "saveButton_";
            this.saveButton_.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton_.Size = new System.Drawing.Size(118, 45);
            this.saveButton_.TabIndex = 4;
            this.saveButton_.Text = "Save";
            this.saveButton_.UseVisualStyleBackColor = false;
            this.saveButton_.Click += new System.EventHandler(this.saveButton__Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Write Here:";
            // 
            // notes
            // 
            this.notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes.EnableAutoDragDrop = true;
            this.notes.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.notes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.notes.Location = new System.Drawing.Point(6, 104);
            this.notes.Name = "notes";
            this.notes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notes.Size = new System.Drawing.Size(619, 307);
            this.notes.TabIndex = 2;
            this.notes.Text = "";
            this.notes.Leave += new System.EventHandler(this.notes_Leave);
            // 
            // getPDFbtn_
            // 
            this.getPDFbtn_.BackColor = System.Drawing.Color.Transparent;
            this.getPDFbtn_.FlatAppearance.BorderSize = 2;
            this.getPDFbtn_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPDFbtn_.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.getPDFbtn_.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getPDFbtn_.Location = new System.Drawing.Point(631, 366);
            this.getPDFbtn_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getPDFbtn_.Name = "getPDFbtn_";
            this.getPDFbtn_.Padding = new System.Windows.Forms.Padding(5);
            this.getPDFbtn_.Size = new System.Drawing.Size(118, 45);
            this.getPDFbtn_.TabIndex = 13;
            this.getPDFbtn_.Text = "Get PDF";
            this.getPDFbtn_.UseVisualStyleBackColor = false;
            this.getPDFbtn_.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note Title:";
            // 
            // noteTitle_
            // 
            this.noteTitle_.BackColor = System.Drawing.SystemColors.Control;
            this.noteTitle_.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.noteTitle_.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.noteTitle_.Location = new System.Drawing.Point(105, 17);
            this.noteTitle_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noteTitle_.Multiline = true;
            this.noteTitle_.Name = "noteTitle_";
            this.noteTitle_.Size = new System.Drawing.Size(222, 25);
            this.noteTitle_.TabIndex = 1;
            this.noteTitle_.Leave += new System.EventHandler(this.noteTitle__Leave);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(859, 596);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.SteelBlue;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape3.Location = new System.Drawing.Point(100, 7);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(226, 7);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(16, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(873, 634);
            this.tabControl1.TabIndex = 23;
            // 
            // mydocsTableAdapter
            // 
            this.mydocsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(900, 396);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(351, 91);
            this.label4.TabIndex = 24;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showReminderbtn
            // 
            this.showReminderbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showReminderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.showReminderbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.showReminderbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.showReminderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReminderbtn.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.showReminderbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showReminderbtn.Location = new System.Drawing.Point(1152, 213);
            this.showReminderbtn.Name = "showReminderbtn";
            this.showReminderbtn.Padding = new System.Windows.Forms.Padding(1);
            this.showReminderbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showReminderbtn.Size = new System.Drawing.Size(75, 28);
            this.showReminderbtn.TabIndex = 25;
            this.showReminderbtn.Text = "Show";
            this.showReminderbtn.UseVisualStyleBackColor = true;
            this.showReminderbtn.Click += new System.EventHandler(this.showReminderbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 742);
            this.Controls.Add(this.showReminderbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ReminderLabelTotal);
            this.Controls.Add(this.reminderlist);
            this.Controls.Add(this.ReminderLabel);
            this.Controls.Add(this.prenotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My NoteBook v1.0 - Sky Sun Softwares ©.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydocsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetForReportViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox prenotes;
        private System.Windows.Forms.Label mydate;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveFomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextFileToNoteToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker reminddateTimePicker1;
        private System.Windows.Forms.Label lblreminder;
        private System.Windows.Forms.Label ReminderLabel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.ListBox reminderlist;
        private System.Windows.Forms.Label ReminderLabelTotal;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource mydocsBindingSource;
        private DatasetForReportViewer DatasetForReportViewer;
        private DatasetForReportViewerTableAdapters.mydocsTableAdapter mydocsTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button BrowserForwardBtn;
        private System.Windows.Forms.Button BrowserBackBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox ActiviyLogStatus;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button delete_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button saveButton_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Button getPDFbtn_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noteTitle_;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportInDocumnetFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button showReminderbtn;
        private System.Windows.Forms.Button showInternetbtn;
        private System.Windows.Forms.ToolStripMenuItem pDFToNotesToolStripMenuItem;
    }
}