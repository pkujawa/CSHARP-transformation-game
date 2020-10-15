using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulinaKujawaHomework2
{
    class Gepard : Creature
    {
        public Gepard()
        {
      
        }
        public void Speed3(System.Windows.Forms.PictureBox PictureAnimal)
        {
            Speed(PictureAnimal);
            Speed(PictureAnimal);
            Speed(PictureAnimal);
        }
    }
}
