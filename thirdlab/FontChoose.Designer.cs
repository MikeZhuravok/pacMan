namespace thirdlab
{
    partial class FontChoose
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
            this.FontLabel = new System.Windows.Forms.Label();
            this.fontListBox = new System.Windows.Forms.ListBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.sizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontLabel.Location = new System.Drawing.Point(14, 21);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(57, 18);
            this.FontLabel.TabIndex = 0;
            this.FontLabel.Text = "Шрифт";
            // 
            // fontListBox
            // 
            this.fontListBox.FormattingEnabled = true;
            this.fontListBox.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Consolas",
            "Microsoft Sans Serif",
            "Tahoma",
            "Times New Roman"});
            this.fontListBox.Location = new System.Drawing.Point(116, 22);
            this.fontListBox.Name = "fontListBox";
            this.fontListBox.Size = new System.Drawing.Size(101, 17);
            this.fontListBox.TabIndex = 1;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.Location = new System.Drawing.Point(14, 56);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(61, 18);
            this.SizeLabel.TabIndex = 2;
            this.SizeLabel.Text = "Размер";
            // 
            // sizeUpDown
            // 
            this.sizeUpDown.Location = new System.Drawing.Point(149, 54);
            this.sizeUpDown.Name = "sizeUpDown";
            this.sizeUpDown.Size = new System.Drawing.Size(35, 20);
            this.sizeUpDown.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(54, 92);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 25);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // FontChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 129);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sizeUpDown);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.fontListBox);
            this.Controls.Add(this.FontLabel);
            this.Name = "FontChoose";
            this.Text = "FontChoose";
            ((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.ListBox fontListBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.NumericUpDown sizeUpDown;
        private System.Windows.Forms.Button okButton;
    }
}