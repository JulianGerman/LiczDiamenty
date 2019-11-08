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

        Graphics g;
        User user = new User();
        Chest chest = new Chest();

        public Level1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //int chx = 20;
            //int chy = 20;


            



            e.Graphics.DrawImage(new Bitmap("chest.png"), chest.Wspx, chest.Wspy, chest.width, chest.height);
            e.Graphics.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);

           if (user.show == true )
            {
                e.Graphics.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
            }

            /* for (int i = 0; i < 240; i += 60)
             {
                 e.Graphics.DrawImage(skrzynka, chx + i, chy);
             }

             for (int i = 0; i < 300; i += 60)
             {
                 e.Graphics.DrawImage(skrzynka, chx + 240, chy + i);
             }
             for (int i = 0; i < 240; i += 60)
             {
                 e.Graphics.DrawImage(skrzynka, chx + 240 + i, chy + 240);
             }
             for (int i = 0; i <120; i += 60)
             {
                 e.Graphics.DrawImage(skrzynka, chx + 600 + i, chy + 240);
             }*/


        }
            private void Level1_KeyDown(object sender, KeyEventArgs e)
            {
               // int wspX = User.Location.X;
               // int wspY = User.Location.Y;
                
               


            if (e.KeyCode == Keys.Escape)
                {
                    Application.Exit();
                }

                //movement and bounds 

                if (e.KeyCode == Keys.Space)
                {
                    label1.Text = " x = " + user.Wspx;
                    label2.Text = " y = " + user.Wspy;
                }

                if (e.KeyCode == Keys.W )//&& wspY > 15)
                {
                   // User.Top -= 18;
                    user.moveup();
                    
                }

                else if (e.KeyCode == Keys.A)// && wspX > 7)
                {
                    //User.Left -= 18;
                    user.moveleft();
                }

                else if (e.KeyCode == Keys.S )//&& wspY < 377)
                {
                    //User.Top += 18;
                    user.movedown();
                }

                else if (e.KeyCode == Keys.D)// && wspX < 680)
                {
                    //wUser.Left += 18;
                    user.moveright();
                }

               


            }

      
    }





        
    }
        
       
    
