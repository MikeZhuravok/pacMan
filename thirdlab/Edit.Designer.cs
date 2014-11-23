namespace thirdlab
{
    partial class Edit
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
            this.components = new System.ComponentModel.Container();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.OnlyFont = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartButton = new System.Windows.Forms.Button();
            this.PanelForGame = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.скинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пришельцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветПришельцевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьИконкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FontAndSize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.шрифтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizePlus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.размерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OnlyFont.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FontAndSize.SuspendLayout();
            this.SizePlus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(90, 33);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(147, 18);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Отображение счета";
            this.ScoreLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScoreLabel_MouseDown);
            this.ScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScoreLabel_MouseMove);
            this.ScoreLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScoreLabel_MouseUp);
            // 
            // OnlyFont
            // 
            this.OnlyFont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem});
            this.OnlyFont.Name = "contextMenuStrip1";
            this.OnlyFont.Size = new System.Drawing.Size(123, 26);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт...";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(658, 115);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(161, 74);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Новая игра";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.StartButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            this.StartButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // PanelForGame
            // 
            this.PanelForGame.BackColor = System.Drawing.Color.Blue;
            this.PanelForGame.Location = new System.Drawing.Point(55, 64);
            this.PanelForGame.Name = "PanelForGame";
            this.PanelForGame.Size = new System.Drawing.Size(500, 500);
            this.PanelForGame.TabIndex = 3;
            this.PanelForGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelForGame_MouseDown);
            this.PanelForGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelForGame_MouseMove);
            this.PanelForGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelForGame_MouseUp);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(658, 195);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(161, 74);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Редактировать скин";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.EditButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            this.EditButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скинToolStripMenuItem,
            this.пришельцыToolStripMenuItem,
            this.дополнительноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // скинToolStripMenuItem
            // 
            this.скинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.скинToolStripMenuItem.Name = "скинToolStripMenuItem";
            this.скинToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.скинToolStripMenuItem.Text = "Скин";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // пришельцыToolStripMenuItem
            // 
            this.пришельцыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветПришельцевToolStripMenuItem});
            this.пришельцыToolStripMenuItem.Name = "пришельцыToolStripMenuItem";
            this.пришельцыToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.пришельцыToolStripMenuItem.Text = "Пришельцы";
            // 
            // цветПришельцевToolStripMenuItem
            // 
            this.цветПришельцевToolStripMenuItem.Name = "цветПришельцевToolStripMenuItem";
            this.цветПришельцевToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.цветПришельцевToolStripMenuItem.Text = "Цвет пришельцев";
            this.цветПришельцевToolStripMenuItem.Click += new System.EventHandler(this.цветПришельцевToolStripMenuItem_Click);
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьИконкиToolStripMenuItem});
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // создатьИконкиToolStripMenuItem
            // 
            this.создатьИконкиToolStripMenuItem.Name = "создатьИконкиToolStripMenuItem";
            this.создатьИконкиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.создатьИконкиToolStripMenuItem.Text = "Создать иконки";
            this.создатьИконкиToolStripMenuItem.Click += new System.EventHandler(this.создатьИконкиToolStripMenuItem_Click);
            // 
            // FontAndSize
            // 
            this.FontAndSize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem1,
            this.размерToolStripMenuItem});
            this.FontAndSize.Name = "contextMenuStrip2";
            this.FontAndSize.Size = new System.Drawing.Size(124, 48);
            // 
            // шрифтToolStripMenuItem1
            // 
            this.шрифтToolStripMenuItem1.Name = "шрифтToolStripMenuItem1";
            this.шрифтToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.шрифтToolStripMenuItem1.Text = "Шрифт...";
            this.шрифтToolStripMenuItem1.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.размерToolStripMenuItem.Text = "Размер...";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // SizePlus
            // 
            this.SizePlus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерToolStripMenuItem1});
            this.SizePlus.Name = "FontPlus";
            this.SizePlus.Size = new System.Drawing.Size(153, 48);
            // 
            // размерToolStripMenuItem1
            // 
            this.размерToolStripMenuItem1.Name = "размерToolStripMenuItem1";
            this.размерToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.размерToolStripMenuItem1.Text = "Размер...";
            this.размерToolStripMenuItem1.Click += new System.EventHandler(this.размерToolStripMenuItem1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 601);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PanelForGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Edit";
            this.Text = "Edit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Edit_MouseDown);
            this.OnlyFont.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FontAndSize.ResumeLayout(false);
            this.SizePlus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel PanelForGame;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem скинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip OnlyFont;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пришельцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветПришельцевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьИконкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FontAndSize;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SizePlus;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem1;

    }
}