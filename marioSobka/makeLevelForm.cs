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
    public partial class makeLevelForm : Form
    {
       
        public makeLevelForm()
        {
            InitializeComponent();

            path =Application.StartupPath+"\\startlevel.txt";
            cout = new Cout(path);

          /*  this.pictureBox = new PictureBox[15];

            for (int i = 0; i < 15; i++)
            {
                this.pictureBox[i] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox[i])).BeginInit();

                // 
                // pictureBox1
                // 
                this.pictureBox[i].Location = new System.Drawing.Point(i % 10 * 35, i / 10 * 35);
                this.pictureBox[i].Name = "pictureBox1";
                this.pictureBox[i].Size = new System.Drawing.Size(35, 35);
                this.pictureBox[i].BorderStyle = BorderStyle.FixedSingle;
                this.pictureBox[i].TabIndex = i;
                this.pictureBox[i].TabStop = false;
                this.Controls.Add(this.pictureBox[i]);
            }
           * */
        }


        string path;
        Cout cout;
        int[,] temp = new int[12, 12];
        private void makeLevelsForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 12; j++)
                {
                    cout.items[i, j].picBox.Click += new EventHandler(this.picBox_Click);
                    this.Controls.Add(cout.items[i, j].picBox);
                    temp[i,j] = (int)itemType.wall;
                }
            }

        }
        int flag = 0;
        private void makeLevelForm_MouseClick(object sender, MouseEventArgs e)
        {
          /*  int x= e.X % 35;
            int y= e.Y % 35;
            flag = (flag +1) %4;
            cout.items[y, x].picBox.Image = Item.itemImgs[flag];
            temp[y, x] = flag;
           * */
        }

        private void makeLevelForm_Click(object sender, EventArgs e)
        {
            
        }

        int endPointNums = 0;
        int playerNums = 0;
        private void picBox_Click(object sender, EventArgs e)
        {
            int x=((PictureBox)sender).Location.X /35;
            int y = ((PictureBox)sender).Location.Y /35;

            if (temp[y, x] == (int)itemType.endPoint)
                endPointNums--;
            if (temp[y, x] == (int)itemType.box)
                endPointNums++;
            if (temp[y, x] == (int)itemType.player)
                playerNums--;

            temp[y,x] = (temp[y,x] + 1) % 5;
            ((PictureBox)sender).Image = Item.itemImgs[ temp[y,x] ];

            if (temp[y, x] == (int)itemType.endPoint)
                endPointNums++;
            if (temp[y, x] == (int)itemType.box)
                endPointNums--;
            if (temp[y, x] == (int)itemType.player)
                playerNums++;

            //temp[y, x] = flag;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (playerNums == 0)
                MessageBox.Show("يجب ان يكون هنالك لا عب على الاقل !");
            else if(playerNums>1)
                MessageBox.Show("يجب ان يكون هنالك لا عب واحد فقط");
            else if (endPointNums != 0)
                MessageBox.Show("يجب ان يكون هنالك عدد صناديق مساو لعدد النقاط");
            else
            {
                StreamWriter newLevel = new StreamWriter(Directory.GetCurrentDirectory() + "\\levels\\level02.txt");
                for (int i = 0; i < Cout.itemNumsInVer; i++)
                {
                    for (int j = 0; j < Cout.itemNumsInHor; j++)
                    {
                        newLevel.Write(temp[i, j].ToString());
                    }
                    newLevel.Write("\r\n");
                }
                newLevel.Close();
            }
        }

    }

}
