using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace marioSobka
{
   public class levelVeiw:Panel
    {
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;


        public levelVeiw()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.BackColor = System.Drawing.Color.Peru;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(0, 64);
            this.Name = "panel2";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Size = new System.Drawing.Size(374, 50);
            this.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(288, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 48);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
        }
    }
}
