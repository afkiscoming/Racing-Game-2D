using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RaceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        int roadSpeed = 31;
        int playerCarSpeed = 5;     //our cars speed

        bool goLeft = false;
        bool goRight = false;

        int otherCarsSpeed = 5;     //other cars speed

        Random random = new Random();

        public void StartGame()
        {
            btn_StartGame.Enabled = false;
            Explosion.Visible = false;

            lbl_highestScore.Text = Settings1.Default.highestScore.ToString();

            playerCarSpeed = 31;
            otherCarsSpeed = 31;
            score = 0;

            //locations playerCar
            CarPlayer.Left = 220;
            CarPlayer.Top = 360;

            //locations otherCars
            Car1.Left = 60;
            Car1.Top = 50;

            Car2.Left = 380;
            Car2.Top = 50;

            goLeft = false;
            goRight = false;

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
            AudioStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score++;
            lbl_Score.Text = score.ToString();

            Road.Top += roadSpeed;
            if(Road.Top>400)
            {
                Road.Top = -100;
            }

            if(goLeft==true)
            {
                CarPlayer.Left -= playerCarSpeed-9; 
            }

            if(goRight==true)
            {
                CarPlayer.Left += playerCarSpeed-9; 
            }

            if(CarPlayer.Left <25)
            {
                goLeft = false;
            }
            else if(CarPlayer.Left + CarPlayer.Width > 485)
            {
                goRight = false;
            }

            Car1.Top += playerCarSpeed;
            Car2.Top += playerCarSpeed;

            if(Car1.Top > panel1.Height)
            {
                ChangeCar1();
                Car1.Left = random.Next(20,230);
                Car1.Top = random.Next(40, 140) * -1;
            }

            if (Car2.Top > panel1.Height)
            {
                ChangeCar2();
                Car2.Left = random.Next(250, 460);
                Car2.Top = random.Next(40, 140) * -1;
            }

            if(CarPlayer.Bounds.IntersectsWith(Car1.Bounds) || CarPlayer.Bounds.IntersectsWith(Car2.Bounds))
            {
                FinishGame();
            }
        }

        private void ChangeCar1()
        {
            int queue = random.Next(1, 7);

            switch (queue)
            {
                case 1:
                    Car1.Image = Properties.Resources.araba2;
                    break;
                case 2:
                    Car1.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    Car1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    Car1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    Car1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    Car1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    Car1.Image = Properties.Resources.araba7 ;
                    break;
            }
        }

        private void ChangeCar2()
        {
            int queue = random.Next(1, 7);

            switch (queue)
            {
                case 1:
                    Car2.Image = Properties.Resources.araba2;
                    break;
                case 2:
                    Car2.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    Car2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    Car2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    Car2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    Car2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    Car2.Image = Properties.Resources.araba7;
                    break;
            }
        }

        private void FinishGame()
        {
            timer1.Stop();

            if(Convert.ToInt32(lbl_Score.Text)> Convert.ToInt32(Settings1.Default.highestScore.ToString()))
            {
                Settings1.Default.highestScore = lbl_Score.Text;
            }

            btn_StartGame.Enabled = true;
            Explosion.Visible = true;
            Explosion.BringToFront();
            Explosion.BackColor = Color.Transparent;
            CarPlayer.Controls.Add(Explosion);
            Explosion.Location = new Point(7, -5);
            MessageBox.Show("Your Score is: " + lbl_Score.Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && CarPlayer.Left > 0)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && CarPlayer.Left + CarPlayer.Width < panel1.Width)
            {
                goRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void AudioStart()
        {
            SoundPlayer audio = new SoundPlayer();
            string audioPath = Application.StartupPath + "\\Kid Cudi - Day N Nite (Andrew Luce Remix).wav";
            audio.SoundLocation = audioPath;
            audio.Play();
        }
    }
}
