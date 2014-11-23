using thirdlab.ObjMod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdlab
{
    public partial class Form1 : Form
    {
        public Game game; 
        public Form1()
        {
            InitializeComponent();
            lvlChoosingComboBox.Text = "1";
        }

        public void RefreshImage()
        {
            if (game != null)
            {
                Graphics g = PanelForGame.CreateGraphics();
                game.FillPitch(g);
                ScoreLabel.Text = "Текущий счет " + game.currentScore.ToString();
                if (!game.Check())
                    GameIsOver();
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.img = new Bitmap(PanelForGame.ClientSize.Width, PanelForGame.ClientSize.Height);
            game.ImageChanged += RefreshImage;
            Graphics g = PanelForGame.CreateGraphics();
            game.StartGame(g, lvlChoosingComboBox.Text);
            MonstersTimer.Start();
        }

        public void GameIsOver()
        {
            MonstersTimer.Stop();
            MessageBox.Show("Игра окончена, Ваш счет " + game.currentScore.ToString());
            game = null;
            PanelForGame.CreateGraphics().Clear(Color.Blue);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (game != null && game.canGo)
            {
                if (e.KeyData == Keys.Up || e.KeyData == Keys.W)
                {
                    game.MakeMove("Up");
                }
                if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
                {
                    game.MakeMove("Left");
                }
                if (e.KeyData == Keys.Down || e.KeyData == Keys.S)
                {
                    game.MakeMove("Down");
                }
                if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
                {
                    game.MakeMove("Right");
                }
                if (game != null)
                    game.canGo = false;
            }
        }

        private void MonstersTimer_Tick(object sender, EventArgs e)
        {
            game.MoveMonsters();
            RefreshImage();
            if (game != null)
                if (!game.canGo)
                    game.canGo = true;
        }

        internal Image Switcher(string variant)
        {
            switch (variant)
            { 
                case "Зелёный":
                    return game.Green;
                case "Красный":
                    return game.Red;
                case "Тёмно-красный":
                    return game.RedPlusPlus;
                case "Жёлтый":
                    return game.Yellow;
            }
            return null;
        }   
    }
}
