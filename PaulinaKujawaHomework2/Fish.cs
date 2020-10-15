using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulinaKujawaHomework2
{
    class Fish : Creature
    {
        public Fish()
        {

        }
        // fish moves with the spped 2
        public void Speed2(System.Windows.Forms.PictureBox PictureAnimal)
        {
            Speed(PictureAnimal);
            Speed(PictureAnimal);
        }
    }
}
