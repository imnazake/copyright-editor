namespace CopyrightEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupportedFileExtensions = new System.Windows.Forms.TextBox();
            this.bAddEmptyLineAfterCopyrightNotice = new System.Windows.Forms.CheckBox();
            this.bAddCopyrightNoticeIfNotFound = new System.Windows.Forms.CheckBox();
            this.bFindExistingCopyrightNotice = new System.Windows.Forms.CheckBox();
            this.ExistingCopyrightNotice = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewCopyrightNotice = new System.Windows.Forms.RichTextBox();
            this.SourceFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeCopyrightButton = new System.Windows.Forms.Button();
            this.BrowseFolderPath = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.WorkerThread = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SupportedFileExtensions);
            this.groupBox1.Controls.Add(this.bAddEmptyLineAfterCopyrightNotice);
            this.groupBox1.Controls.Add(this.bAddCopyrightNoticeIfNotFound);
            this.groupBox1.Controls.Add(this.bFindExistingCopyrightNotice);
            this.groupBox1.Controls.Add(this.ExistingCopyrightNotice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NewCopyrightNotice);
            this.groupBox1.Controls.Add(this.SourceFolderPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Configuration ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Supported Files Extensions (Separated by comma)";
            // 
            // SupportedFileExtensions
            // 
            this.SupportedFileExtensions.Location = new System.Drawing.Point(9, 71);
            this.SupportedFileExtensions.Name = "SupportedFileExtensions";
            this.SupportedFileExtensions.Size = new System.Drawing.Size(453, 20);
            this.SupportedFileExtensions.TabIndex = 11;
            this.SupportedFileExtensions.Text = ".h,.cpp,.cs";
            this.SupportedFileExtensions.TextChanged += new System.EventHandler(this.SupportedFileExtensions_TextChanged);
            // 
            // bAddEmptyLineAfterCopyrightNotice
            // 
            this.bAddEmptyLineAfterCopyrightNotice.AutoSize = true;
            this.bAddEmptyLineAfterCopyrightNotice.Location = new System.Drawing.Point(9, 143);
            this.bAddEmptyLineAfterCopyrightNotice.Name = "bAddEmptyLineAfterCopyrightNotice";
            this.bAddEmptyLineAfterCopyrightNotice.Size = new System.Drawing.Size(230, 17);
            this.bAddEmptyLineAfterCopyrightNotice.TabIndex = 10;
            this.bAddEmptyLineAfterCopyrightNotice.Text = "Add an empty line after the copyright notice";
            this.bAddEmptyLineAfterCopyrightNotice.UseVisualStyleBackColor = true;
            // 
            // bAddCopyrightNoticeIfNotFound
            // 
            this.bAddCopyrightNoticeIfNotFound.AutoSize = true;
            this.bAddCopyrightNoticeIfNotFound.Location = new System.Drawing.Point(9, 120);
            this.bAddCopyrightNoticeIfNotFound.Name = "bAddCopyrightNoticeIfNotFound";
            this.bAddCopyrightNoticeIfNotFound.Size = new System.Drawing.Size(210, 17);
            this.bAddCopyrightNoticeIfNotFound.TabIndex = 9;
            this.bAddCopyrightNoticeIfNotFound.Text = "Add copyright notice if not found on file";
            this.bAddCopyrightNoticeIfNotFound.UseVisualStyleBackColor = true;
            this.bAddCopyrightNoticeIfNotFound.CheckedChanged += new System.EventHandler(this.bAddCopyrightNoticeIfNotFound_CheckedChanged);
            // 
            // bFindExistingCopyrightNotice
            // 
            this.bFindExistingCopyrightNotice.AutoSize = true;
            this.bFindExistingCopyrightNotice.Location = new System.Drawing.Point(9, 97);
            this.bFindExistingCopyrightNotice.Name = "bFindExistingCopyrightNotice";
            this.bFindExistingCopyrightNotice.Size = new System.Drawing.Size(253, 17);
            this.bFindExistingCopyrightNotice.TabIndex = 8;
            this.bFindExistingCopyrightNotice.Text = "Try to find existing copyright notice automatically";
            this.bFindExistingCopyrightNotice.UseVisualStyleBackColor = true;
            this.bFindExistingCopyrightNotice.CheckedChanged += new System.EventHandler(this.bFindExistingCopyrightNotice_CheckedChanged);
            // 
            // ExistingCopyrightNotice
            // 
            this.ExistingCopyrightNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExistingCopyrightNotice.Location = new System.Drawing.Point(9, 197);
            this.ExistingCopyrightNotice.Name = "ExistingCopyrightNotice";
            this.ExistingCopyrightNotice.Size = new System.Drawing.Size(453, 133);
            this.ExistingCopyrightNotice.TabIndex = 7;
            this.ExistingCopyrightNotice.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existing Copyright Notice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Copyright Notice";
            // 
            // NewCopyrightNotice
            // 
            this.NewCopyrightNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewCopyrightNotice.Location = new System.Drawing.Point(9, 349);
            this.NewCopyrightNotice.Name = "NewCopyrightNotice";
            this.NewCopyrightNotice.Size = new System.Drawing.Size(453, 143);
            this.NewCopyrightNotice.TabIndex = 2;
            this.NewCopyrightNotice.Text = "";
            this.NewCopyrightNotice.TextChanged += new System.EventHandler(this.NewCopyrightNoticeComment_TextChanged);
            // 
            // SourceFolderPath
            // 
            this.SourceFolderPath.Location = new System.Drawing.Point(9, 32);
            this.SourceFolderPath.Name = "SourceFolderPath";
            this.SourceFolderPath.ReadOnly = true;
            this.SourceFolderPath.Size = new System.Drawing.Size(379, 20);
            this.SourceFolderPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Code Folder Path";
            // 
            // ChangeCopyrightButton
            // 
            this.ChangeCopyrightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeCopyrightButton.Location = new System.Drawing.Point(12, 518);
            this.ChangeCopyrightButton.Name = "ChangeCopyrightButton";
            this.ChangeCopyrightButton.Size = new System.Drawing.Size(470, 28);
            this.ChangeCopyrightButton.TabIndex = 6;
            this.ChangeCopyrightButton.Text = "Change Copyright Notice";
            this.ChangeCopyrightButton.UseVisualStyleBackColor = true;
            this.ChangeCopyrightButton.Click += new System.EventHandler(this.ChangeCopyrightButton_Click);
            // 
            // BrowseFolderPath
            // 
            this.BrowseFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFolderPath.Location = new System.Drawing.Point(406, 43);
            this.BrowseFolderPath.Name = "BrowseFolderPath";
            this.BrowseFolderPath.Size = new System.Drawing.Size(68, 22);
            this.BrowseFolderPath.TabIndex = 7;
            this.BrowseFolderPath.Text = "Browse";
            this.BrowseFolderPath.UseVisualStyleBackColor = true;
            this.BrowseFolderPath.Click += new System.EventHandler(this.BrowseFolderPath_Click);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.Description = "Select Your Project Source Folder Path";
            // 
            // WorkerThread
            // 
            this.WorkerThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerThread_DoWork);
            this.WorkerThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerThread_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 558);
            this.Controls.Add(this.BrowseFolderPath);
            this.Controls.Add(this.ChangeCopyrightButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Copyright Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NewCopyrightNotice;
        private System.Windows.Forms.TextBox SourceFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeCopyrightButton;
        private System.Windows.Forms.Button BrowseFolderPath;
        public System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.RichTextBox ExistingCopyrightNotice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox bFindExistingCopyrightNotice;
        private System.Windows.Forms.CheckBox bAddCopyrightNoticeIfNotFound;
        private System.ComponentModel.BackgroundWorker WorkerThread;
        private System.Windows.Forms.CheckBox bAddEmptyLineAfterCopyrightNotice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupportedFileExtensions;
    }
}

