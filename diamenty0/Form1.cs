using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diamenty0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //level1
        {

            hidemenu();



        }
        private void pictureBox3_Click(object sender, EventArgs e) //level2
        {
            hidemenu();
        }

        

        private void pictureBox4_Click(object sender, EventArgs e) //level 3
        {
            hidemenu();
        }

      

       

        void showmenu()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            backbutton.Visible = false;
            user.Visible = false;
        }
        void hidemenu()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            backbutton.Visible = true;
            user.Visible = true;
        }


        private void backbutton_Click(object sender, EventArgs e)
        {
            showmenu();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Red, 50, 50, 50, 50);
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // movement Gracza
        {
            if (e.KeyCode == Keys.W)
            {
                user.Top -= 10;
            }
            else if (e.KeyCode == Keys.A)
            {
                user.Left -= 10;
            }
            else if (e.KeyCode == Keys.S)
            {
                user.Top += 10;
            }
            else if (e.KeyCode == Keys.D)
            {
                user.Left += 10;
            }

        }
    }
}
