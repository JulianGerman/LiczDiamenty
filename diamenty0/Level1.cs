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
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            //movement 

            if (e.KeyCode == Keys.W)
            {
                User.Top -= 13;
            }

            else if (e.KeyCode == Keys.A)
            {
                User.Left -= 13;
            }

            else if (e.KeyCode == Keys.S)
            {
                User.Top += 13;
            }

            else if (e.KeyCode == Keys.D)
            {
                User.Left += 13;
            }

            /*else if (e.KeyCode == Keys.D )
            {
                User.Left += 10;
                User.Top -= 10;
            }*/


        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                User.Top -= 13;
            }

            else if (e.KeyCode == Keys.A)
            {
                User.Left -= 13;
            }

            else if (e.KeyCode == Keys.S)
            {
                User.Top += 13;
            }

            else if (e.KeyCode == Keys.D)
            {
                User.Left += 13;
            }
        }
    }
        
       
    }
