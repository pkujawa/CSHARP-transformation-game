using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PaulinaKujawaHomework2
{
    public partial class FormEagle : Form
    {
        //defining new window
        Form2 WindowEnd = new Form2();
        // creating new elements for classes
        Bird ptak = new Bird();
        Fish ryba = new Fish();
        Gepard kot = new Gepard();
        bool one = false;
        bool two = false;
        bool three = false;
        bool four = false;
        bool five = false;
        int t = 0;
        public FormEagle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureAnimal.Image = ((System.Drawing.Image)(pictureEagle.Image));
        }

        private void FormEagle_Load(object sender, EventArgs e)
        {
            pictureAnimal.Image = pictureEagle.Image;
        }

    private void timer1_Tick(object sender, EventArgs e)
        {
            t ++ ;
            if (pictureAnimal.Left == -60 && one == false)
            {
                one = true;
                MessageBox.Show("Look! The landscape contains environment suitable for each of your forms. Which one of them can travel faster?");
            }
            if (pictureAnimal.Left >= 150 && two == false)
            {
                two = true;
                MessageBox.Show("These mountains are so high! Only a bird can get through that landscape.");
            }
            if (pictureAnimal.Left >= 460 && three == false)
            {
                three = true;
                MessageBox.Show("That waterfall is to narrow for a shark. But you can always fly or run above it.");
            }
            if (pictureAnimal.Left >= 600 && four == false)
            {
                four = true;
                MessageBox.Show("Your destiny is behind the ocean.");
            }
            if (pictureAnimal.Left >= 890 && five == false)
            {
                five = true;
                MessageBox.Show(String.Format("You made it in {0} seconds", (t/8).ToString()));
                WindowEnd.Show();
            }
            // on that area all creatures can move but with different speed
            if (pictureAnimal.Left <= 150)
            {
                if  (pictureAnimal.Image == pictureEagle.Image)
                {
                    ptak.Speed(pictureAnimal);
                }
                if (pictureAnimal.Image == pictureShark.Image)
                {
                    ryba.Speed2(pictureAnimal);
                }
                if (pictureAnimal.Image == pictureGepard.Image)
                {
                    kot.Speed3(pictureAnimal);
                }
            }
            // on that area only bird can move with function of speed and GoUp
            if (pictureAnimal.Image == pictureEagle.Image && pictureAnimal.Left >= 150 && pictureAnimal.Top >= -10 && pictureAnimal.Left <= 400)
            {
                ptak.GoUp(pictureAnimal);
                ptak.Speed(pictureAnimal);
            }
            // on that area only bird can fly - with the speed 1
            if (pictureAnimal.Image == pictureEagle.Image && pictureAnimal.Top <= -5 && pictureAnimal.Left <= 400)
            {
                    ptak.Speed(pictureAnimal);
            }
            // on that area bird flies down with the spped of 1 left and 3 down
            if (pictureAnimal.Image == pictureEagle.Image && pictureAnimal.Left >=400 && pictureAnimal.Left <=460)
            {
                ptak.Speed(pictureAnimal);
                ptak.GoDown(pictureAnimal);
            }
            // on that area gepard and bird can move
            if (pictureAnimal.Left >= 460 && pictureAnimal.Left <= 600 && pictureAnimal.Image != pictureShark.Image)
            {
                if (pictureAnimal.Image == pictureEagle.Image)
                {
                    ptak.Speed(pictureAnimal);
                }
                if (pictureAnimal.Image == pictureGepard.Image)
                {
                    kot.Speed3(pictureAnimal);
                }
            }
            // on that area shark and bird can move
            if (pictureAnimal.Left >= 600)
            {
                if (pictureAnimal.Image == pictureEagle.Image)
                {
                    ptak.Speed(pictureAnimal);
                }
                if (pictureAnimal.Image == pictureShark.Image)
                {
                    ryba.Speed2(pictureAnimal);
                }
            }
        }
        private void buttonShark2_Click(object sender, EventArgs e)
        {
            pictureAnimal.Image = ((System.Drawing.Image)(pictureShark.Image));
        }

        private void buttonGepard2_Click(object sender, EventArgs e)
        {
            pictureAnimal.Image = ((System.Drawing.Image)(pictureGepard.Image));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
