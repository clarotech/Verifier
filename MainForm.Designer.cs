namespace Clarotech.Verifier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExampleDirectory = new System.Windows.Forms.TextBox();
            this.btnOpenExampleDir = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOpenProfileDir = new System.Windows.Forms.Button();
            this.txtProfileDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkShowTraceInfo = new System.Windows.Forms.CheckBox();
            this.chkXsdValidation = new System.Windows.Forms.CheckBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnErrors = new System.Windows.Forms.Button();
            this.btnWarnings = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colErr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.icon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtExampleDirectory);
            this.groupBox1.Controls.Add(this.btnOpenExampleDir);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnOpenProfileDir);
            this.groupBox1.Controls.Add(this.txtProfileDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile source directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Examples";
            // 
            // txtExampleDirectory
            // 
            this.txtExampleDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExampleDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clarotech.Verifier.Properties.Settings.Default, "ProfileExampleDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExampleDirectory.Location = new System.Drawing.Point(65, 73);
            this.txtExampleDirectory.Name = "txtExampleDirectory";
            this.txtExampleDirectory.Size = new System.Drawing.Size(663, 20);
            this.txtExampleDirectory.TabIndex = 4;
            this.txtExampleDirectory.Text = global::Clarotech.Verifier.Properties.Settings.Default.ProfileExampleDirectory;
            this.txtExampleDirectory.TextChanged += new System.EventHandler(this.txtExampleDirectory_TextChanged);
            // 
            // btnOpenExampleDir
            // 
            this.btnOpenExampleDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenExampleDir.Location = new System.Drawing.Point(737, 73);
            this.btnOpenExampleDir.Name = "btnOpenExampleDir";
            this.btnOpenExampleDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenExampleDir.TabIndex = 2;
            this.btnOpenExampleDir.Text = "Browse...";
            this.btnOpenExampleDir.UseVisualStyleBackColor = true;
            this.btnOpenExampleDir.Click += new System.EventHandler(this.btnOpenExampleDir_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(817, 40);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOpenProfileDir
            // 
            this.btnOpenProfileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenProfileDir.Location = new System.Drawing.Point(737, 40);
            this.btnOpenProfileDir.Name = "btnOpenProfileDir";
            this.btnOpenProfileDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenProfileDir.TabIndex = 2;
            this.btnOpenProfileDir.Text = "Browse...";
            this.btnOpenProfileDir.UseVisualStyleBackColor = true;
            this.btnOpenProfileDir.Click += new System.EventHandler(this.btnOpenProfileDir_Click);
            // 
            // txtProfileDirectory
            // 
            this.txtProfileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfileDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clarotech.Verifier.Properties.Settings.Default, "ProfileSourceDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProfileDirectory.Location = new System.Drawing.Point(65, 42);
            this.txtProfileDirectory.Name = "txtProfileDirectory";
            this.txtProfileDirectory.Size = new System.Drawing.Size(663, 20);
            this.txtProfileDirectory.TabIndex = 1;
            this.txtProfileDirectory.Text = global::Clarotech.Verifier.Properties.Settings.Default.ProfileSourceDirectory;
            this.txtProfileDirectory.TextChanged += new System.EventHandler(this.txtProfileDirectory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profiles";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkShowTraceInfo);
            this.groupBox2.Controls.Add(this.chkXsdValidation);
            this.groupBox2.Controls.Add(this.btnValidate);
            this.groupBox2.Location = new System.Drawing.Point(12, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instance (xml)";
            // 
            // chkShowTraceInfo
            // 
            this.chkShowTraceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowTraceInfo.AutoSize = true;
            this.chkShowTraceInfo.Location = new System.Drawing.Point(524, 18);
            this.chkShowTraceInfo.Name = "chkShowTraceInfo";
            this.chkShowTraceInfo.Size = new System.Drawing.Size(181, 17);
            this.chkShowTraceInfo.TabIndex = 7;
            this.chkShowTraceInfo.Text = "Include trace information in result";
            this.chkShowTraceInfo.UseVisualStyleBackColor = true;
            // 
            // chkXsdValidation
            // 
            this.chkXsdValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkXsdValidation.AutoSize = true;
            this.chkXsdValidation.Location = new System.Drawing.Point(748, 17);
            this.chkXsdValidation.Name = "chkXsdValidation";
            this.chkXsdValidation.Size = new System.Drawing.Size(135, 17);
            this.chkXsdValidation.TabIndex = 6;
            this.chkXsdValidation.Text = "Also use Xsd validation";
            this.chkXsdValidation.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValidate.Location = new System.Drawing.Point(6, 13);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate!";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "netplwiz_dll_Ico8_ico_Ico1.ico");
            this.imageList1.Images.SetKeyName(1, "explorer_exe_Ico64_ico_Ico1.ico");
            this.imageList1.Images.SetKeyName(2, "1476206043_warning_48.png");
            this.imageList1.Images.SetKeyName(3, "Info.png");
            this.imageList1.Images.SetKeyName(4, "xml-512.png");
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a folder where this application can find your profiles to validate against" +
    ".";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // btnErrors
            // 
            this.btnErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnErrors.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnErrors.FlatAppearance.BorderSize = 2;
            this.btnErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErrors.ImageIndex = 1;
            this.btnErrors.ImageList = this.imageList1;
            this.btnErrors.Location = new System.Drawing.Point(18, 719);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(120, 27);
            this.btnErrors.TabIndex = 1;
            this.btnErrors.Text = "0 Errors";
            this.btnErrors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnErrors.UseVisualStyleBackColor = true;
            this.btnErrors.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnWarnings
            // 
            this.btnWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWarnings.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnWarnings.FlatAppearance.BorderSize = 2;
            this.btnWarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarnings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarnings.ImageIndex = 0;
            this.btnWarnings.ImageList = this.imageList1;
            this.btnWarnings.Location = new System.Drawing.Point(144, 719);
            this.btnWarnings.Name = "btnWarnings";
            this.btnWarnings.Size = new System.Drawing.Size(120, 27);
            this.btnWarnings.TabIndex = 2;
            this.btnWarnings.Text = "0 Warnings";
            this.btnWarnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWarnings.UseVisualStyleBackColor = true;
            this.btnWarnings.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMessages.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMessages.FlatAppearance.BorderSize = 2;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.ImageIndex = 3;
            this.btnMessages.ImageList = this.imageList1;
            this.btnMessages.Location = new System.Drawing.Point(270, 719);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(120, 27);
            this.btnMessages.TabIndex = 4;
            this.btnMessages.Text = "0 Messages";
            this.btnMessages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lvResults
            // 
            this.lvResults.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilename,
            this.colStatus,
            this.colErr,
            this.colWarn,
            this.colMsg});
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(12, 117);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(894, 218);
            this.lvResults.SmallImageList = this.imageList1;
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            this.lvResults.SelectedIndexChanged += new System.EventHandler(this.lvResults_SelectedIndexChanged);
            // 
            // colFilename
            // 
            this.colFilename.Text = "Name";
            this.colFilename.Width = global::Clarotech.Verifier.Properties.Settings.Default.resColName;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = global::Clarotech.Verifier.Properties.Settings.Default.resColStatusWidth;
            // 
            // colMsg
            // 
            this.colMsg.Text = "Messages";
            this.colMsg.Width = 450;
            // 
            // colErr
            // 
            this.colErr.Text = "Errors";
            this.colErr.Width = 120;
            // 
            // colWarn
            // 
            this.colWarn.Text = "Warnings";
            this.colWarn.Width = 120;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 398);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 304);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtered Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icon,
            this.status,
            this.path,
            this.description});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(878, 272);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // icon
            // 
            this.icon.Text = " ";
            this.icon.Width = 25;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 120;
            // 
            // path
            // 
            this.path.DisplayIndex = 3;
            this.path.Text = "Path";
            // 
            // description
            // 
            this.description.DisplayIndex = 2;
            this.description.Text = "Description";
            this.description.Width = 401;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtOutcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtOutcome
            // 
            this.txtOutcome.AcceptsTab = true;
            this.txtOutcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutcome.Location = new System.Drawing.Point(3, 3);
            this.txtOutcome.Multiline = true;
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.ReadOnly = true;
            this.txtOutcome.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutcome.Size = new System.Drawing.Size(861, 272);
            this.txtOutcome.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 756);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.btnWarnings);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnErrors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Verifier - Profile Validator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnOpenProfileDir;
        private System.Windows.Forms.TextBox txtProfileDirectory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkXsdValidation;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.CheckBox chkShowTraceInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnOpenExampleDir;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Button btnWarnings;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.TextBox txtExampleDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colMsg;
        private System.Windows.Forms.ColumnHeader colErr;
        private System.Windows.Forms.ColumnHeader colWarn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader icon;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtOutcome;
    }
}

