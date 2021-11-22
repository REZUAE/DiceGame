using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblPoint_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox5.Load(commonData.imgProfile1);
            pictureBox1.Load(commonData.imgProfile2);
            pictureBox2.Load(commonData.imgProfile3);
            pictureBox3.Load(commonData.imgProfile4);

        }
    }
}
