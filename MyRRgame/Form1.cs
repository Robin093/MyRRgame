using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyRRgame
{
    public partial class Form1 : Form
    {
        MyClass logic = new MyClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MyRRgame.Resource1.load;
            SoundPlayer sc = new SoundPlayer(MyRRgame.Resource1.loadvoice);
            sc.Play();//put a sound
            
            logic.LoadGun();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            Load.Enabled = true;
            pictureBox1.Image = MyRRgame.Resource1.spin;
            SoundPlayer sc = new SoundPlayer(MyRRgame.Resource1.spinvoice);
            sc.Play();
            Fire.Enabled = true;
            FireAway.Enabled = true;
            logic.SpinGun();// calling the function to work
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MyRRgame.Resource1.fire;
            SoundPlayer sc = new SoundPlayer(MyRRgame.Resource1.firevoice);
            sc.Play();
            int chances = logic.FireGun();
        }

        private void FireAway_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = MyRRgame.Resource1.fireaway;
            SoundPlayer sc = new SoundPlayer(MyRRgame.Resource1.firevoice);
            sc.Play();
            int ChancesAway = logic.FireAwayGun();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
