using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace diamenty0
{
    public partial class Level1 : Form
    {


        //public Chest(int height, int width, int Wspx, int Wspy)
        Graphics g;
        User user = new User();
        Chest chest1 = new Chest(50, 50, 100, 300);
        Chest chest2 = new Chest(50, 50, 100, 350);
        Chest chest3 = new Chest(50, 50, 100, 400);
        Chest chest4 = new Chest(50, 50, 100, 450);
        Chest chest5 = new Chest(50, 50, 300, 400);
        Chest chest6 = new Chest(50, 50, 350, 400);
        Chest chest7 = new Chest(50, 50, 400, 400);
        List<Chest> skrzynki = new List<Chest>();
        int counter = 15;






        public Level1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();
            skrzynki.Add(chest1);
            skrzynki.Add(chest2);
            skrzynki.Add(chest3);
            skrzynki.Add(chest4);
            skrzynki.Add(chest5);
            skrzynki.Add(chest6);
            skrzynki.Add(chest7);
            //Start Czasu 

            timer1 = new Timer();
            // timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // 1 second
            timer1.Start();
            Minutnik.Text = "00:" + counter.ToString();

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

            if (e.KeyCode == Keys.Space)

            {

                label1.Text = " x = " + roznica();
                label2.Text = " y = " + roznica();
            }

            if (e.KeyCode == Keys.W && user.Wspy > 182)
            {
                user.moveup();
                g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
                

            }


            else if (e.KeyCode == Keys.A && user.Wspx > 2)
            {
                user.moveleft();
                g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);

                

            }

            else if (e.KeyCode == Keys.S && user.Wspy < 524)
            {
                user.movedown();
                g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);

                

            }

            else if (e.KeyCode == Keys.D && user.Wspx < 704)
            {
                user.moveright();
                g.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);

                

            }
            Invalidate();
        }

        int roznica ()
            {
            foreach (Chest chest in skrzynki)
            {
                int r1 = Math.Abs(user.Imgx - chest.Imgx);
                return r1;
            }
           foreach(Chest chest in skrzynki)
            {
                int r2 = Math.Abs(user.Imgy - chest.Imgy);
                return r2;
            }
                return 0; 
            }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("5.png"), user.Wspx, user.Wspy, user.width, user.height);
            foreach (Chest chest in skrzynki)
            {
                e.Graphics.DrawImage(new Bitmap("chest.png"), chest.Wspx, chest.Wspy);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter > 0)
            {
                Minutnik.Text = "00:" + counter.ToString();
            }

            if (counter < 10 & counter > 0)
            {
                Minutnik.Text = "00:0" + counter.ToString();
                Minutnik.ForeColor = Color.Red;
            }
            if (counter == 0)
            {

                Minutnik.Text = "00:00";
            }


        }

        private void Minutnik_Click(object sender, EventArgs e)
        {

        }

        
                       
        }
    }    


   




        
    
        
       
    
