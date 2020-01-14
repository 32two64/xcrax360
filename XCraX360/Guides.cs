using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCraX360
{
    public partial class Guides : Form
    {
        public Guides()
        {
            InitializeComponent();
        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consoles.Slim_S.SlimSGuides form = new Consoles.Slim_S.SlimSGuides();
            form.Show();
        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
