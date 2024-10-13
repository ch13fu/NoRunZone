using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace NoRunZone
{
    public partial class Form1 : Form
    {
        private string selectedFolder = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // Select Folder Button (button3_Click)
        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of FolderBrowserDialog to select a folder
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Set a description for the folder browser
                folderDialog.Description = "Select a folder to manage file execution permissions";

                // Show the folder browser dialog and check if a folder was selected
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the selected folder path
                    selectedFolder = folderDialog.SelectedPath;

                    // Optionally, update a label or message box with the selected folder path
                    MessageBox.Show("Selected folder: " + selectedFolder);
                }
            }
        }

        // Enable Files Button Click (Enable_files_Click)
        private void Enable_files_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFolder))
            {
                MessageBox.Show("Please select a folder first.");
                return;
            }

            try
            {
                // Enable execution permissions on the folder
                SetExecutionPermissions(selectedFolder, true);
                MessageBox.Show("Execution enabled for files in " + selectedFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enabling execution: " + ex.Message);
            }
        }

        // Disable Files Button Click (Disable_files_Click)
        private void Disable_files_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFolder))
            {
                MessageBox.Show("Please select a folder first.");
                return;
            }

            try
            {
                // Disable execution permissions on the folder
                SetExecutionPermissions(selectedFolder, false);
                MessageBox.Show("Execution disabled for files in " + selectedFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disabling execution: " + ex.Message);
            }
        }

        // Method to enable/disable execution permissions on the folder and files
        private void SetExecutionPermissions(string folderPath, bool enableExecution)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);

            // Get the Access Control List (ACL) of the folder
            DirectorySecurity dirSecurity = dirInfo.GetAccessControl();

            // Define the deny rule for execute permissions on the folder
            FileSystemAccessRule denyExecuteRule = new FileSystemAccessRule(
                "Everyone",
                FileSystemRights.ExecuteFile,
                InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None,
                AccessControlType.Deny);

            if (enableExecution)
            {
                // Remove the deny execute rule (allow execution)
                dirSecurity.RemoveAccessRule(denyExecuteRule);
            }
            else
            {
                // Add the deny execute rule (disable execution)
                dirSecurity.AddAccessRule(denyExecuteRule);
            }

            // Apply the modified ACL to the folder and propagate to subdirectories and files
            dirInfo.SetAccessControl(dirSecurity);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
