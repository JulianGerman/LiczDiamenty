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
        public Level3()
        {
            InitializeComponent();
        }

        private void Level3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        
    }
}
