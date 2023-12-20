using System;
using System.Windows.Forms;

namespace CopyrightEditor
{
    public partial class MainForm : Form
    {
        CopyrightNoticeEditor CopyrightNoticeEditorInstance = new CopyrightNoticeEditor();

        public MainForm()
        {
            InitializeComponent();
            UpdateCopyrightEditorInstanceConfig();
        }

        private void ChangeCopyrightButton_Click(object sender, EventArgs e)
        {
            UpdateCopyrightEditorInstanceConfig();
            CheckCopyrightEditorInstanceConfig();
    
            if (CopyrightNoticeEditorInstance.HasValidConfig())
            {
                WorkerThread.RunWorkerAsync();
                ChangeCopyrightButton.Enabled = false;
                ChangeCopyrightButton.Text = "Please wait ...";
            }        
        }

        private void BrowseFolderPath_Click(object sender, EventArgs e)
        {
            DialogResult Result = FolderBrowserDialog.ShowDialog();
            
            if (Result == DialogResult.OK)
            {
                CopyrightNoticeEditorInstance.SourceFolderPath = FolderBrowserDialog.SelectedPath;
            }

            SourceFolderPath.Text = CopyrightNoticeEditorInstance.SourceFolderPath;
        }

        private void ExistingCopyrightNoticeCommentStyle_TextChanged(object sender, EventArgs e)
        {
            CopyrightNoticeEditorInstance.ExistingCopyrightNotice = ExistingCopyrightNotice.Text;
        }

        private void NewCopyrightNoticeComment_TextChanged(object sender, EventArgs e)
        {
            CopyrightNoticeEditorInstance.NewCopyrightNotice = NewCopyrightNotice.Text;
        }

        private void UpdateCopyrightEditorInstanceConfig()
        {
            CopyrightNoticeEditorInstance.SourceFolderPath = SourceFolderPath.Text;
            CopyrightNoticeEditorInstance.ExistingCopyrightNotice = ExistingCopyrightNotice.Text;
            CopyrightNoticeEditorInstance.NewCopyrightNotice = NewCopyrightNotice.Text;
            CopyrightNoticeEditorInstance.bFindExisitingCopyrightNotice = bFindExistingCopyrightNotice.Checked;
            CopyrightNoticeEditorInstance.bAddCopyrightNoticeIfNotFound = bAddCopyrightNoticeIfNotFound.Checked;
            CopyrightNoticeEditorInstance.SupportedFilesExtensions = SupportedFileExtensions.Text;
        }
        
        private void CheckCopyrightEditorInstanceConfig()
        {
            if (string.IsNullOrEmpty(CopyrightNoticeEditorInstance.SourceFolderPath))
            {
                MessageBox.Show("Invalid source code folder path !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!bFindExistingCopyrightNotice.Checked)
            {
                if (string.IsNullOrEmpty(CopyrightNoticeEditorInstance.ExistingCopyrightNotice))
                {
                    MessageBox.Show("Invalid existing copyright notice !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            if (string.IsNullOrEmpty(CopyrightNoticeEditorInstance.NewCopyrightNotice))
            {
                MessageBox.Show("New copyright notice cannot be emtpy !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(CopyrightNoticeEditorInstance.SupportedFilesExtensions))
            {
                MessageBox.Show("Please add at least one supported file extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bFindExistingCopyrightNotice_CheckedChanged(object sender, EventArgs e)
        {
            ExistingCopyrightNotice.Enabled = !bFindExistingCopyrightNotice.Checked;
        }

        private void bAddCopyrightNoticeIfNotFound_CheckedChanged(object sender, EventArgs e)
        {
            CopyrightNoticeEditorInstance.bAddCopyrightNoticeIfNotFound = bAddCopyrightNoticeIfNotFound.Checked;
        }

        private void WorkerThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CopyrightNoticeEditorInstance.ChangeCopyrightNotice();
        }

        private void WorkerThread_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ChangeCopyrightButton.Enabled = true;
            ChangeCopyrightButton.Text = "Change Copyright Notice";

            if (CopyrightNoticeEditorInstance.Errors.Count > 0)
            {
                ErrorsForm errorsForm = new ErrorsForm();

                foreach (var error in CopyrightNoticeEditorInstance.Errors)
                {
                    errorsForm.SetErrors(error);
                }

                errorsForm.ShowDialog();
            }

            MessageBox.Show($"Changed copyright notice on {CopyrightNoticeEditorInstance.UpdatedFilesNumber} file(s).", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SupportedFileExtensions_TextChanged(object sender, EventArgs e)
        {
            CopyrightNoticeEditorInstance.SupportedFilesExtensions = SupportedFileExtensions.Text;
        }
    }
}
