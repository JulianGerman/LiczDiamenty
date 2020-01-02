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
    public partial class PrzegranaWynik : Form
    {
        public PrzegranaWynik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void PrzegranaWynik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
