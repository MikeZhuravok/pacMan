namespace thirdlab
{
    partial class CreateIconImage
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
            this.openWall = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.WallButton = new System.Windows.Forms.Button();
            this.CoinButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HeroButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openCoin = new System.Windows.Forms.OpenFileDialog();
            this.openHero = new System.Windows.Forms.OpenFileDialog();
            this.WallCheckBox = new System.Windows.Forms.CheckBox();
            this.CoinCheckBox = new System.Windows.Forms.CheckBox();
            this.HeroCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openWall
            // 
            this.openWall.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забор";
            // 
            // WallButton
            // 
            this.WallButton.Location = new System.Drawing.Point(120, 73);
            this.WallButton.Name = "WallButton";
            this.WallButton.Size = new System.Drawing.Size(80, 30);
            this.WallButton.TabIndex = 1;
            this.WallButton.Text = "Обзор...";
            this.WallButton.UseVisualStyleBackColor = true;
            this.WallButton.Click += new System.EventHandler(this.WallButton_Click);
            // 
            // CoinButton
            // 
            this.CoinButton.Location = new System.Drawing.Point(120, 115);
            this.CoinButton.Name = "CoinButton";
            this.CoinButton.Size = new System.Drawing.Size(80, 30);
            this.CoinButton.TabIndex = 2;
            this.CoinButton.Text = "Обзор...";
            this.CoinButton.UseVisualStyleBackColor = true;
            this.CoinButton.Click += new System.EventHandler(this.CoinButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Монетка";
            // 
            // HeroButton
            // 
            this.HeroButton.Location = new System.Drawing.Point(120, 160);
            this.HeroButton.Name = "HeroButton";
            this.HeroButton.Size = new System.Drawing.Size(80, 30);
            this.HeroButton.TabIndex = 4;
            this.HeroButton.Text = "Обзор...";
            this.HeroButton.UseVisualStyleBackColor = true;
            this.HeroButton.Click += new System.EventHandler(this.HeroButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Герой";
            // 
            // openCoin
            // 
            this.openCoin.FileName = "openFileDialog1";
            // 
            // openHero
            // 
            this.openHero.FileName = "openFileDialog2";
            // 
            // WallCheckBox
            // 
            this.WallCheckBox.AutoCheck = false;
            this.WallCheckBox.AutoSize = true;
            this.WallCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WallCheckBox.Location = new System.Drawing.Point(233, 76);
            this.WallCheckBox.Name = "WallCheckBox";
            this.WallCheckBox.Size = new System.Drawing.Size(15, 14);
            this.WallCheckBox.TabIndex = 6;
            this.WallCheckBox.UseVisualStyleBackColor = true;
            // 
            // CoinCheckBox
            // 
            this.CoinCheckBox.AutoCheck = false;
            this.CoinCheckBox.AutoSize = true;
            this.CoinCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CoinCheckBox.Location = new System.Drawing.Point(233, 124);
            this.CoinCheckBox.Name = "CoinCheckBox";
            this.CoinCheckBox.Size = new System.Drawing.Size(15, 14);
            this.CoinCheckBox.TabIndex = 7;
            this.CoinCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeroCheckBox
            // 
            this.HeroCheckBox.AutoCheck = false;
            this.HeroCheckBox.AutoSize = true;
            this.HeroCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HeroCheckBox.Location = new System.Drawing.Point(233, 169);
            this.HeroCheckBox.Name = "HeroCheckBox";
            this.HeroCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HeroCheckBox.TabIndex = 8;
            this.HeroCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ширина поля";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(158, 30);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(90, 20);
            this.widthTextBox.TabIndex = 10;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(93, 209);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(107, 36);
            this.OkButton.TabIndex = 11;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CreateIconImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 267);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeroCheckBox);
            this.Controls.Add(this.CoinCheckBox);
            this.Controls.Add(this.WallCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeroButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoinButton);
            this.Controls.Add(this.WallButton);
            this.Controls.Add(this.label1);
            this.Name = "CreateIconImage";
            this.Text = "CreateIconImage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openWall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WallButton;
        private System.Windows.Forms.Button CoinButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HeroButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openCoin;
        private System.Windows.Forms.OpenFileDialog openHero;
        private System.Windows.Forms.CheckBox WallCheckBox;
        private System.Windows.Forms.CheckBox CoinCheckBox;
        private System.Windows.Forms.CheckBox HeroCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}