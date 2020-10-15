using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulinaKujawaHomework2
{
    class Bird : Creature
    {
        public Bird()
        {
        }
        // the bird will move with the spped 1
        public void Speed1(System.Windows.Forms.PictureBox picture)
        {
            Speed(picture);
        }
        // when bird flies up, it moves with the speed 3
        public void GoUp(System.Windows.Forms.PictureBox picture)
        {
            picture.Top -= 3;
        }
        // when bird flies down, it moves with the speed 3
        public void GoDown(System.Windows.Forms.PictureBox pictureAnimal)
        {
            pictureAnimal.Top += 3;
        }
    }
}
