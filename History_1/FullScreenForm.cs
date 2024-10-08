using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History_1
{
    public partial class FullScreenForm : Form
    {
        public FullScreenForm(Image image, string NamePic)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            label1.Text = NamePic;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
