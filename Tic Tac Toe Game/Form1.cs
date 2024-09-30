using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool PlayerNo = false;

        void IsHeWon()
        {
           if ( (Convert.ToByte(Poption1.Tag) == 1 && Convert.ToByte(Poption2.Tag) == 1 && Convert.ToByte(Poption3.Tag) == 1)
               || (Convert.ToByte(Poption2.Tag) == 1 && Convert.ToByte(Poption5.Tag) == 1 && Convert.ToByte(Poption8.Tag) == 1) 
               || (Convert.ToByte(Poption1.Tag) == 1 && Convert.ToByte(Poption4.Tag) == 1 && Convert.ToByte(Poption7.Tag) == 1)
               || (Convert.ToByte(Poption3.Tag) == 1 && Convert.ToByte(Poption6.Tag) == 1 && Convert.ToByte(Poption9.Tag) == 1)
               || (Convert.ToByte(Poption4.Tag) == 1 && Convert.ToByte(Poption5.Tag) == 1 && Convert.ToByte(Poption6.Tag) == 1)
               || (Convert.ToByte(Poption7.Tag) == 1 && Convert.ToByte(Poption8.Tag) == 1 && Convert.ToByte(Poption9.Tag) == 1)
               || (Convert.ToByte(Poption1.Tag) == 1 && Convert.ToByte(Poption5.Tag) == 1 && Convert.ToByte(Poption9.Tag) == 1)
               || (Convert.ToByte(Poption3.Tag) == 1 && Convert.ToByte(Poption5.Tag) == 1 && Convert.ToByte(Poption7.Tag) == 1))
            {
                lblLastWinner.Text = "Player1";
                lblPlayer.Text = "Game Over";
                MessageBox.Show("Game Over", "Game Over");
            }
            else if ((Convert.ToByte(Poption1.Tag) == 2 && Convert.ToByte(Poption2.Tag) == 2 && Convert.ToByte(Poption3.Tag) == 2)
               || (Convert.ToByte(Poption2.Tag) == 2 && Convert.ToByte(Poption5.Tag) == 2 && Convert.ToByte(Poption8.Tag) == 2)
               || (Convert.ToByte(Poption1.Tag) == 2 && Convert.ToByte(Poption4.Tag) == 2 && Convert.ToByte(Poption7.Tag) == 2)
               || (Convert.ToByte(Poption3.Tag) == 2 && Convert.ToByte(Poption6.Tag) == 2 && Convert.ToByte(Poption9.Tag) == 2)
               || (Convert.ToByte(Poption4.Tag) == 2 && Convert.ToByte(Poption5.Tag) == 2 && Convert.ToByte(Poption6.Tag) == 2)
               || (Convert.ToByte(Poption7.Tag) == 2 && Convert.ToByte(Poption8.Tag) == 2 && Convert.ToByte(Poption9.Tag) == 2)
               || (Convert.ToByte(Poption1.Tag) == 2 && Convert.ToByte(Poption5.Tag) == 2 && Convert.ToByte(Poption9.Tag) == 2)
               || (Convert.ToByte(Poption3.Tag) == 2 && Convert.ToByte(Poption5.Tag) == 2 && Convert.ToByte(Poption7.Tag) == 2))
            {
                lblLastWinner.Text = "Player2";
                lblPlayer.Text = "Game Over";
                MessageBox.Show("Game Over", "Game Over");
            }
           else
            {
                if ( !(Convert.ToByte(Poption1.Tag) == 0) && !(Convert.ToByte(Poption2.Tag) == 0) && !(Convert.ToByte(Poption3.Tag) == 0) &&
                    !(Convert.ToByte(Poption4.Tag) == 0) && !(Convert.ToByte(Poption5.Tag) == 0) && !(Convert.ToByte(Poption6.Tag) == 0)
                    && !(Convert.ToByte(Poption7.Tag) == 0) && !(Convert.ToByte(Poption8.Tag) == 0) && !(Convert.ToByte(Poption9.Tag) == 0) ) 
                {
                    lblLastWinner.Text = "Draw";
                    lblPlayer.Text = "Game Over";
                    MessageBox.Show("Game Over", "Game Over");

                }

               
            }



        }

    

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color White = Color.FromArgb(255,255, 255, 255);


            Pen Pen = new Pen(White);
            Pen.Width = 10;

            //Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;



            e.Graphics.DrawLine(Pen, 625, 50, 625, 400); // Right vertical line
            e.Graphics.DrawLine(Pen, 500, 50, 500, 400); // Left vertical line

            // Draw horizontal lines
            e.Graphics.DrawLine(Pen, 400, 150, 750, 150); // Top horizontal line
            e.Graphics.DrawLine(Pen, 400, 280, 750, 280); // Bottom horizontal line


            //e.Graphics.DrawRectangle(Pen, 200, 200, 300, 300);
            //e.Graphics.DrawEllipse(Pen, 200, 50, 100, 120);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Poption1_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption1.Image = Resources.X;
                Poption1.Tag = 1;

            }
            else
            {
                Poption1.Image = Resources.O;
                Poption1.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true; 
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption2_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption2.Image = Resources.X;
                Poption2.Tag = 1;
            }
            else
            {
                Poption2.Image = Resources.O;
                Poption2.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption3_Click(object sender, EventArgs e)
        {
            if (PlayerNo == false)
            {
                Poption3.Image = Resources.X;
                Poption3.Tag = 1;
            }
            else
            {
                Poption3.Image = Resources.O;
                Poption3.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption4_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption4.Image = Resources.X;
                Poption4.Tag = 1;
            }
            else
            {
                Poption4.Image = Resources.O;
                Poption4.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption5_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption5.Image = Resources.X;
                Poption5.Tag = 1;

            }
            else
            {
                Poption5.Image = Resources.O;
                Poption5.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption6_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption6.Image = Resources.X;
                Poption6.Tag = 1;
            }
            else
            {
                Poption6.Image = Resources.O;
                Poption6.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption7_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption7.Image = Resources.X;
                Poption7.Tag = 1;
            }
            else
            {
                Poption7.Image = Resources.O;
                Poption7.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption8_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption8.Image = Resources.X;
                Poption8.Tag = 1;
            }
            else
            {
                Poption8.Image = Resources.O;
                Poption8.Tag = 2;
            }
            IsHeWon();
            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void Poption9_Click(object sender, EventArgs e)
        {

            if (PlayerNo == false)
            {
                Poption9.Image = Resources.X;
                Poption9.Tag = 1;
            }
            else
            {
                Poption9.Image = Resources.O;
                Poption9.Tag = 2;
            }
            IsHeWon();

            if (PlayerNo == false)
            {
                PlayerNo = true;
                lblPlayer.Text = "Player1";
            }

            else
            {
                PlayerNo = false;
                lblPlayer.Text = "Player2";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poption1.Image = Resources.question_mark_96;
            Poption2.Image = Resources.question_mark_96;
            Poption3.Image = Resources.question_mark_96;
            Poption4.Image = Resources.question_mark_96;
            Poption5.Image = Resources.question_mark_96;
            Poption6.Image = Resources.question_mark_96;
            Poption7.Image = Resources.question_mark_96;
            Poption8.Image = Resources.question_mark_96;
            Poption9.Image = Resources.question_mark_96;
            lblLastWinner.Text = "In Progress";
            lblPlayer.Text = "Player1";
            Poption1.Tag = 0;
            Poption2.Tag = 0;
            Poption3.Tag = 0;
            Poption4.Tag = 0;
            Poption5.Tag = 0;
            Poption6.Tag = 0;
            Poption7.Tag = 0;
            Poption8.Tag = 0;
            Poption9.Tag = 0;


        }
    }
}
