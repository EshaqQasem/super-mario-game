using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace marioSobka
{
    enum itemType { wall=0, space=1, box=2, player=3, endPoint=4, boxOnEndPoint=5, PlayerOnEndPoint=6 };
    
    class Item
    {
        Size size;
        Point loc;
        public itemType type;
        public itemType lastType;
        public PictureBox picBox;
        public static Bitmap[] itemImgs = new Bitmap[5]{new Bitmap(@"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\wall.png")
                                                      ,new Bitmap(@"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\space.png")
                                                      ,new Bitmap(@"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\box.png")
                                                      ,new Bitmap(@"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\player.png")
                                                      ,new Bitmap(@"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\endpoint.png")
                                                       };

        public Item (int x,int y,itemType it)
        {
            size = new Size(35,35);
            loc = new Point(x,y);
            type = it;
            lastType = itemType.space;
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.picBox.Location = this.loc;
            this.picBox.Name = "picBox"+x.ToString()+y.ToString();
            this.picBox.Size = this.size;
            this.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
           // this.picBox.BorderStyle = BorderStyle.FixedSingle;
            this.picBox.TabIndex = 18;
            this.picBox.TabStop = false;


           /* switch (it)
            {
                case itemType.wall:
                    img = @"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\wall.png";
                    break;

                case itemType.box:
                    img = @"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\box.png";
                    break;
                case itemType.player:
                    img = @"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\player.png";
                    break;
                case itemType.endPoint:
                    img = @"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\endpoint.png";
                    break;
                case itemType.space:
                    img = @"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\space.png";
                    break;

            }
            //  img = @"C:\Users\DELL\Desktop\VCsharp\projects\marioSobka\marioSobka\bin\Debug\icons\wall2.png";
             */       
            this.picBox.Image = itemImgs[(int)this.type];
    }
    }
}
