using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;//allows the use of Thread.Sleep()
using System.Media;//allows the use of SoundPlayer

namespace SpringFieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it 

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);

            alertPlayer.Play();
            label4.BackColor = Color.Red;
            label5.BackColor = Color.Red;
            label6.Text = "Meltdown Imminent!";
            label6.ForeColor = Color.Red;
            label6.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.ForeColor = Color.White;
            label6.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.Red;
            label5.BackColor = Color.Red;
            label6.ForeColor = Color.Red;
            label6.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.ForeColor = Color.White;
            label6.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.Red;
            label5.BackColor = Color.Red;
            label6.ForeColor = Color.Red;
            label6.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.ForeColor = Color.White;
            label6.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.Red;
            label5.BackColor = Color.Red;
            label6.ForeColor = Color.Red;
            label6.BackColor = Color.White;

















        }
    }
}
