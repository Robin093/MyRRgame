using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace MyRRgame
{
    public class MyClass
    {
        int BulletFire;
        public void LoadGun() 
        {
            BulletFire = 6;
        }

        public int SpinGun()
        {
            Random rand = new Random();
            BulletFire = rand.Next(1, 7); 
            return BulletFire;
        }
        int BulletOut = 4; 
        public int FireGun()
        {// fire the bullet on head chances
            if (BulletFire == 1)
            {
                
                MessageBox.Show("You lose!! Play again?");
                Application.Restart();
            }
            else
            {
                BulletOut--;
                BulletFire--;
                
                if (BulletOut == 0)
                {
                    MessageBox.Show("You win");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            return BulletOut;
        }
        int FireAwayBullet = 2;
        public int FireAwayGun()
        {
            if (BulletFire == 1)
            {
                
                MessageBox.Show("Still Alive");
            }
            else
            {//fire away cances of the player
                FireAwayBullet--;
                BulletFire--;
                
                if (FireAwayBullet == 0)
                {
                    MessageBox.Show("Game Over");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Last Chance");
                }
            }

            return FireAwayBullet;
        }

    }
}


