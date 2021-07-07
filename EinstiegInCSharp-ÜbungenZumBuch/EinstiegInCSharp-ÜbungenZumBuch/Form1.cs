using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EinstiegInCSharp_ÜbungenZumBuch
{
    public partial class Form1 : Form
    {
        double X = 0.0;
        double Y = 0.0;
        double Z = 0.0;

        public Form1()
        {
            InitializeComponent();}

        public void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "X: " + X + "\n" + "Y: " + Y;
        }

        private void anzeigen1_Click(object sender, EventArgs e)
        {
            X = X + 0.1;
            Y = Y + 0.1;
            label1.Text = "X: " + X + "\n" + "Y: " + Y;
        }

        private void anzeigen2_Click(object sender, EventArgs e)
        {
            X = X + 0.1;
            Z = Z + 0.1;
            label1.Text = "X: " + X + "\n" + "Z: " + Z;
        }
    }
}
