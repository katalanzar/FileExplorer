namespace FileExplorer
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCreation = new System.Windows.Forms.Label();
            this.lblAccess = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.cmbDrives2 = new System.Windows.Forms.ComboBox();
            this.lstDir = new System.Windows.Forms.ListBox();
            this.lstDir2 = new System.Windows.Forms.ListBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lstFiles2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.txtAccess);
            this.groupBox1.Controls.Add(this.txtCreated);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.lblAccess);
            this.groupBox1.Controls.Add(this.lblCreation);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(548, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 609);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSize.Location = new System.Drawing.Point(7, 41);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(83, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "File Size:";
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreation.Location = new System.Drawing.Point(7, 91);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(78, 20);
            this.lblCreation.TabIndex = 1;
            this.lblCreation.Text = "Created:";
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccess.Location = new System.Drawing.Point(7, 141);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(112, 20);
            this.lblAccess.TabIndex = 2;
            this.lblAccess.Text = "Last Access:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPath.Location = new System.Drawing.Point(7, 191);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(85, 20);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Full Path:";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSize.Location = new System.Drawing.Point(134, 40);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(333, 26);
            this.txtSize.TabIndex = 4;
            // 
            // txtCreated
            // 
            this.txtCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCreated.Location = new System.Drawing.Point(134, 85);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.Size = new System.Drawing.Size(333, 26);
            this.txtCreated.TabIndex = 5;
            // 
            // txtAccess
            // 
            this.txtAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccess.Location = new System.Drawing.Point(134, 135);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(333, 26);
            this.txtAccess.TabIndex = 6;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPath.Location = new System.Drawing.Point(134, 185);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(333, 26);
            this.txtPath.TabIndex = 7;
            // 
            // cmbDrives
            // 
            this.cmbDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(41, 39);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(209, 28);
            this.cmbDrives.TabIndex = 1;
            this.cmbDrives.SelectedIndexChanged += new System.EventHandler(this.cmbDrives_SelectedIndexChanged);
            // 
            // cmbDrives2
            // 
            this.cmbDrives2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDrives2.FormattingEnabled = true;
            this.cmbDrives2.Location = new System.Drawing.Point(320, 39);
            this.cmbDrives2.Name = "cmbDrives2";
            this.cmbDrives2.Size = new System.Drawing.Size(209, 28);
            this.cmbDrives2.TabIndex = 2;
            // 
            // lstDir
            // 
            this.lstDir.FormattingEnabled = true;
            this.lstDir.Location = new System.Drawing.Point(41, 88);
            this.lstDir.Name = "lstDir";
            this.lstDir.Size = new System.Drawing.Size(209, 225);
            this.lstDir.TabIndex = 3;
            this.lstDir.DoubleClick += new System.EventHandler(this.lstDir_DoubleClick);
            // 
            // lstDir2
            // 
            this.lstDir2.FormattingEnabled = true;
            this.lstDir2.Location = new System.Drawing.Point(320, 88);
            this.lstDir2.Name = "lstDir2";
            this.lstDir2.Size = new System.Drawing.Size(209, 225);
            this.lstDir2.TabIndex = 4;
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(41, 337);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(209, 225);
            this.lstFiles.TabIndex = 5;
            this.lstFiles.Click += new System.EventHandler(this.lstFiles_Click);
            // 
            // lstFiles2
            // 
            this.lstFiles2.FormattingEnabled = true;
            this.lstFiles2.Location = new System.Drawing.Point(320, 337);
            this.lstFiles2.Name = "lstFiles2";
            this.lstFiles2.Size = new System.Drawing.Size(209, 225);
            this.lstFiles2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 609);
            this.Controls.Add(this.lstFiles2);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lstDir2);
            this.Controls.Add(this.lstDir);
            this.Controls.Add(this.cmbDrives2);
            this.Controls.Add(this.cmbDrives);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.TextBox txtCreated;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Label lblCreation;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.ComboBox cmbDrives2;
        private System.Windows.Forms.ListBox lstDir;
        private System.Windows.Forms.ListBox lstDir2;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.ListBox lstFiles2;
    }
}

