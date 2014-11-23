using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdlab.ObjMod
{
    public delegate void PosChangedEventHandler();
    public class Game
    {
        private static Image _defaultImage = Image.FromFile("images/Default.bmp");
        Image PacManIcon = PartOfImage(_defaultImage, new Rectangle(new Point(0, 0), new Size(25, 25)));
        Image CoinIcon = PartOfImage(_defaultImage, new Rectangle(new Point(25, 0), new Size(25, 25)));
        Image WallIcon = PartOfImage(_defaultImage, new Rectangle(new Point(50, 0), new Size(25, 25)));
        public Image FirstIcon = PartOfImage(_defaultImage, new Rectangle(new Point(75, 0), new Size(25, 25)));
        public Image SecondIcon = PartOfImage(_defaultImage, new Rectangle(new Point(100, 0), new Size(25, 25)));
        public Image Yellow = PartOfImage(_defaultImage, new Rectangle(new Point(75, 0), new Size(25, 25)));
        public Image Green = PartOfImage(_defaultImage, new Rectangle(new Point(100, 0), new Size(25, 25)));
        public Image Red = PartOfImage(_defaultImage, new Rectangle(new Point(125, 0), new Size(25, 25)));
        public Image RedPlusPlus = PartOfImage(_defaultImage, new Rectangle(new Point(150, 0), new Size(25, 25)));
        List<Adduction> Monsters;
        internal int[,] Pitch = new int[20, 20]; // 0 - clear, 1 - coin, 2 - wall, 3+ monster (четные - желтые, нечетные - зеленые)
        int[] HeroPosition = new int[2];
        public event PosChangedEventHandler ImageChanged;
        public int currentScore = 0;
        public Bitmap img;
        public int Width = 500;
        public bool canGo = false;

        internal void FillPitch(Graphics g)
        {
            Graphics buff = Graphics.FromImage(img);
            buff.Clear(Color.Blue);
            DrawHero(buff);
            for (int x = 0; x < Pitch.GetLength(0); x++)
                for (int y = 0; y < Pitch.GetLength(1); y++)
                    if (Pitch[x, y] == 1)
                    {
                        DrawIcon(buff, CoinIcon, CreateRect(new int[] { x, y }));
                    }
            for (int x = 0; x < Pitch.GetLength(0); x++)
                for (int y = 0; y < Pitch.GetLength(1); y++)
                    if (Pitch[x, y] == 2)
                    {
                        DrawIcon(buff, WallIcon, CreateRect(new int[] { x, y }));
                    }
            for (int x = 0; x < Pitch.GetLength(0); x++)
                for (int y = 0; y < Pitch.GetLength(1); y++)
                    if (Pitch[x, y] >= 3)
                    {
                        if (Pitch[x, y] % 2 == 0)
                            DrawIcon(buff, FirstIcon, CreateRect(new int[] { x, y }));
                        else
                            DrawIcon(buff, SecondIcon, CreateRect(new int[] { x, y }));
                    }
            g.DrawImageUnscaled(img, 0, 0);
        }

        internal void MakeMove(string direction)
        {
            bool moved = false;
            int[] temp = (int[])HeroPosition.Clone();
            switch (direction)
            {
                case "Up":
                    if (temp[1] > 0)
                    {
                        temp[1]--;
                        moved = true;
                    }
                    break;
                case "Down":
                    if (temp[1] < 19)
                    {
                        temp[1]++;
                        moved = true;
                    }
                    break;
                case "Left":
                    if (temp[0] > 0)
                    {
                        temp[0]--;
                        moved = true;
                    }
                    break;
                case "Right":
                    if (temp[0] < 19)
                    {
                        temp[0]++;
                        moved = true;
                    }
                    break;
            }
            if (moved)
            {
                if (!isWall(temp))
                    HeroPosition = temp;
                if (Pitch[temp[0], temp[1]] == 1)
                {
                    Pitch[temp[0], temp[1]] = 0;
                    currentScore += 1;
                }
                if (ImageChanged != null)
                    ImageChanged();
            }
        }

        internal bool isWall(int[] coords)
        {
            if (Pitch[coords[0], coords[1]] == 2)
                return true;
            return false;
        }

        internal void LevelFirst()
        {
            Pitch[1, 0] = 1;
            CreateGoldWall(1, 1, 3, 7);
            CreateGoldWall(2, 13, 16, 17);
            CreateGoldWall(13, 14, 2, 13);
            Pitch[19, 0] = 1;
            CreateXWall(1, 3, 1);
            CreateXWall(1, 6, 1);
            CreateXWall(1, 3, 2);
            CreateYWall(0, 7, 2);
            CreateXWall(8, 20, 1);
            CreateXWall(1, 3, 7);
            CreateYWall(7, 19, 1);
            CreateXWall(1, 4, 18);
            CreateYWall(16, 19, 4);
            CreateXWall(4, 7, 15);
            CreateYWall(16, 19, 6);
            CreateYWall(16, 19, 9);
            CreateXWall(9, 12, 15);
            CreateYWall(16, 19, 11);
            CreateXWall(7, 9, 18);
            CreateXWall(12, 19, 18);
            CreateYWall(3, 19, 18);
            CreateYWall(2, 14, 16);
            CreateYWall(2, 14, 11);
            CreateAdduction("Down", 5, 16, 19);
            CreateAdduction("Down", 10, 16, 19);
            CreateAdduction("Right", 5, 1, 8);
            CreateAdduction("Down", 0, 3, 6);
            CreateAdduction("Right", 2, 14, 17);
        }

        internal void LevelSecond()
        {
            CreateYWall(0, 3, 1);
        }

        internal void CreateGoldWall(int startX, int endX, int startY, int endY)
        {
            for (int x = startX; x <= endX; x++)
                for (int y = startY; y <= endY; y++)
                    Pitch[x, y] = 1;
        }

        internal void CreateXWall(int start, int end, int y)
        {
            for (int x = start; x < Pitch.GetLength(0) && x < end; x++)
                Pitch[x, y] = 2;
        }

        internal void CreateYWall(int start, int end, int x)
        {
            for (int y = start; y < Pitch.GetLength(0) && y < end; y++)
                Pitch[x, y] = 2;
        }

        internal int[] FindIcon(int value)
        {
            for (int x = 0; x < Pitch.GetLength(0); x++)
                for (int y = 0; y < Pitch.GetLength(1); y++)
                    if (Pitch[x, y] == value)
                        return new int[] { x, y };
            return new int[] { 0, 0 };
        }

        internal void StartGame(Graphics g, string textBox)
        {
            HeroPosition = new int[2] { 0, 0 };
            switch (textBox)
            {   case "1":
                LevelFirst();
                break;
            case "2":
                LevelSecond();
                break;
            case "3":
                LevelThird();
                break;
            case "Случайно-сгенерированный":
                LevelRandom();
                break;
            }
            FillPitch(g);
        }

        private void LevelRandom()
        {
            throw new NotImplementedException();
        }

        private void LevelThird()
        {
            throw new NotImplementedException();
        }


        internal Rectangle CreateRect(int[] coords)
        {
            int wd = Width / 20;
            return new Rectangle(wd * coords[0], wd * coords[1], 25, 25);
        }

        internal void DrawHero(Graphics g)
        {
            DrawIcon(g, PacManIcon, CreateRect(HeroPosition));
        }

        internal void DrawIcon(Graphics g, Image Icon, Rectangle rect)
        {
            g.DrawImage(Icon, rect);
        }

        internal void MoveMonsters()
        {
            foreach (Adduction ad in Monsters)
                ad.MoveAddiction();
        }

        internal void CreateAdduction(string side, int startX, int startY, int end)
        {
            if (Monsters == null)
            {
                Monsters = new List<Adduction>();
            }
            int Number = 3 + Monsters.Count;
            int[] forAdduct = new int[0];
            if (side == "Right" || side == "Left")
            {
                forAdduct = new int[] { startX, end, startX };
            }
            if (side == "Up" || side == "Down")
            {
                forAdduct = new int[] { startY, end, startY };
            }
            Pitch[startX, startY] = Number;
            Monsters.Add(new Adduction(this, side, Number, forAdduct));
        }

        internal bool Check()
        {
            int currentIcon = Pitch[HeroPosition[0], HeroPosition[1]];
            if (currentIcon >= 3 || NoCoinsLeft())
                return false;
            return true;
        }

        private bool NoCoinsLeft()
        {
            for (int x = 0; x < Pitch.GetLength(0); x++)
                for (int y = 0; y < Pitch.GetLength(1); y++)
                    if (Pitch[x, y] == 1)
                        return false;
            return true;
        }

        static private Image PartOfImage(Image srcBitmap, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {

                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }
            return bmp;
        }
    }
}
