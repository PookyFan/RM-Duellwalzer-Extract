namespace BIV
{
    partial class AppWindow
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
            this.ImageBox = new System.Windows.Forms.GroupBox();
            this.ImageControl = new System.Windows.Forms.PictureBox();
            this.ControlsBox = new System.Windows.Forms.GroupBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthNumericControl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightNumericControl = new System.Windows.Forms.NumericUpDown();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.ImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageControl)).BeginInit();
            this.ControlsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Controls.Add(this.ImageControl);
            this.ImageBox.Location = new System.Drawing.Point(12, 12);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(960, 952);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // ImageControl
            // 
            this.ImageControl.Location = new System.Drawing.Point(8, 10);
            this.ImageControl.Name = "ImageControl";
            this.ImageControl.Size = new System.Drawing.Size(948, 925);
            this.ImageControl.TabIndex = 2;
            this.ImageControl.TabStop = false;
            // 
            // ControlsBox
            // 
            this.ControlsBox.Controls.Add(this.ViewButton);
            this.ControlsBox.Controls.Add(this.label1);
            this.ControlsBox.Controls.Add(this.WidthNumericControl);
            this.ControlsBox.Controls.Add(this.label3);
            this.ControlsBox.Controls.Add(this.label2);
            this.ControlsBox.Controls.Add(this.HeightNumericControl);
            this.ControlsBox.Controls.Add(this.FilePathTextBox);
            this.ControlsBox.Location = new System.Drawing.Point(12, 953);
            this.ControlsBox.Name = "ControlsBox";
            this.ControlsBox.Size = new System.Drawing.Size(960, 46);
            this.ControlsBox.TabIndex = 1;
            this.ControlsBox.TabStop = false;
            this.ControlsBox.Text = "Controls";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(897, 17);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(56, 23);
            this.ViewButton.TabIndex = 8;
            this.ViewButton.Text = "VIEW";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File path:";
            // 
            // WidthNumericControl
            // 
            this.WidthNumericControl.Location = new System.Drawing.Point(479, 20);
            this.WidthNumericControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WidthNumericControl.Name = "WidthNumericControl";
            this.WidthNumericControl.Size = new System.Drawing.Size(60, 20);
            this.WidthNumericControl.TabIndex = 3;
            this.WidthNumericControl.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // HeightNumericControl
            // 
            this.HeightNumericControl.Location = new System.Drawing.Point(616, 20);
            this.HeightNumericControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightNumericControl.Name = "HeightNumericControl";
            this.HeightNumericControl.Size = new System.Drawing.Size(60, 20);
            this.HeightNumericControl.TabIndex = 5;
            this.HeightNumericControl.Value = new decimal(new int[] {
            448,
            0,
            0,
            0});
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(61, 19);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(279, 20);
            this.FilePathTextBox.TabIndex = 0;
            // 
            // AppWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 1011);
            this.Controls.Add(this.ControlsBox);
            this.Controls.Add(this.ImageBox);
            this.Name = "AppWindow";
            this.Text = "Binary Image Viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AppWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AppWindow_DragEnter);
            this.ImageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageControl)).EndInit();
            this.ControlsBox.ResumeLayout(false);
            this.ControlsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ImageBox;
        private System.Windows.Forms.GroupBox ControlsBox;
        private System.Windows.Forms.NumericUpDown HeightNumericControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WidthNumericControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.PictureBox ImageControl;
    }
}

