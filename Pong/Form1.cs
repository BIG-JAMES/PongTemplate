using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Pong
{
    public partial class Form1 : Form
    {

        //Global variables

        //drawing
        Rectangle player1 = new Rectangle(40, 200, 120, 180);
        Rectangle player2 = new Rectangle(640, 200, 120, 180);
        Rectangle player1hit = new Rectangle(3000, 200, 120, 40);
        Rectangle player2hit = new Rectangle(3000, 200, 120, 40);
        Rectangle hitsprieloco = new Rectangle(200, 200, 1, 1);
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush TransparentBrush = new SolidBrush(Color.Transparent);
        Pen whitepen = new Pen(Color.White);

        //health
        int player1Score = 10;
        int player2Score = 10;

        //player speed
        int player1Speed = 5;
        int player2Speed = 5;

        //buttion imput 
        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        bool iPressed = false;
        bool kPressed = false;
        bool jPressed = false;
        bool lPressed = false;

        //soundPlayer
        SoundPlayer soundPlayer = new SoundPlayer();

        //on project start up
        private void Form1_Load(object sender, EventArgs e)
        {
            player1dis.Parent = pictureBox1;
            player2dis.Parent = pictureBox1;
        }

        //buttion imput
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    player1dis.Width = 120;
                    player1dis.Height = 90;
                    player1.Height = 90;
                    player1.Y = 290;
                    player1hit.X = 3000;
                    player1dis.Image = Properties.Resources.crowchR;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;

                case Keys.I:
                    iPressed = true;
                    break;
                case Keys.K:
                    kPressed = true;
                    player1dis.Width = 120;
                    player2dis.Height = 90;
                    player2dis.Location = player2.Location;
                    player2.Height = 90;
                    player2.Y = 290;
                    player2hit.X = 3000;
                    player2dis.Image = Properties.Resources.crowchB;
                    break;
                case Keys.J:
                    jPressed = true;
                    break;
                case Keys.L:
                    lPressed = true;
                    break;
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    player1.Height = 180;
                    player1.Y = 200;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;


                case Keys.I:
                    iPressed = false;
                    break;
                case Keys.K:
                    kPressed = false;
                    player2.Height = 180;
                    player2.Y = 200;
                    break;
                case Keys.J:
                    jPressed = false;
                    break;
                case Keys.L:
                    lPressed = false;
                    break;
            }

        }

        //game tick
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //player1 display/Move player 1
            player1dis.Location = player1.Location;
            if (aPressed == true && player1.X > 0)
            {
                wPressed = false;
                RATB1.Enabled = true;
                if (RATB1.Enabled == false)
                {
                    if (RATB2.Enabled == false)
                    {
                        if (RATB3.Enabled == false)
                        {
                            if (RATB4.Enabled == false)
                            {
                                player1dis.Image = Properties.Resources.standingR;
                            }
                        }
                    }
                }
                player1.X -= player1Speed;
            }
            if (dPressed == true && player1.X > 0)
            {
                wPressed = false;

                if (RAT1.Enabled == false)
                {
                    if (RAT2.Enabled == false)
                    {
                        if (RAT3.Enabled == false)
                        {
                            if (RAT4.Enabled == false)
                            {
                                player1dis.Image = Properties.Resources.standingR;
                            }
                        }
                    }
                }
                player1.X += player1Speed;
            }
            if (wPressed == true)
            {
                if (sPressed == false)
                {
                    //punchung
                    sPressed = false;
                    player1hit.X = player1.X + 70;
                    player1hit.Y = player1.Y + 30;
                    player1dis.Height = 180;
                    player1dis.Width = 200;
                    player1dis.Image = Properties.Resources.punchingR;
                }
            }
            else
            {
                //players original size 
                player1dis.Height = 180;
                player1dis.Width = 120;
                //hitbox out of view
                player1hit.X = 3000;
                if (sPressed == true)
                {
                    if(wPressed == false)
                    {
                        //crouching
                        RAT1.Enabled = false;
                        player1dis.Height = 90;
                        player1Speed = 0;
                        player1dis.Image = Properties.Resources.crowchR;
                    }
                }
                else
                {
                    if (aPressed == false)
                    {
                        RATB1.Enabled = false;
                        player1Speed = 5;
                        if (dPressed == false)
                        {
                            player1dis.Height = 180;
                            player1dis.Width = 120;
                            player1dis.Image = Properties.Resources.standingR;
                            RAT1.Enabled = false;

                            wPressed = false;
                        }
                        else
                        {
                            RAT1.Enabled = true;
                        }
                    }
                    else
                    {
                        RATB1.Enabled = true;
                        player1Speed = 4;
                    }
                }
            }


            //player2 display/Move player 2
            hitsprieloco.X = player2.X - 90;
            if (jPressed == true && player2.X > 0)
            {
                iPressed = false;

                if (BAT1.Enabled == false)
                {
                    if (BAT2.Enabled == false)
                    {
                        if (BAT3.Enabled == false)
                        {
                            if (BAT4.Enabled == false)
                            {
                                player2dis.Image = Properties.Resources.standingB;
                            }
                        }
                    }
                }
                player2.X -= player2Speed;
            }
            if (lPressed == true && player2.X > 0)
            {
                iPressed = false;

                RATB1.Enabled = true;
                if (BATB1.Enabled == false)
                {
                    if (BATB2.Enabled == false)
                    {
                        if (BATB3.Enabled == false)
                        {
                            if (BATB4.Enabled == false)
                            {
                                player2dis.Image = Properties.Resources.standingB;
                            }
                        }
                    }
                }
                player2.X += player2Speed;
            }
            if (iPressed == true)
            {
                if (kPressed == false)
                {
                    //punchung
                    kPressed = false;
                    player2hit.X = player2.X - 70;
                    player2hit.Y = player2.Y + 30;
                    player2dis.Height = 180;
                    player2dis.Width = 200;
                    player2dis.Location = hitsprieloco.Location;
                    player2dis.Image = Properties.Resources.punchingB;
                }
            }
            else
            {
                //players original size & location
                player2dis.Location = player2.Location;
                player2dis.Height = 180;
                player2dis.Width = 120;
                //hitbox out of view
                player2hit.X = 3000;
                if (kPressed == true)
                {
                    if(iPressed == false)
                    {
                        //crouching
                        iPressed = false;
                        RAT2.Enabled = false;
                        player2dis.Height = 90;
                        player2Speed = 0;
                        player2dis.Image = Properties.Resources.crowchB;
                        player2dis.Location = player2.Location;
                    }
                }
                else
                {
                    if (lPressed == false)
                    {
                        BATB1.Enabled = false;
                        player2Speed = 5;
                        if (jPressed == false)
                        {
                            player2dis.Height = 180;
                            player2dis.Width = 120;
                            player2dis.Image = Properties.Resources.standingB;
                            BAT1.Enabled = false;

                            iPressed = false;
                        }
                        else
                        {
                            BAT1.Enabled = true;
                        }
                    }
                    else
                    {
                        BATB1.Enabled = true;
                        player2Speed = 4;
                    }
                }
            }

            //walls 
            //right wall
            if (player1.X > 671)
            {
                player1.X = 670;
            }
            if (player2.X > 671)
            {
                player2.X = 670;
            }
            //left wall
            if (player1.X < 10)
            {
                player1.X = 11;
            }
            if (player2.X < 10)
            {
                player2.X = 11;
            }


            //check if the game is over and show a winner
            player2HB.Text = $"{player1Score}0 HP";
            player1HB.Text = $"{player2Score}0 HP";

            //player2 health bar

            if (player1Score == 9)
            {
                player2DHB.Width = 261;
            }
            if (player1Score == 8)
            {
                player2DHB.Width = 232;
            }
            if (player1Score == 7)
            {
                player2DHB.Width = 203;
            }
            if (player1Score == 6)
            {
                player2DHB.Width = 174;
            }
            if (player1Score == 5)
            {
                player2DHB.Width = 145;
            }
            if (player1Score == 4)
            {
                player2DHB.Width = 116;
            }
            if (player1Score == 3)
            {
                player2DHB.Width = 87;
            }
            if (player1Score == 2)
            {
                player2DHB.Width = 58;
            }
            if (player1Score == 1)
            {
                player2DHB.Width = 29;
            }
            if (player1Score < 0)
            {
                player2DHB.Width = 0;
                player2HB.Text = "DEAD";
            }

            //player1 health bar
            if (player2Score == 9)
            {
                player1DHB.Width = 261;
            }
            if (player2Score == 8)
            {
                player1DHB.Width = 232;
            }
            if (player2Score == 7)
            {
                player1DHB.Width = 203;
            }
            if (player2Score == 6)
            {
                player1DHB.Width = 174;
            }
            if (player2Score == 5)
            {
                player1DHB.Width = 145;
            }
            if (player2Score == 4)
            {
                player1DHB.Width = 116;
            }
            if (player2Score == 3)
            {
                player1DHB.Width = 87;
            }
            if (player2Score == 2)
            {
                player1DHB.Width = 58;
            }
            if (player2Score == 1)
            {
                player1DHB.Width = 29;
            }
            if ( player2Score < 0)
            {
                player1DHB.Width = 0;
                player1HB.Text = "DEAD";
            }

            Refresh();
        }

        //drawing player & hitbox
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(blueBrush, player1hit);

            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.FillRectangle(blueBrush, player2hit);
            e.Graphics.FillRectangle(blueBrush, hitsprieloco);
        }

        public Form1()
        {
            InitializeComponent();
        }



        //animations 
        // (R.A.T = red animation time) & (B.A.T = blue animation time)

        //red walking animation
        private void RAT1_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            wPressed = false;

            player1dis.Image = Properties.Resources.walkRI;
            RAT1.Enabled = false;
            RAT2.Enabled = true;
        }
        private void RAT2_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            wPressed = false;

            player1dis.Image = Properties.Resources.walkRII;
            RAT2.Enabled = false;
            RAT3.Enabled = true;

            RAT1.Enabled = false;
        }
        private void RAT3_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            wPressed = false;

            player1dis.Image = Properties.Resources.walkRIII;
            RAT3.Enabled = false;
            RAT4.Enabled = true;

            RAT1.Enabled = false;
        }
        private void RAT4_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            wPressed = false;

            player1dis.Image = Properties.Resources.walkRII;
            RAT4.Enabled = false;

            RAT1.Enabled = false;
        }
        //back
        private void RATB1_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            player1dis.Image = Properties.Resources.walkRII;

            RATB1.Enabled = false;
            RATB2.Enabled = true;
        }
        private void RATB2_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            player1dis.Image = Properties.Resources.walkRIII;

            RATB2.Enabled = false;
            RATB3.Enabled = true;
            RATB1.Enabled = false;
        }
        private void RATB3_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            player1dis.Image = Properties.Resources.walkRII;

            RATB3.Enabled = false;
            RATB4.Enabled = true;
            RATB1.Enabled = false;
        }
        private void RATB4_Tick(object sender, EventArgs e)
        {
            player1dis.Height = 180;
            player1dis.Width = 120;
            player1hit.X = 3000;
            player1dis.Image = Properties.Resources.walkRI;

            RATB4.Enabled = false;
            RATB1.Enabled = false;
        }



        //blue walking animation
        private void BAT1_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            iPressed = false;

            player2dis.Image = Properties.Resources.walkBI;
            BAT1.Enabled = false;
            BAT2.Enabled = true;
        }
        private void BAT2_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            iPressed = false;

            player2dis.Image = Properties.Resources.walkBII;
            BAT2.Enabled = false;
            BAT3.Enabled = true;

            BAT1.Enabled = false;
        }
        private void BAT3_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            iPressed = false;

            player2dis.Image = Properties.Resources.walkBIII;
            BAT3.Enabled = false;
            BAT4.Enabled = true;

            BAT1.Enabled = false;
        }
        private void BAT4_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            iPressed = false;

            player2dis.Image = Properties.Resources.walkBII;
            BAT4.Enabled = false;

            BAT1.Enabled = false;
        }
        //back
        private void BATB1_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            player2dis.Image = Properties.Resources.walkBII;

            BATB1.Enabled = false;
            BATB2.Enabled = true;
        }
        private void BATB2_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            player2dis.Image = Properties.Resources.walkBIII;

            BATB2.Enabled = false;
            BATB3.Enabled = true;
            BATB1.Enabled = false;
        }
        private void BATB3_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            player2dis.Image = Properties.Resources.walkBII;

            BATB3.Enabled = false;
            BATB4.Enabled = true;
            BATB1.Enabled = false;
        }
        private void BATB4_Tick(object sender, EventArgs e)
        {
            player2dis.Height = 180;
            player2dis.Width = 120;
            player2hit.X = 3000;
            player2dis.Image = Properties.Resources.walkBI;

            BATB4.Enabled = false;
            BATB1.Enabled = false;
        }
    }
}
