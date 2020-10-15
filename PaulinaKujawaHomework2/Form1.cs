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
    public partial class Form1 : Form
    {
        // defining new window
        FormEagle WindowEagle = new FormEagle();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEagle_Click(object sender, EventArgs e)
        {
            WindowEagle.Show();
            MessageBox.Show("Great. Now you should train your transforming skills and use them wisely to reach your destiny.");

        }

        private void buttonShark_Click(object sender, EventArgs e)
        {
            WindowEagle.Show();
            MessageBox.Show("It's an eagle! You have to train your transforming skills. Try to use them wisely to reach your destiny.");
        }

        private void buttonGepard_Click(object sender, EventArgs e)
        {
            WindowEagle.Show();
            MessageBox.Show("You were able to transform into an eagle for now. You have to train your transforming skills. Try to use them wisely to reach your destiny.");
        }
    }
}
