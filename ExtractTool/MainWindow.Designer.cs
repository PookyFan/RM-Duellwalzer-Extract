namespace ExtractTool
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GameFilesPathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseForGameFilesButton = new System.Windows.Forms.Button();
            this.LogsTextBox = new System.Windows.Forms.TextBox();
            this.ExtractImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtractTextCheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.BrowseForOutputButton = new System.Windows.Forms.Button();
            this.OutputPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to game files:";
            // 
            // GameFilesPathTextBox
            // 
            this.GameFilesPathTextBox.Location = new System.Drawing.Point(15, 25);
            this.GameFilesPathTextBox.Name = "GameFilesPathTextBox";
            this.GameFilesPathTextBox.Size = new System.Drawing.Size(376, 20);
            this.GameFilesPathTextBox.TabIndex = 1;
            // 
            // BrowseForGameFilesButton
            // 
            this.BrowseForGameFilesButton.Location = new System.Drawing.Point(397, 23);
            this.BrowseForGameFilesButton.Name = "BrowseForGameFilesButton";
            this.BrowseForGameFilesButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseForGameFilesButton.TabIndex = 2;
            this.BrowseForGameFilesButton.Text = "Browse";
            this.BrowseForGameFilesButton.UseVisualStyleBackColor = true;
            this.BrowseForGameFilesButton.Click += new System.EventHandler(this.BrowseForGameFilesButton_Click);
            // 
            // LogsTextBox
            // 
            this.LogsTextBox.Location = new System.Drawing.Point(3, 137);
            this.LogsTextBox.Multiline = true;
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.ReadOnly = true;
            this.LogsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTextBox.Size = new System.Drawing.Size(478, 322);
            this.LogsTextBox.TabIndex = 3;
            // 
            // ExtractImagesCheckBox
            // 
            this.ExtractImagesCheckBox.AutoSize = true;
            this.ExtractImagesCheckBox.Checked = true;
            this.ExtractImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExtractImagesCheckBox.Location = new System.Drawing.Point(61, 106);
            this.ExtractImagesCheckBox.Name = "ExtractImagesCheckBox";
            this.ExtractImagesCheckBox.Size = new System.Drawing.Size(59, 17);
            this.ExtractImagesCheckBox.TabIndex = 4;
            this.ExtractImagesCheckBox.Text = "images";
            this.ExtractImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extract:";
            // 
            // ExtractTextCheckBox
            // 
            this.ExtractTextCheckBox.AutoSize = true;
            this.ExtractTextCheckBox.Enabled = false;
            this.ExtractTextCheckBox.Location = new System.Drawing.Point(126, 106);
            this.ExtractTextCheckBox.Name = "ExtractTextCheckBox";
            this.ExtractTextCheckBox.Size = new System.Drawing.Size(103, 17);
            this.ExtractTextCheckBox.TabIndex = 6;
            this.ExtractTextCheckBox.Text = "text (dialogs etc)";
            this.ExtractTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(397, 96);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 35);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "EXTRACT!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BrowseForOutputButton
            // 
            this.BrowseForOutputButton.Location = new System.Drawing.Point(397, 62);
            this.BrowseForOutputButton.Name = "BrowseForOutputButton";
            this.BrowseForOutputButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseForOutputButton.TabIndex = 10;
            this.BrowseForOutputButton.Text = "Browse";
            this.BrowseForOutputButton.UseVisualStyleBackColor = true;
            this.BrowseForOutputButton.Click += new System.EventHandler(this.BrowseForOutputButton_Click);
            // 
            // OutputPathTextBox
            // 
            this.OutputPathTextBox.Location = new System.Drawing.Point(15, 64);
            this.OutputPathTextBox.Name = "OutputPathTextBox";
            this.OutputPathTextBox.Size = new System.Drawing.Size(376, 20);
            this.OutputPathTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Extract to:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.BrowseForOutputButton);
            this.Controls.Add(this.OutputPathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExtractTextCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExtractImagesCheckBox);
            this.Controls.Add(this.LogsTextBox);
            this.Controls.Add(this.BrowseForGameFilesButton);
            this.Controls.Add(this.GameFilesPathTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "RM Duellwalzer Extract Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GameFilesPathTextBox;
        private System.Windows.Forms.Button BrowseForGameFilesButton;
        private System.Windows.Forms.TextBox LogsTextBox;
        private System.Windows.Forms.CheckBox ExtractImagesCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ExtractTextCheckBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BrowseForOutputButton;
        private System.Windows.Forms.TextBox OutputPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog BrowserDialog;
    }
}

