using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCraX360.Consoles.Slim_S
{
    public partial class HardModdingSlimS : Form
    {
        public HardModdingSlimS()
        {
            InitializeComponent();
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }
            else if (checkBox2.Checked == true)
            {

            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("You must select only your conosle type, not both.", "Uh-Oh");
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("You must select your console type to continue.", "Uh-Oh");
            }
        }
    }
}
