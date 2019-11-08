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
        
        private void pictureBox2_Click(object sender, EventArgs e) // level 1 
        {
            Level1 l1 = new Level1();
            l1.Show();
            l1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();      

            
           

        }

        private void pictureBox4_Click_1(object sender, EventArgs e) // level 2 
        {
            Level2 l2 = new Level2();
            l2.Show();
            l2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e) // level 3
        {
            Level3 l3 = new Level3();
            l3.Show();
            l3.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

       
    }
}
