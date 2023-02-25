namespace marioSobka
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.linِAboutGame = new System.Windows.Forms.LinkLabel();
            this.btnMakeLavel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(152, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(152, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "تعليمات";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(152, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "المستويات ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Peru;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNewGame.ForeColor = System.Drawing.Color.Maroon;
            this.btnNewGame.Location = new System.Drawing.Point(152, 111);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(117, 31);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "لعبة جديدة ";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Peru;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnContinue.ForeColor = System.Drawing.Color.Maroon;
            this.btnContinue.Location = new System.Drawing.Point(152, 74);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(117, 31);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "استمرار ";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // linِAboutGame
            // 
            this.linِAboutGame.AutoSize = true;
            this.linِAboutGame.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linِAboutGame.Location = new System.Drawing.Point(12, 388);
            this.linِAboutGame.Name = "linِAboutGame";
            this.linِAboutGame.Size = new System.Drawing.Size(58, 14);
            this.linِAboutGame.TabIndex = 7;
            this.linِAboutGame.TabStop = true;
            this.linِAboutGame.Text = "عن اللعبة ";
            this.linِAboutGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnMakeLavel
            // 
            this.btnMakeLavel.BackColor = System.Drawing.Color.Peru;
            this.btnMakeLavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeLavel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMakeLavel.ForeColor = System.Drawing.Color.Maroon;
            this.btnMakeLavel.Location = new System.Drawing.Point(152, 185);
            this.btnMakeLavel.Name = "btnMakeLavel";
            this.btnMakeLavel.Size = new System.Drawing.Size(117, 31);
            this.btnMakeLavel.TabIndex = 8;
            this.btnMakeLavel.Text = "اصنع مستويات ";
            this.btnMakeLavel.UseVisualStyleBackColor = false;
            this.btnMakeLavel.Click += new System.EventHandler(this.btnMakeLavel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.btnMakeLavel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linِAboutGame);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 472);
            this.panel1.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(421, 472);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "mario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.LinkLabel linِAboutGame;
        private System.Windows.Forms.Button btnMakeLavel;
        private System.Windows.Forms.Panel panel1;
    }
}

