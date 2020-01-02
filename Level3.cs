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
    public partial class Level3 : Form
    {

        //public Chest(int height, int width, int Wspx, int Wspy)
        Graphics g;
        User user = new User();

        Chest chest1 = new Chest(50, 50, 100, 250);
        Chest chest2 = new Chest(50, 50, 100, 300);
        Chest chest3 = new Chest(50, 50, 100, 350);
        Chest chest4 = new Chest(50, 50, 100, 400);
        Chest chest5 = new Chest(50, 50, 100, 450);
        Chest chest6 = new Chest(50, 50, 100, 500);
        Chest chest7 = new Chest(50, 50, 100, 550);

        Chest chest8 = new Chest(50, 50, 300, 250);
        Chest chest9 = new Chest(50, 50, 300, 300);
        Chest chest10 = new Chest(50, 50, 300, 350);        
        Chest chest11 = new Chest(50, 50, 300, 400);
        Chest chest12 = new Chest(50, 50, 300, 450);
        Chest chest13 = new Chest(50, 50, 300, 500);
        Chest chest14 = new Chest(50, 50, 300, 550);

        Chest chest15 = new Chest(50, 50, 500, 250);
        Chest chest16 = new Chest(50, 50, 500, 300);
        Chest chest17 = new Chest(50, 50, 500, 350);
        Chest chest18 = new Chest(50, 50, 500, 400);
        Chest chest19 = new Chest(50, 50, 500, 450);
        Chest chest20 = new Chest(50, 50, 500, 500);
        Chest chest21 = new Chest(50, 50, 500, 550);

        Chest chest22 = new Chest(50, 50, 250, 350);
        Chest chest23 = new Chest(50, 50, 450, 400);
        Chest chest24 = new Chest(50, 50, 550, 500);




        List<Chest> skrzynki = new List<Chest>();

        Diamond diamond1 = new Diamond(50, 50, 500, 500);
        Diamond diamond2 = new Diamond(50, 50, 650, 210);
        Diamond diamond3 = new Diamond(50, 50, 200, 510);
        Diamond diamond4 = new Diamond(50, 50, 100, 200);
        //Znaki + -  
        Diamond diamond5 = new Diamond(50, 50, 200, 380);
        Diamond diamond6 = new Diamond(50, 50, 600, 400);
        Diamond diamond8 = new Diamond(50, 50, 300, 220);

        int counter = 45;
        public Level3()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();
            //skrzynki
            skrzynki.Add(chest1);
            skrzynki.Add(chest2);
            skrzynki.Add(chest3);
            skrzynki.Add(chest4);
            skrzynki.Add(chest5);
            skrzynki.Add(chest6);
            skrzynki.Add(chest7);
            skrzynki.Add(chest8);
            skrzynki.Add(chest9);
            skrzynki.Add(chest10);
            skrzynki.Add(chest11);
            skrzynki.Add(chest12);
            skrzynki.Add(chest13);
            skrzynki.Add(chest14);
            skrzynki.Add(chest15);
            skrzynki.Add(chest16);
            skrzynki.Add(chest17);
            skrzynki.Add(chest18);
            skrzynki.Add(chest19);
            skrzynki.Add(chest20);
            skrzynki.Add(chest21);
            skrzynki.Add(chest22);
            skrzynki.Add(chest23);
            skrzynki.Add(chest24);


            //Start Czasu 
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            Minutnik.Text = "00:" + counter.ToString();
            timer1.Start();

        }

        private void Level3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            diamentdel();
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Space)

            {
                label1.Text = " x =" + user.Imgx;
                label2.Text = " y = " + user.Imgy;
            }

            if (e.KeyCode == Keys.W && user.Wspy > 182)
            {
                bandy();
                user.moveup();
                g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
            }


            else if (e.KeyCode == Keys.A && user.Wspx > 2)
            {
                bandy();
                user.moveleft();
                g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
            }

            else if (e.KeyCode == Keys.S && user.Wspy < 524)
            {
                bandy();
                user.movedown();
                g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
            }

            else if (e.KeyCode == Keys.D && user.Wspx < 704)
            {
                bandy();
                user.moveright();
                g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
            }
            diamentdel();
            Invalidate();
        }

        private void Level3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
            foreach (Chest chest in skrzynki)
            {
                e.Graphics.DrawImage(new Bitmap("chest.png"), chest.Wspx, chest.Wspy, chest.width, chest.height);
            }

            e.Graphics.DrawImage(new Bitmap("3.png"), diamond1.Wspx, diamond1.Wspy, diamond1.width, diamond1.height);
            e.Graphics.DrawImage(new Bitmap("5.png"), diamond2.Wspx, diamond2.Wspy, diamond1.width, diamond1.height);
            e.Graphics.DrawImage(new Bitmap("7.png"), diamond3.Wspx, diamond3.Wspy, diamond1.width, diamond1.height);
            e.Graphics.DrawImage(new Bitmap("19.png"), diamond4.Wspx, diamond4.Wspy, diamond1.width, diamond1.height);
            //Plusy minusy
            e.Graphics.DrawImage(new Bitmap("plus.png"), diamond5.Wspx, diamond5.Wspy, diamond1.width, diamond1.height);
            e.Graphics.DrawImage(new Bitmap("plus.png"), diamond6.Wspx, diamond6.Wspy, diamond1.width, diamond1.height);

            e.Graphics.DrawImage(new Bitmap("minus.png"), diamond8.Wspx, diamond8.Wspy, diamond1.width, diamond1.height);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            bool b = false;
            if (counter >= 10)
            {
                Minutnik.Text = "00:" + counter.ToString();
            }

            else if (counter < 10 & counter > 0)
            {
                Minutnik.Text = "00:0" + counter.ToString();
                Minutnik.ForeColor = Color.Red;
            }
            else if (counter == 0)
            {
                Minutnik.Text = "00:00";
                timer1.Stop();
                b = true;
            }
            //PRZEGRANA na czas
            if (b == true)
            {
                Przegrana p = new Przegrana();
                p.Show();
                p.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
                this.Hide();
                timer1.Stop();
            }
        }


        public void bandy()
        {
            foreach (Chest chest in skrzynki)
            {
                int r1 = Math.Abs(user.Imgx - chest.Imgx);
                int r2 = Math.Abs(user.Imgy - chest.Imgy);

                if (r1 < 60 && r2 < 60)
                {
                    label1.Text = "bandy";
                }


            }

        }
        public string suma = "0";
        public void diamentdel()
        {
            if (user.Imgx == diamond1.Imgx && user.Imgy == diamond1.Imgy)
            {

                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 3;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond1.Imgx = 2000;
                    diamond1.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 3;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond1.Imgx = 2000;
                    diamond1.Wspx = 2000;
                }
            }
            if (user.Imgx == diamond2.Imgx && user.Imgy == diamond2.Imgy)
            {

                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 5;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond2.Imgx = 2000;
                    diamond2.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 5;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond2.Imgx = 2000;
                    diamond2.Wspx = 2000;
                }
            }
            if (user.Imgx == diamond3.Imgx && user.Imgy == diamond3.Imgy)
            {

                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 7;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond3.Imgx = 2000;
                    diamond3.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 7;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond3.Imgx = 2000;
                    diamond3.Wspx = 2000;
                }
            }
            if (user.Imgx == diamond4.Imgx && user.Imgy == diamond4.Imgy)
            {
                diamond4.Imgx = 2000;
                diamond4.Wspx = 2000;
                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 19;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond4.Imgx = 2000;
                    diamond4.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 19;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond4.Imgx = 2000;
                    diamond4.Wspx = 2000;
                }
            }
            // PLUSY
            if (user.Imgx == diamond5.Imgx && user.Imgy == diamond5.Imgy && znak.Text == " ")
            {
                diamond5.Imgx = 2000;
                diamond5.Wspx = 2000;
                znak.Text = "+";
            }
            if (user.Imgx == diamond6.Imgx && user.Imgy == diamond6.Imgy && znak.Text == " ")
            {
                diamond6.Imgx = 2000;
                diamond6.Wspx = 2000;
                znak.Text = "+";
            }
            // MINUSY
            if (user.Imgx == diamond8.Imgx && user.Imgy == diamond8.Imgy && znak.Text == " ")
            {
                diamond8.Imgx = 2000;
                diamond8.Wspx = 2000;
                znak.Text = "-";
            }

            // WYGRANA

            if (wynik.Text.Equals("20"))
            {
                Wygrana p = new Wygrana();
                p.Show();
                p.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
                this.Hide();
                timer1.Stop();
            }
            // PRZEGRANA - zly wynik
            if (diamond1.Wspx == 2000 && diamond2.Wspx == 2000 && diamond3.Wspx == 2000 && diamond4.Wspx == 2000 && wynik.Text != "20")
            {
                PrzegranaWynik p = new PrzegranaWynik();
                p.Show();
                p.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
                this.Hide();
                timer1.Stop();
            }
        }

        private void wynik_TextChanged(object sender, EventArgs e)
        {
            znak.Text = " ";
        }
    }
}
