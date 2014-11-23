namespace thirdlab
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelForGame = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.MonstersTimer = new System.Windows.Forms.Timer(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.скинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForGame
            // 
            this.PanelForGame.BackColor = System.Drawing.Color.Blue;
            this.PanelForGame.Location = new System.Drawing.Point(29, 71);
            this.PanelForGame.Name = "PanelForGame";
            this.PanelForGame.Size = new System.Drawing.Size(500, 500);
            this.PanelForGame.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(609, 71);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(161, 74);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Новая игра";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(70, 30);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 18);
            this.ScoreLabel.TabIndex = 2;
            // 
            // MonstersTimer
            // 
            this.MonstersTimer.Interval = 150;
            this.MonstersTimer.Tick += new System.EventHandler(this.MonstersTimer_Tick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(609, 151);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(161, 74);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Редактировать скин";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скинToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(817, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // скинToolStripMenuItem
            // 
            this.скинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.скинToolStripMenuItem.Name = "скинToolStripMenuItem";
            this.скинToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.скинToolStripMenuItem.Text = "Скин";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 583);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PanelForGame);
            this.Controls.Add(this.menuStrip2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelForGame;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer MonstersTimer;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem скинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

