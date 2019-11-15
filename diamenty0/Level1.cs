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
        //public Chest(int height, int width, int Wspx, int Wspy)
        Graphics g;
        User user = new User();
        Chest chest1 = new Chest(50,50,100,300);
        Chest chest2 = new Chest(50,50,100,400);
        Chest chest3 = new Chest(50,50,100,500);
        Chest chest4 = new Chest(50,50,100,600);
        Chest chest5 = new Chest(50,50,100,700);
        Chest chest6 = new Chest(50,50,100,450);
        Chest chest7 = new Chest(50,50,100,340);


        List<Chest> skrzynki = new List<Chest>();
     



        public Level1()
        {
            InitializeComponent();
            g = CreateGraphics();

            skrzynki.Add(chest1);
            skrzynki.Add(chest2);
            skrzynki.Add(chest3);
            skrzynki.Add(chest4);
            skrzynki.Add(chest5);
            skrzynki.Add(chest6);
            skrzynki.Add(chest7);
            
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

                //movement and bounds 
            
                if (e.KeyCode == Keys.Space)
                {
                    label1.Text = " x = " + user.Wspx;
                    label2.Text = " y = " + user.Wspy;
                }
          // problem je z tym warunkiem  if (user.Wspx )
            {
                if (e.KeyCode == Keys.W && user.Wspy > 182)
                {

                    Invalidate();
                    user.moveup();
                    g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
                }


                else if (e.KeyCode == Keys.A && user.Wspx > 2)
                {

                    Invalidate();
                    user.moveleft();
                    g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
                }

                else if (e.KeyCode == Keys.S && user.Wspy < 524)
                {

                    Invalidate();
                    user.movedown();
                    g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
                }

                else if (e.KeyCode == Keys.D && user.Wspx < 704)
                {

                    Invalidate();
                    user.moveright();
                    g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
                }
                
            }

               


            }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
            foreach(Chest chest in skrzynki)
            {
                e.Graphics.DrawImage(new Bitmap("chest.png"), chest.Wspx, chest.Wspy);
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }





        
    }
        
       
    
