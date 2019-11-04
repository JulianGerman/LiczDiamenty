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
            int wspX = User.Location.X;
            int wspY = User.Location.Y;

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            //movement and bounds 

           if (e.KeyCode == Keys.Space)
            {
                label1.Text = " x = " +  Convert.ToString(wspX);
                label2.Text = " y = " + Convert.ToString(wspY);
            }

            if (e.KeyCode == Keys.W && wspY > 115)
            {
                User.Top -= 18;
            }

            else if (e.KeyCode == Keys.A && wspX > 7)
            {
                User.Left -= 18;
            }

            else if (e.KeyCode == Keys.S && wspY < 508)
            {
                User.Top += 18;
            }

            else if (e.KeyCode == Keys.D && wspX < 680)
            {
                User.Left += 18;
            }

        }
           
       

        

        
    }
        
       
    }
