
namespace RaceGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.CarPlayer = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Road = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_highestScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Explosion);
            this.panel1.Controls.Add(this.Car2);
            this.panel1.Controls.Add(this.CarPlayer);
            this.panel1.Controls.Add(this.Car1);
            this.panel1.Controls.Add(this.Road);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // Explosion
            // 
            this.Explosion.Image = global::RaceGame.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(223, 350);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(73, 68);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Explosion.TabIndex = 2;
            this.Explosion.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = global::RaceGame.Properties.Resources.araba6;
            this.Car2.Location = new System.Drawing.Point(348, 50);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(69, 134);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 1;
            this.Car2.TabStop = false;
            // 
            // CarPlayer
            // 
            this.CarPlayer.Image = global::RaceGame.Properties.Resources.araba5;
            this.CarPlayer.Location = new System.Drawing.Point(223, 350);
            this.CarPlayer.Name = "CarPlayer";
            this.CarPlayer.Size = new System.Drawing.Size(69, 134);
            this.CarPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPlayer.TabIndex = 1;
            this.CarPlayer.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Image = global::RaceGame.Properties.Resources.araba4;
            this.Car1.Location = new System.Drawing.Point(103, 50);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(69, 134);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            // 
            // Road
            // 
            this.Road.Image = global::RaceGame.Properties.Resources.yol;
            this.Road.Location = new System.Drawing.Point(-6, -252);
            this.Road.Name = "Road";
            this.Road.Size = new System.Drawing.Size(513, 775);
            this.Road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road.TabIndex = 0;
            this.Road.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(467, 552);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(21, 24);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "0";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartGame.Location = new System.Drawing.Point(109, 593);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(317, 33);
            this.btn_StartGame.TabIndex = 2;
            this.btn_StartGame.Text = "Start";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Highest Score:";
            // 
            // lbl_highestScore
            // 
            this.lbl_highestScore.AutoSize = true;
            this.lbl_highestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highestScore.Location = new System.Drawing.Point(166, 552);
            this.lbl_highestScore.Name = "lbl_highestScore";
            this.lbl_highestScore.Size = new System.Drawing.Size(21, 24);
            this.lbl_highestScore.TabIndex = 1;
            this.lbl_highestScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 638);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.lbl_highestScore);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Race Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Road;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox CarPlayer;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_highestScore;
    }
}

