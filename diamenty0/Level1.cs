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
        Chest chest1 = new Chest(50, 50, 150, 300);
        Chest chest2 = new Chest(50, 50, 100, 300);
        Chest chest3 = new Chest(50, 50, 50, 300);
        Chest chest4 = new Chest(50, 50, 0, 300);


        Chest chest7 = new Chest(50, 50, 100, 500);
        Chest chest8 = new Chest(50, 50, 50, 500);
        Chest chest9 = new Chest(50, 50, 0, 500);

        Chest chest10 = new Chest(50, 50, 300, 450);
        Chest chest5 = new Chest(50, 50, 300, 500);
        Chest chest6 = new Chest(50, 50, 300, 400);
        Chest chest11 = new Chest(50, 50, 300, 350);
        Chest chest12 = new Chest(50, 50, 300, 300);

        Chest chest13 = new Chest(50, 50, 350, 300);
        Chest chest14 = new Chest(50, 50, 400, 300);
        Chest chest15 = new Chest(50, 50, 450, 300);

        Chest chest16 = new Chest(50, 50, 450, 350);
        Chest chest17 = new Chest(50, 50, 350, 500);
        Chest chest18 = new Chest(50, 50, 500, 350);
        Chest chest19 = new Chest(50, 50, 450, 350);

        


        List<Chest> skrzynki = new List<Chest>();

        Diamond diamond1 = new Diamond(50, 50, 500, 500);
        Diamond diamond2 = new Diamond(50, 50, 650, 210);
        Diamond diamond3 = new Diamond(50, 50, 200, 510);
        Diamond diamond4 = new Diamond(50, 50, 100, 200);
        //Znaki + -  
        Diamond diamond5 = new Diamond(50, 50, 200, 380);
        Diamond diamond6 = new Diamond(50, 50, 600, 400);        
        Diamond diamond8 = new Diamond(50, 50, 300, 220);
      
        int counter = 90;

        public Level1()
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


            //Start Czasu 
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            Minutnik.Text = "00:" + counter.ToString();
            timer1.Start();
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            diamentdel();
            bandy();

                 if (e.KeyCode == Keys.Escape)
                 {
                    Application.Exit();
                 }
 
                if (e.KeyCode == Keys.Up && user.Wspy > 182)
                {                      
                    user.moveup();
                    g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
                }
                else if (e.KeyCode == Keys.Left && user.Wspx > 2)
                {                                     
                    user.moveleft();
                    g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
                }

                else if (e.KeyCode == Keys.Down && user.Wspy < 524)
                {                      
                    user.movedown();
                    g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
                }

                else if (e.KeyCode == Keys.Right && user.Wspx < 704)
                {                       
                    user.moveright();
                    g.DrawImage(new Bitmap("user.png"), user.Wspx, user.Wspy, user.width, user.height);
                }
            diamentdel();
            Invalidate();         
        }

            

       

        private void Level1_Paint(object sender, PaintEventArgs e)
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
            Minutnik.Visible = true;
            counter--;
            bool b = false;
            if ( counter >=70)
            {
               int buf = counter - 60;
               Minutnik.Text = "01:" + buf.ToString();
            }
            else if ( counter >= 60 && counter <=70)
            {
                int buf = counter - 60;
                Minutnik.Text = "01:0" + buf.ToString();
            }
            else if (counter >= 10 && counter < 60)
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
                b = true ;
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
               
                int r = user.Wspx - chest.Wspx;
                int rr = chest.Wspx - user.Wspx;
                int d = user.Wspy - chest.Wspy;
                int dd = chest.Wspy - user.Wspy;
                // Prawy dolny rog 
                if (user.Wspx >= chest.Wspx && user.Wspy >=chest.Wspy)
                {
                    if (r<=50 && d<=50)
                    {
                        user.Wspx = user.Wsprx;
                        user.Wspy = user.Wspry;
                    }
                }
                //Prawy gorny rog 
                else if (user.Wspx >= chest.Wspx && user.Wspy <= chest.Wspy)
                {
                    if (r<=50 && dd<=50)
                    {
                        user.Wspx = user.Wsprx;
                        user.Wspy = user.Wspry;
                    }
                }
                //Lewy dolny rog 
                else if (user.Wspx <= chest.Wspx && user.Wspy >= chest.Wspy)
                {
                    if (rr<=50 && d<=50)
                    {
                        user.Wspx = user.Wsprx;
                        user.Wspy = user.Wspry;
                    }
                }
                //Lewy gorny rog 
                else if (user.Wspx <= chest.Wspx && user.Wspy <= chest.Wspy)
                {
                    if (rr<=50 && dd <=50)
                    {
                        user.Wspx = user.Wsprx;
                        user.Wspy = user.Wspry;
                    }
                }

      

            }
        }
        public string suma = "0";  
        public void diamentdel()
        { 
            if (user.Wspx == diamond1.Wspx && user.Wspy == diamond1.Wspy)
            {
                
                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 3;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond1.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 3;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond1.Wspx = 2000;
                }
            }
            if (user.Wspx == diamond2.Wspx && user.Wspy == diamond2.Wspy)
            { 
                
                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 5;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond2.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 5;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond2.Wspx = 2000;
                }
            }
            if (user.Wspx == diamond3.Wspx && user.Wspy == diamond3.Wspy)
            {
                
                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 7;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond3.Wspx = 2000;
                }
                else if(znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 7;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond3.Wspx = 2000;
                }
            }
            if (user.Wspx == diamond4.Wspx && user.Wspy == diamond4.Wspy)
            {
                if (znak.Text.Equals("-"))
                {
                    int buf = Int32.Parse(suma);
                    buf -= 19;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond4.Wspx = 2000;
                }
                else if (znak.Text.Equals("+"))
                {
                    int buf = Int32.Parse(suma);
                    buf += 19;
                    suma = Convert.ToString(buf);
                    wynik.Text = suma;
                    diamond4.Wspx = 2000;
                }
            }
            // PLUSY
            if (user.Wspx == diamond5.Wspx && user.Wspy == diamond5.Wspy && znak.Text == " ")
            {
                diamond5.Wspx = 2000;
                znak.Text = "+";    
            }
            if (user.Wspx == diamond6.Wspx && user.Wspy == diamond6.Wspy && znak.Text == " ")
            {
                diamond6.Wspx = 2000;
                znak.Text = "+";
            }  
            // MINUSY
            if (user.Wspx == diamond8.Wspx && user.Wspy == diamond8.Wspy && znak.Text == " ")
            {
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
     


   




        
    
        
       
    
