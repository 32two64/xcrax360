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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exit Button
        private void FlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Utilities Button
        private void FlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Guides Button
        private void FlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guides form = new Guides();
            form.Show();
        }
    }
}
