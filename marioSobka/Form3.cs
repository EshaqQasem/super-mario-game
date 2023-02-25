using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace marioSobka
{

   

    public partial class Form3 : Form
    {
        public Form3(Level cl)
        {
            InitializeComponent();
            this.currentLevel = cl;
            string path = Directory.GetCurrentDirectory() + "\\levels\\" + currentLevel.levelType + "\\" + currentLevel.Name + ".txt";
            cout = new Cout(path);
        }
        Level currentLevel;
        // string path;
         Cout cout ;
        private void Form3_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                    this.Controls.Add(cout.items[i,j].picBox);
            }

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            Point obj = new Point(cout.playerLoc.X, cout.playerLoc.Y);
            int x = 0, y = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    x+=1;
                    break;
                case Keys.Left:
                    x-= 1;
                    break;
                case Keys.Up:
                    y-= 1;
                    break;
                case Keys.Down:
                    y+= 1;

                   
                    break;
            }
            if (cout.items[obj.Y + y, obj.X +x ].type == itemType.space|| cout.items[obj.Y + y, obj.X +x ].type == itemType.endPoint )
            {
               //MessageBox.Show(" ");

                cout.items[obj.Y, obj.X].picBox.Image = Item.itemImgs[(int)cout.items[obj.Y, obj.X].lastType];
                cout.items[obj.Y, obj.X].type = cout.items[obj.Y, obj.X].lastType;
               /* cout.items[obj.Y, obj.X].picBox.Image = (cout.items[obj.Y, obj.X].type == itemType.player) ? Item.itemImgs[(int)itemType.space] : Item.itemImgs[(int)itemType.endPoint];
                cout.items[obj.Y, obj.X].type = cout.items[obj.Y, obj.X].type==itemType.player ? itemType.space:itemType.endPoint;

                cout.items[obj.Y + y, obj.X + x].picBox.Image = Item.itemImgs[(int)itemType.player];
                cout.items[obj.Y+y, obj.X+x].type = (cout.items[obj.Y + y, obj.X +x ].type == itemType.space) ? itemType.player : itemType.PlayerOnEndPoint;
              */
               cout.items[obj.Y + y, obj.X + x].picBox.Image = Item.itemImgs[(int) itemType.player];
                cout.items[obj.Y+y, obj.X+x].lastType = cout.items[obj.Y+y, obj.X+x].type;
                cout.items[obj.Y+y, obj.X+x].type = itemType.player;
                cout.playerLoc = new Point(obj.X+x,obj.Y+y);
            }
            
            else if (cout.items[obj.Y + y, obj.X + x].type == itemType.box && cout.items[obj.Y + y + y, obj.X + x + x].type != itemType.wall)
            {
                cout.items[obj.Y, obj.X].picBox.Image = Item.itemImgs[(int)cout.items[obj.Y, obj.X].lastType];
                cout.items[obj.Y, obj.X].type = cout.items[obj.Y, obj.X].lastType;

                cout.items[obj.Y + y, obj.X + x].picBox.Image = Item.itemImgs[(int)itemType.player];
                if (cout.items[obj.Y + y, obj.X + x ].lastType == itemType.endPoint)
                {
                    cout.endPontNums++;
                }
                cout.items[obj.Y + y, obj.X + x].type = itemType.player;

                cout.items[obj.Y + y + y, obj.X + x + x].picBox.Image = Item.itemImgs[(int)itemType.box];
                cout.items[obj.Y + y + y, obj.X + x + x].lastType = cout.items[obj.Y + y + y, obj.X + x + x].type;



                if (cout.items[obj.Y + y , obj.X + x + x].type == itemType.endPoint)
                {
                    cout.endPontNums--;
                }

                 cout.items[obj.Y + y + y, obj.X + x + x].type = itemType.box;
                /*
                cout.items[obj.Y, obj.X].picBox.Image = Item.itemImgs[(int)itemType.space];
                cout.items[obj.Y, obj.X].type = itemType.space;

                cout.items[obj.Y + y, obj.X + x].picBox.Image = Item.itemImgs[(int)itemType.player];
                cout.items[obj.Y + y, obj.X + x].type = itemType.player;


                cout.items[obj.Y + y + y, obj.X + x + x].picBox.Image = Item.itemImgs[(int)itemType.box];
                cout.items[obj.Y + y + y, obj.X + x + x].type = itemType.box;
                */

                cout.playerLoc = new Point(obj.X + x, obj.Y + y);

                if (cout.endPontNums == 0)
                {
                    MessageBox.Show("لقد فزت !");
                    this.Close();
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
