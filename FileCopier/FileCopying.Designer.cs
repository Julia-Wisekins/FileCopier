
namespace FileCopier
{
    partial class FileCopying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileCopying));
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.btnOutputFolderLocation = new System.Windows.Forms.Button();
            this.txtInputDirectory = new System.Windows.Forms.TextBox();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.dgvInputOutputDisplay = new System.Windows.Forms.DataGridView();
            this.colComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStartCopying = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputOutputDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Location = new System.Drawing.Point(223, 219);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(95, 23);
            this.btnFolderBrowser.TabIndex = 1;
            this.btnFolderBrowser.Text = "Input Directory";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // btnOutputFolderLocation
            // 
            this.btnOutputFolderLocation.Location = new System.Drawing.Point(544, 219);
            this.btnOutputFolderLocation.Name = "btnOutputFolderLocation";
            this.btnOutputFolderLocation.Size = new System.Drawing.Size(102, 23);
            this.btnOutputFolderLocation.TabIndex = 3;
            this.btnOutputFolderLocation.Text = "Output Location";
            this.btnOutputFolderLocation.UseVisualStyleBackColor = true;
            this.btnOutputFolderLocation.Click += new System.EventHandler(this.btnOutputFolderLocation_Click);
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Location = new System.Drawing.Point(12, 218);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.ReadOnly = true;
            this.txtInputDirectory.Size = new System.Drawing.Size(207, 23);
            this.txtInputDirectory.TabIndex = 0;
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(331, 218);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.ReadOnly = true;
            this.txtOutputDirectory.Size = new System.Drawing.Size(207, 23);
            this.txtOutputDirectory.TabIndex = 2;
            // 
            // dgvInputOutputDisplay
            // 
            this.dgvInputOutputDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputOutputDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colComplete,
            this.colInput,
            this.colOutput});
            this.dgvInputOutputDisplay.Location = new System.Drawing.Point(10, 27);
            this.dgvInputOutputDisplay.Name = "dgvInputOutputDisplay";
            this.dgvInputOutputDisplay.RowTemplate.Height = 25;
            this.dgvInputOutputDisplay.Size = new System.Drawing.Size(636, 185);
            this.dgvInputOutputDisplay.TabIndex = 5;
            // 
            // colComplete
            // 
            this.colComplete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colComplete.HeaderText = "Complete";
            this.colComplete.Name = "colComplete";
            this.colComplete.ReadOnly = true;
            this.colComplete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colComplete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colComplete.Width = 75;
            // 
            // colInput
            // 
            this.colInput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput.HeaderText = "Input";
            this.colInput.Name = "colInput";
            this.colInput.ReadOnly = true;
            this.colInput.Width = 260;
            // 
            // colOutput
            // 
            this.colOutput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOutput.HeaderText = "Output";
            this.colOutput.Name = "colOutput";
            this.colOutput.ReadOnly = true;
            this.colOutput.Width = 258;
            // 
            // btnStartCopying
            // 
            this.btnStartCopying.Location = new System.Drawing.Point(10, 248);
            this.btnStartCopying.Name = "btnStartCopying";
            this.btnStartCopying.Size = new System.Drawing.Size(636, 26);
            this.btnStartCopying.TabIndex = 4;
            this.btnStartCopying.Text = "Start";
            this.btnStartCopying.UseVisualStyleBackColor = true;
            this.btnStartCopying.Click += new System.EventHandler(this.btnStartCopying_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.AutoSize = true;
            this.lbFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFiles.Location = new System.Drawing.Point(12, 9);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(72, 15);
            this.lbFiles.TabIndex = 6;
            this.lbFiles.Text = "Files Copied";
            // 
            // FileCopying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 286);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnStartCopying);
            this.Controls.Add(this.dgvInputOutputDisplay);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.txtInputDirectory);
            this.Controls.Add(this.btnOutputFolderLocation);
            this.Controls.Add(this.btnFolderBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileCopying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Copying Test test";
            this.Load += new System.EventHandler(this.FileCopyingTest_test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputOutputDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Button btnOutputFolderLocation;
        private System.Windows.Forms.TextBox txtInputDirectory;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.DataGridView dgvInputOutputDisplay;
        private System.Windows.Forms.Button btnStartCopying;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutput;
        private System.Windows.Forms.Label lbFiles;
    }
}

