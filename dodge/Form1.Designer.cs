namespace dodge
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.countdownLbl = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.level2b3 = new System.Windows.Forms.Button();
            this.level2b2 = new System.Windows.Forms.Button();
            this.level2b = new System.Windows.Forms.Button();
            this.click2 = new System.Windows.Forms.Button();
            this.click1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.TextBox();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.Button();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlGame.Controls.Add(this.countdownLbl);
            this.PnlGame.Controls.Add(this.pictureBox2);
            this.PnlGame.Controls.Add(this.txtAnswer2);
            this.PnlGame.Controls.Add(this.textBox6);
            this.PnlGame.Controls.Add(this.button1);
            this.PnlGame.Controls.Add(this.txtAnswer);
            this.PnlGame.Controls.Add(this.textBox5);
            this.PnlGame.Controls.Add(this.level2b3);
            this.PnlGame.Controls.Add(this.level2b2);
            this.PnlGame.Controls.Add(this.level2b);
            this.PnlGame.Controls.Add(this.click2);
            this.PnlGame.Controls.Add(this.click1);
            this.PnlGame.Controls.Add(this.button2);
            this.PnlGame.Controls.Add(this.textBox4);
            this.PnlGame.Controls.Add(this.textBox3);
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Controls.Add(this.textBox2);
            this.PnlGame.Controls.Add(this.textBox1);
            this.PnlGame.Controls.Add(this.b1);
            this.PnlGame.Controls.Add(this.menuStrip1);
            this.PnlGame.Location = new System.Drawing.Point(1, 1);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(680, 410);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // countdownLbl
            // 
            this.countdownLbl.AutoSize = true;
            this.countdownLbl.Enabled = false;
            this.countdownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLbl.Location = new System.Drawing.Point(308, 138);
            this.countdownLbl.Name = "countdownLbl";
            this.countdownLbl.Size = new System.Drawing.Size(98, 108);
            this.countdownLbl.TabIndex = 19;
            this.countdownLbl.Text = "3";
            this.countdownLbl.Visible = false;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Enabled = false;
            this.txtAnswer2.Location = new System.Drawing.Point(313, 151);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(112, 20);
            this.txtAnswer2.TabIndex = 17;
            this.txtAnswer2.Text = "type here, press enter";
            this.txtAnswer2.Visible = false;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            this.txtAnswer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer2_KeyDown);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(287, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(176, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "president Obama\'s last name";
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(262, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 73);
            this.button1.TabIndex = 15;
            this.button1.Text = "Damn it i really thought thta would get you\r\n\r\nwell welcome to level 4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(312, 151);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAnswer.Size = new System.Drawing.Size(112, 20);
            this.txtAnswer.TabIndex = 14;
            this.txtAnswer.Text = "type here, press enter to confirm answer";
            this.txtAnswer.Visible = false;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(313, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "is josh racist";
            this.textBox5.Visible = false;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // level2b3
            // 
            this.level2b3.Enabled = false;
            this.level2b3.Location = new System.Drawing.Point(11, 53);
            this.level2b3.Name = "level2b3";
            this.level2b3.Size = new System.Drawing.Size(190, 91);
            this.level2b3.TabIndex = 12;
            this.level2b3.Text = "in this level your objective is to simply answer one question right. \r\n\r\n      \r\n" +
    " simple right ? no way you could fail this one";
            this.level2b3.UseVisualStyleBackColor = true;
            this.level2b3.Visible = false;
            this.level2b3.Click += new System.EventHandler(this.level2b3_Click);
            // 
            // level2b2
            // 
            this.level2b2.Enabled = false;
            this.level2b2.Location = new System.Drawing.Point(465, 260);
            this.level2b2.Name = "level2b2";
            this.level2b2.Size = new System.Drawing.Size(156, 66);
            this.level2b2.TabIndex = 11;
            this.level2b2.Text = "well welcome to level three then";
            this.level2b2.UseVisualStyleBackColor = true;
            this.level2b2.Visible = false;
            this.level2b2.Click += new System.EventHandler(this.level2b2_Click);
            // 
            // level2b
            // 
            this.level2b.Enabled = false;
            this.level2b.Location = new System.Drawing.Point(249, 115);
            this.level2b.Name = "level2b";
            this.level2b.Size = new System.Drawing.Size(220, 112);
            this.level2b.TabIndex = 10;
            this.level2b.Text = " damn it you beat level 2";
            this.level2b.UseVisualStyleBackColor = true;
            this.level2b.Visible = false;
            this.level2b.Click += new System.EventHandler(this.level2b_Click);
            // 
            // click2
            // 
            this.click2.Enabled = false;
            this.click2.Location = new System.Drawing.Point(331, 158);
            this.click2.Name = "click2";
            this.click2.Size = new System.Drawing.Size(81, 23);
            this.click2.TabIndex = 9;
            this.click2.Text = "DON\'T CLICK";
            this.click2.UseVisualStyleBackColor = true;
            this.click2.Visible = false;
            this.click2.Click += new System.EventHandler(this.click2_Click);
            // 
            // click1
            // 
            this.click1.Enabled = false;
            this.click1.Location = new System.Drawing.Point(326, 158);
            this.click1.Name = "click1";
            this.click1.Size = new System.Drawing.Size(86, 26);
            this.click1.TabIndex = 8;
            this.click1.Text = "Click";
            this.click1.UseVisualStyleBackColor = true;
            this.click1.Visible = false;
            this.click1.Click += new System.EventHandler(this.click1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(215, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 124);
            this.button2.TabIndex = 7;
            this.button2.Text = "level 2\r\nobjective click appering buttons to reach 40 score\r\n\r\n\r\n\r\n\r\n\r\nclick butt" +
    "on to start next game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(577, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "lives ->";
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(577, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "score ->";
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "you completeed level one yay";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Level 1, goal reach 20 score to move on to the next level";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(687, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Enabled = false;
            this.lblScore.Location = new System.Drawing.Point(688, 41);
            this.lblScore.Name = "lblScore";
            this.lblScore.ReadOnly = true;
            this.lblScore.Size = new System.Drawing.Size(100, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.TextChanged += new System.EventHandler(this.lblScore_TextChanged);
            // 
            // txtLives
            // 
            this.txtLives.Enabled = false;
            this.txtLives.Location = new System.Drawing.Point(687, 67);
            this.txtLives.Name = "txtLives";
            this.txtLives.ReadOnly = true;
            this.txtLives.Size = new System.Drawing.Size(100, 20);
            this.txtLives.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // countdowntimer
            // 
            this.countdowntimer.Interval = 1000;
            this.countdowntimer.Tick += new System.EventHandler(this.countdowntimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::dodge.Properties.Resources.open_scene_for_game;
            this.pictureBox2.Location = new System.Drawing.Point(22, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 200);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dodge.Properties.Resources.game;
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 380);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b1
            // 
            this.b1.BackgroundImage = global::dodge.Properties.Resources.missile_small;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Location = new System.Drawing.Point(534, 136);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(26, 142);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PnlGame);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "damn it you beat level two";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.TextBox lblScore;
        private System.Windows.Forms.TextBox txtLives;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button click2;
        private System.Windows.Forms.Button click1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button level2b3;
        private System.Windows.Forms.Button level2b2;
        private System.Windows.Forms.Button level2b;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer countdowntimer;
        private System.Windows.Forms.Label countdownLbl;
    }
}

