using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulete
{
    public partial class Form1 : Form
    {
        ShootingClass SClass = new ShootingClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //play loading sound

            //show loading image

            //call the function from class to load the bullet in a position
        }

        private void SpinBtn_Click(object sender, EventArgs e)
        {
            //play spinning sound

            //show spinning sound

            //call the function from class to spin the bullet's position
            SClass.SpinChamber();
        }

        private void ShootBtn_Click(object sender, EventArgs e)
        {
            //play spinning sound

            //show spinning sound

            //call the shooting function
        }

        private void ShAwayBtn_Click(object sender, EventArgs e)
        {
            //play spinning sound

            //show spinning sound

            //call the shooting away function
        }
    }
}
