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
            this.lvlChoosingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.StartButton.Location = new System.Drawing.Point(614, 148);
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
            // lvlChoosingComboBox
            // 
            this.lvlChoosingComboBox.FormattingEnabled = true;
            this.lvlChoosingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "Случайно-сгенерированный"});
            this.lvlChoosingComboBox.Location = new System.Drawing.Point(614, 95);
            this.lvlChoosingComboBox.Name = "lvlChoosingComboBox";
            this.lvlChoosingComboBox.Size = new System.Drawing.Size(161, 21);
            this.lvlChoosingComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите уровень";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvlChoosingComboBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PanelForGame);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(833, 621);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelForGame;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer MonstersTimer;
        private System.Windows.Forms.ComboBox lvlChoosingComboBox;
        private System.Windows.Forms.Label label1;
    }
}

