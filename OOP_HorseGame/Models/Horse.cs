using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HorseGame.Models
{
    public class Horse
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public PictureBox PictureBox { get; set; }
        public int EkstraPoint { get; set; }
        public Color HipodromBackground { get; set; }
        public bool Injured { get; set; }
        public int InjuredNumber { get; set; }

        public Horse(string name,int speed, PictureBox pictureBox,Color color, int injuredNumber)
        {
            Name = name;
            Speed = speed;
            PictureBox = pictureBox;
            HipodromBackground = color;
            InjuredNumber = injuredNumber;
        }

        public void CheckAndHandleInjury()
        {
            if (!Injured)
            {
                Random random = new Random();
                int getRandomNumber = random.Next(1, 500);

                if (getRandomNumber == InjuredNumber)
                {
                    PictureBox.Visible = false;
                    Injured = true;
                    MessageBox.Show($"{Name} maalesef sakatlandı. Yarışa devam edemeyecek!");
                }
            }
        }
    }
}
