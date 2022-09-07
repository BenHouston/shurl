using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shurl
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void GoTo_btn_Click(object sender, EventArgs e)
        {
            Webpage page = new Webpage(Address_txt.Text);
            DialogResult res = page.ShowDialog();
            if (res == DialogResult.No)
            {
                MessageBox.Show("Error: Address is not valid.");
            }
            else if (res == DialogResult.Abort)
            {
                MessageBox.Show("Error: Link not found.");
            }
            // else OK, no action required
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
