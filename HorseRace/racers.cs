using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class racers
    {
        public PictureBox Horses;
        public Random Randomizer;
        public int Startpos;


        public bool HorseRun()
        {
            Horses.Left += Randomizer.Next(4);
            if(Horses.Left >= Horses.Parent.Width - Horses.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Horsesstartline()
        {
            Horses.Left = Startpos;
        }
    }
}
