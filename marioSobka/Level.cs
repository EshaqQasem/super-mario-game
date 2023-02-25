using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace marioSobka
{
   // enum LevelType { easy, midium, hard };
    public class Level
    {
        public bool State;
        public String Name;
        public string levelType;
        public levelVeiw veiw;
        public Level(String n, bool s,string t)
        {
            this.Name = n;
            this.State = s;
            this.levelType = t;

            veiw = new levelVeiw();
            veiw.label1.Text = this.Name;
            veiw.Click += hi;
            if (this.State)
            {
            }
        }

        public void openLevel()
        {
            StreamWriter info = new StreamWriter(Directory.GetCurrentDirectory() + "\\levels\\" + this.levelType + "\\info.txt",true);

            info.Close();
  
        }
        public void hi(object s, EventArgs e)
        {
           veiw.Tag = Name;
          // MessageBox.Show("");
        }
    }
}
