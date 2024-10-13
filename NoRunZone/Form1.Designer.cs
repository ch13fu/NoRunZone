namespace NoRunZone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Disable_files = new Button();
            Enable_files = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SelectFolder = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Disable_files
            // 
            Disable_files.FlatStyle = FlatStyle.Flat;
            Disable_files.ForeColor = Color.Red;
            Disable_files.Location = new Point(560, 384);
            Disable_files.Name = "Disable_files";
            Disable_files.Size = new Size(150, 46);
            Disable_files.TabIndex = 0;
            Disable_files.Text = "DISABLE";
            Disable_files.UseVisualStyleBackColor = true;
            Disable_files.Click += Disable_files_Click;
            // 
            // Enable_files
            // 
            Enable_files.FlatStyle = FlatStyle.Flat;
            Enable_files.ForeColor = Color.YellowGreen;
            Enable_files.Location = new Point(560, 495);
            Enable_files.Name = "Enable_files";
            Enable_files.Size = new Size(150, 46);
            Enable_files.TabIndex = 1;
            Enable_files.Text = "ENABLE";
            Enable_files.UseVisualStyleBackColor = true;
            Enable_files.Click += Enable_files_Click;
            // 
            // SelectFolder
            // 
            SelectFolder.BackColor = Color.White;
            SelectFolder.FlatStyle = FlatStyle.Flat;
            SelectFolder.Location = new Point(497, 271);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(213, 54);
            SelectFolder.TabIndex = 2;
            SelectFolder.Text = "Select Folder";
            SelectFolder.UseVisualStyleBackColor = false;
            SelectFolder.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(709, 148);
            label1.TabIndex = 3;
            label1.Text = "This application allows you to select a folder and modify \r\nits permissions so that all contents remain visible, but \r\nany executable (.exe) files within the folder will not be \r\nable to run";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 190);
            label2.Name = "label2";
            label2.Size = new Size(674, 32);
            label2.TabIndex = 4;
            label2.Text = "------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 239);
            label3.Name = "label3";
            label3.Size = new Size(449, 74);
            label3.TabIndex = 5;
            label3.Text = "Step one:\r\nSelect the folder you wish to modify\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 356);
            label4.Name = "label4";
            label4.Size = new Size(436, 111);
            label4.TabIndex = 6;
            label4.Text = "Step two:\r\nDisable Execution inside the folder\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 467);
            label5.Name = "label5";
            label5.Size = new Size(497, 74);
            label5.TabIndex = 7;
            label5.Text = "Note: \r\nTo allow files to run again, click Enable.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(84, 603);
            label6.Name = "label6";
            label6.Size = new Size(555, 64);
            label6.TabIndex = 8;
            label6.Text = "Warning: Avoid running this on system folders. \r\nI am not responsible for any issues if you do\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(758, 738);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SelectFolder);
            Controls.Add(Enable_files);
            Controls.Add(Disable_files);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "NoRunZone - Made by Chiefu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Disable_files;
        private Button Enable_files;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button SelectFolder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
