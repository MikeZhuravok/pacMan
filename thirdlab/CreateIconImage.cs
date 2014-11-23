using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdlab
{
    public partial class CreateIconImage : Form
    {
        Image PacManIcon = Image.FromFile("images/PacMan.png");
        Image CoinIcon = Image.FromFile("images/Coin.png");
        Image WallIcon = Image.FromFile("images/Wall.png");
        Image FirstIcon = Image.FromFile("images/Yellow.png");
        Image SecondIcon = Image.FromFile("images/Green.png");
        Image Yellow = Image.FromFile("images/Yellow.png");
        Image Green = Image.FromFile("images/Green.png");
        Image Red = Image.FromFile("images/Red.png");
        Image RedPlusPlus = Image.FromFile("images/Red++.png");
        int _width;
        public CreateIconImage()
        {
            InitializeComponent();
        }

        private void CoinButton_Click(object sender, EventArgs e)
        {
            if (openCoin.ShowDialog() == DialogResult.OK)
            {
                CoinIcon = Image.FromFile(openCoin.FileName);
                CoinCheckBox.Checked = true;
            }
        }

        private void WallButton_Click(object sender, EventArgs e)
        {
            if (openWall.ShowDialog() == DialogResult.OK)
            {
                WallIcon = Image.FromFile(openWall.FileName);
                WallCheckBox.Checked = true;
            }
        }

        private void HeroButton_Click(object sender, EventArgs e)
        {
            if (openHero.ShowDialog() == DialogResult.OK)
            {
                 PacManIcon = Image.FromFile(openHero.FileName);
                 HeroCheckBox.Checked = true;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _width = int.Parse(widthTextBox.Text);
            int hei = _width / 7;
            Bitmap bmp = new Bitmap(_width, hei);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Герой, монета, забор, йелоу, грин, ред, ред++
                g.DrawImage(PacManIcon, new Rectangle(0, 0, hei, hei));
                g.DrawImage(CoinIcon, new Rectangle(hei, 0, hei, hei));
                g.DrawImage(WallIcon, new Rectangle(2 * hei, 0, hei, hei));
                g.DrawImage(Yellow, new Rectangle(3 * hei, 0, hei, hei));
                g.DrawImage(Green, new Rectangle(4 * hei, 0, hei, hei));
                g.DrawImage(Red, new Rectangle(5 * hei, 0, hei, hei));
                g.DrawImage(RedPlusPlus, new Rectangle(6 * hei, 0, hei, hei));
            }
            saveFileDialog1.Filter = "Изображения (*.bmp)|*.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog1.FileName);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
