using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marioSobka
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        Form activeForm;
        public void openForms(Form child)
        {
            activeForm = child;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.TopLevel = false;
            this.panel1.Controls.Add(activeForm);
            activeForm.BringToFront();
            activeForm.Show();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
         //  this.openForms(new Form3()); 
        }

        private void btnMakeLavel_Click(object sender, EventArgs e)
        {
          makeLevelForm f = new makeLevelForm();
            f.Show();
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForms( new levelsMenuForm(this));
            
            
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("lll");

        }

        private void mainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("lll");
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
