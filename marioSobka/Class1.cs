using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace marioSobka
{


    class Player
    {

    }

    class Cout
    {

        public static int itemNumsInHor = 12;
        public static int itemNumsInVer = 12;
        public Item[,] items;//= new itemType[12, 12];
        //Player player;
        public Point playerLoc;
        public int endPontNums;

        
        public Cout(string levelPath)
        {
            endPontNums = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(levelPath);
            items = new Item[12, 12];
            for (int i = 0; i < 12; i++)
            {
                //items[i] = new Item[12];
                string line = file.ReadLine();
                for (int j = 0; j < 12; j++)
                {
                    int c = line[j] - 48;
                    if( (itemType)c == itemType.player )
                    {
                        playerLoc = new Point(j,i); 
                    }
                    if ((itemType)c == itemType.endPoint)
                    {
                        endPontNums++;
                    }

                    this.items[i, j] = new Item(j * 35, i * 35, (itemType)c);
                }

                
            }

        
            file.Close();


        }

        public void movePlayer()
        {
        }

    }
}
