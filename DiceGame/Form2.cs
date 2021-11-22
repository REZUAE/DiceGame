using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public int NumberOfRounds;
        public int NumberOfPlayers;





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                NumberOfPlayers = Convert.ToInt32(txtNumbOfPlayers.Text);
                if (NumberOfPlayers > 4)
                {
                    MessageBox.Show("Players range must be from 1 to 4");
                    break;

                }
                else if (NumberOfPlayers < 0)
                {
                    MessageBox.Show("Players range must be from 1 to 4");
                    break;
                }
                else
                {
                    break;
                }

            }
            for (int i = 0; i < 99; i++)
            {
                NumberOfRounds = Convert.ToInt32(txtRounds.Text);
                if (NumberOfRounds > 30)
                {
                    MessageBox.Show("Number of rounds should be from 5 to 30");
                    break;
                }
                else if (NumberOfRounds < 5)
                {
                    MessageBox.Show("Number of rounds should be from 5 to 30");
                    break;
                }
                else
                {
                    break;
                }
            }

        }

        private void txtNumbOfPlayers_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBoxPlayer1.Load("Avatars\\1.jpg");
            commonData.imgProfile1 = PictureBoxPlayer1.ImageLocation;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBoxPlayer1.Load("Avatars\\3.jpg");

            commonData.imgProfile1 = PictureBoxPlayer1.ImageLocation;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBoxPlayer1.Load("Avatars\\2.jpg");

            commonData.imgProfile1 = PictureBoxPlayer1.ImageLocation;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBoxPlayer1.Load("Avatars\\4.jpg");

            commonData.imgProfile1 = PictureBoxPlayer1.ImageLocation;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBoxPlayer1.Load("Avatars\\5.jpg");

            commonData.imgProfile1 = PictureBoxPlayer1.ImageLocation;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            PictureBoxPlayer1.Load("Avatars\\6.jpg");

            commonData.imgProfile1 = PictureBoxPlayer1.ImageLocation;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Load("Avatars\\1.jpg");
            commonData.imgProfile2 = pictureBoxPlayer2.ImageLocation;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Load("Avatars\\2.jpg");

            commonData.imgProfile2 = pictureBoxPlayer2.ImageLocation;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Load("Avatars\\3.jpg");

            commonData.imgProfile2 = pictureBoxPlayer2.ImageLocation;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Load("Avatars\\4.jpg");

            commonData.imgProfile2 = pictureBoxPlayer2.ImageLocation;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Load("Avatars\\5.jpg");

            commonData.imgProfile2 = pictureBoxPlayer2.ImageLocation;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Load("Avatars\\6.jpg");

            commonData.imgProfile2 = pictureBoxPlayer2.ImageLocation;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer3.Load("Avatars\\1.jpg");

            commonData.imgProfile3 = pictureBoxPlayer3.ImageLocation;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer3.Load("Avatars\\2.jpg");


            commonData.imgProfile3 = pictureBoxPlayer3.ImageLocation;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer3.Load("Avatars\\3.jpg");


            commonData.imgProfile3 = pictureBoxPlayer3.ImageLocation;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer3.Load("Avatars\\4.jpg");


            commonData.imgProfile3 = pictureBoxPlayer3.ImageLocation;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer3.Load("Avatars\\5.jpg");


            commonData.imgProfile3 = pictureBoxPlayer3.ImageLocation;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer3.Load("Avatars\\6.jpg");


            commonData.imgProfile3 = pictureBoxPlayer3.ImageLocation;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer4.Load("Avatars\\1.jpg");

            commonData.imgProfile4 = pictureBoxPlayer4.ImageLocation;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer4.Load("Avatars\\2.jpg");

            commonData.imgProfile4 = pictureBoxPlayer4.ImageLocation;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer4.Load("Avatars\\3.jpg");

            commonData.imgProfile4 = pictureBoxPlayer4.ImageLocation;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer4.Load("Avatars\\4.jpg");

            commonData.imgProfile4 = pictureBoxPlayer4.ImageLocation;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer4.Load("Avatars\\5.jpg");


            commonData.imgProfile4 = pictureBoxPlayer4.ImageLocation;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer4.Load("Avatars\\6.jpg");


            commonData.imgProfile4= pictureBoxPlayer4.ImageLocation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a2 = new Form3();
            a2.ShowDialog();

        }
    }
}
