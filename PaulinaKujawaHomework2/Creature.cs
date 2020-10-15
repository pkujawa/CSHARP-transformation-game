using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulinaKujawaHomework2
{
    abstract class Creature : Interface1
    {
            public Creature()
            {

            }
        // all creatures can move. Basic speed is equal to 1.
            public void Speed(System.Windows.Forms.PictureBox PictureAnimal)
            {
                PictureAnimal.Left += 1;
            }
    }
}
