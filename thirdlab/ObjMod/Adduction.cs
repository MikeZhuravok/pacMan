using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdlab.ObjMod
{
    public class Adduction
    {
        Game game;
        public string Side; // Вверх или вниз и вправо или влево
        public int[] ChngPts; // Начало хода, конец хода, текущая координата.
        public int Number; // Индивидуальный номер призрака


        public Adduction(Game g, string sd, int number, int[] points)
        {
            game = g;
            Number = number;
            Side = sd;
            ChngPts = points;
        }

        public void MoveAddiction()
        { 
            int[] coords = game.FindIcon(Number);
            game.Pitch[coords[0], coords[1]] = 0;
            switch (Side)
            {
                case "Up":
                    if (ChngPts[0] == ChngPts[2])
                    {
                        Side = "Down";
                        ChngPts[2]++;
                    }
                    ChngPts[2]--;
                    game.Pitch[coords[0], ChngPts[2]] = Number;
                    break;
                case "Down":
                    if (ChngPts[1] == ChngPts[2])
                    {
                        Side = "Up";
                        ChngPts[2]--;
                    }
                    ChngPts[2]++;
                    game.Pitch[coords[0], ChngPts[2]] = Number;
                    break;
                case "Right":
                    if (ChngPts[1] == ChngPts[2])
                    {
                        Side = "Left";
                        ChngPts[2]--;
                    }
                    ChngPts[2]++;
                    game.Pitch[ChngPts[2], coords[1]] = Number;
                    break;
                case "Left":
                    if (ChngPts[0] == ChngPts[2])
                    {
                        Side = "Right";
                        ChngPts[2]++;
                    }
                    ChngPts[2]--;
                    game.Pitch[ChngPts[2], coords[1]] = Number;
                    break;   
            }
        }
    }
}
