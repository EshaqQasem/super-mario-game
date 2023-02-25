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
    public partial class levelsMenuForm : Form
    {
        public levelsMenuForm(mainForm pf)
        {
            InitializeComponent();
            parentForm = pf;
        }
        mainForm parentForm;
        private void levelsMenuForm_Load(object sender, EventArgs e)
        {

        }
        Level []levels;
        private void button1_Click(object sender, EventArgs e)
        {
            listLevels("easy");
            
        }

        private void listLevels(string t)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            this.lblTitel.Text = t + " levels";
            StreamReader info = new StreamReader(Directory.GetCurrentDirectory() + "\\levels\\"+t+"\\info.txt");
            int levelNums = Convert.ToInt32(info.ReadLine());
            int openedLevelNums = Convert.ToInt32(info.ReadLine());
            levels = new Level[levelNums];

            
            for (int i = 1; i <= levelNums; i++)
            {
                levels[i - 1] = new Level("level" + i.ToString(), i<=openedLevelNums, t);
                levels[i - 1].veiw.Click += openLevel;
                this.panel2.Controls.Add(levels[i - 1].veiw);
            }
          
            backStep++;
        }
        private void openLevel(object s, EventArgs e)
        {
            this.Close();
            string temp = ((levelVeiw)s).Tag.ToString().Substring(5);
            int t = Convert.ToInt32(temp);
           parentForm.openForms(new Form3(levels[t]));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listLevels("medim");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            listLevels("hard");
        }
        int backStep = 1;
        private void button4_Click(object sender, EventArgs e)
        {
            if (backStep == 1)
            {
                this.Close();
            }
            else if (backStep == 2)
            {
                this.lblTitel.Text = "Levels Mode";
                panel2.Controls.Clear();
                panel2.Visible = false;
                panel3.Visible = true;
                backStep--;
            }
        }
    }
}
