using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoronaShooterCZU
{
    public partial class Form1 : Form
    {
        //hlavni trida kde mame skoro vsechno co muzeme videt na obrazovce hry
        bool goUp, goDown, gameOver;
        int playerHealth = 100;
        int speed = 10;
        int pilulky = 10;
        int koronaSpeed = 3;
        int koronaBossSpeed = 7;
        int pivkoSpeed = 3;
        int score = 0;
        string facing = "right";
        Random randNum = new Random();

        List<PictureBox> koronaList = new List<PictureBox>();//list mame pro zapsani poctu korony




        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)//hlavni timer ktery kotroluje jestli hrajeme nebo hra uz skoncila
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                timerZmeny.Stop();
                timerOmikrona.Stop();
                timerpluskorona.Stop();
                player.Image = Properties.Resources.dead;
                player.Left = (0);
                player.Top = (0);
    
               

                gameTimer.Stop();
            }


            //tady je popsano jak budou fungovat label KILLS a PILULKY v moje hre
            txtKills.Text = "KILLS: " + score;
            txtPilulky.Text = "PILULKY: " + pilulky;
            
            //zde urceno kam hrac muze jit(player.Top > 40 mam aby bylo videt label pilulky)
            if (goUp == true && player.Top > 40)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                //pomoci tohoto foreachu a ifu kontrolujeme kdy hrac se potka s pilulkami 
                if(x is PictureBox &&(string)x.Tag == "pilulky")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        pilulky += 5;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "koronaboss")
                {
                    if (x.Location.X < 175)
                    {
                        playerHealth -= 50;
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();

                    }
                }
                //+ kdy korona se dostane do baraku
                if (x is PictureBox && (string)x.Tag == "korona")
                {
                    if (x.Location.X < 175)
                    {
                        playerHealth -= 30;
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        koronaList.Remove((PictureBox)x);
                        MakeKorona();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "pivko")
                {
                    if (x.Location.X < 175)
                    {
                        if (playerHealth < 100)
                        {
                            playerHealth += 30;
                        }
                        else
                        {
                            pilulky += 5;
                        }
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();

                    }
                }
                //tady je popsano dokud muze letet korona
                if (x is PictureBox && (string)x.Tag == "korona")
                {
                    if (x.Left > barak.Right)
                        {
                        x.Left -= koronaSpeed;
                        }
                    if (x.Left < barak.Left)
                        {
                        x.Left += koronaSpeed;
                        }
                }
                if (x is PictureBox && (string)x.Tag == "koronaboss")
                {
                    if (x.Left > barak.Right)
                    {
                        x.Left -= koronaBossSpeed;
                    }
                    if (x.Left < barak.Left)
                    {
                        x.Left += koronaBossSpeed;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "pivko")
                {
                    if (x.Left > barak.Right)
                    {
                        x.Left -= pivkoSpeed;
                    }
                    if (x.Left < barak.Left)
                    {
                        x.Left += pivkoSpeed;
                    }
                }


                foreach (Control j in this.Controls)
                {
                    //pomoci tohoto foreachu a ifu kontrolujeme kdy pilulka se potka s koronou a mame zase +score -korona +korona
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "korona")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            koronaList.Remove((PictureBox)x);
                            MakeKorona();



                        }
                    }
                }
                foreach (Control j in this.Controls)
                {
                    
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "pivko")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                        }
                    }
                }
                foreach (Control j in this.Controls)
                {
                    //pomoci tohoto foreachu a ifu kontrolujeme kdy pilulka se potka s koronou a mame zase +score -korona +korona
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "koronaboss")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {

                                
                                score ++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                
                            
                           
                           
                        }
                    }

                }

            }
        }
        //popisujeme co bude kdyz stiskneme tlacitky a naopak
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Space && pilulky > 0 && gameOver == false)
            {
                //popisujeme strelbu a cas vytvoreni pilulek kdyz mame 0
                pilulky--;
                ShootBullet(facing);
                if (pilulky < 1)
                {
                    DropPilulky();
                }

            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        

        }

        private void ShootBullet(string direction)
        {

            Bullet shootbullet = new Bullet();
            //tady jsem menil obrazovku hrace a pomoci timerZmeneny dolu nastavoval znovu starou,takovym postupem jsem dostal animace strelby
            player.Image = Properties.Resources.herobullet;
            shootbullet.direction = direction;
            //zde popisujeme odkud bude letel pipulka
            shootbullet.bulletLeft = player.Left + (player.Width);
            shootbullet.bulletTop = player.Top + (player.Height / 150);
            shootbullet.MakeBullet(this);
          

        }

        private void timerZmeny_Tick(object sender, EventArgs e)
        {
          
                player.Image = Properties.Resources.hero;
            

        }

        private void MakeKorona()
        {
            //zde mame vsechno pro vyrvoreni korony
            PictureBox korona = new PictureBox();
            korona.Tag = "korona";
            korona.Image = Properties.Resources.korona;
            korona.Left = randNum.Next(550, 600);
            korona.Top = randNum.Next(20, this.ClientSize.Height - korona.Height * 3);
            korona.SizeMode = PictureBoxSizeMode.AutoSize;
            koronaList.Add(korona);
            this.Controls.Add(korona);
            player.BringToFront();
        }
        private void MakePivko()
        {
            //zde mame vsechno pro vyrvoreni korony
            PictureBox pivko = new PictureBox();
            pivko.Tag = "pivko";
            pivko.Image = Properties.Resources.pivko;
            pivko.Left = randNum.Next(550, 600);
            pivko.Top = randNum.Next(20, this.ClientSize.Height - pivko.Height * 3);
            pivko.SizeMode = PictureBoxSizeMode.AutoSize;
            koronaList.Add(pivko);
            this.Controls.Add(pivko);
            player.BringToFront();
        }

        private void DropPilulky()
        {
            //tady mame pipulky ktere se objevi 
            PictureBox pilulky = new PictureBox();
            pilulky.Tag = "pilulky";
            pilulky.Image = Properties.Resources.ammo_Image;
            pilulky.Left = randNum.Next(10, 10);
            pilulky.Top = randNum.Next(100, this.ClientSize.Height - pilulky.Height);
            pilulky.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(pilulky);
            pilulky.BringToFront();
            player.BringToFront();
        }

        private void timerOmikrona_Tick(object sender, EventArgs e)
        {
            timerOmikrona.Interval = randNum.Next(timerOmikrona.Interval, 16000);
            MakeOmikron();
        }

        private void timerpluskorona_Tick(object sender, EventArgs e)
        {
            MakeKorona();
            koronaSpeed++;
        }

        private void timerPivka_Tick(object sender, EventArgs e)
        {
            timerPivka.Interval = randNum.Next(timerPivka.Interval, 18000);
            MakePivko();
        }

        private void MakeOmikron()
        {
            PictureBox koronaboss = new PictureBox();
            koronaboss.Tag = "koronaboss";
            koronaboss.Image = Properties.Resources.koronaboss;
            koronaboss.Left = randNum.Next(550, 600);
            koronaboss.Top = randNum.Next(0, this.ClientSize.Height - koronaboss.Height * 3);
            koronaboss.SizeMode = PictureBoxSizeMode.AutoSize;
            koronaList.Add(koronaboss);
            this.Controls.Add(koronaboss);
            player.BringToFront();

        }
        
        private void RestartGame()
        {
            foreach (PictureBox i in koronaList)
            {
                this.Controls.Remove(i);
            }
            koronaList.Clear();
            for (int i = 0; i < 4; i++)
            //tady je nastaveno kolik celkem korony bude hrac mit
            { 
                MakeKorona();
            }
            goDown = false;
            goUp = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            pilulky = 10;
            timerOmikrona.Start();
            timerpluskorona.Start();
            timerZmeny.Start();
            gameTimer.Start();
            koronaSpeed = 3;
        }
    }
}
