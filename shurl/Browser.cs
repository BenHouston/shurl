using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            LinkMap.InitialiseTable();  // Initialises the Datatable on startup
        }

        private void GoTo_btn_Click(object sender, EventArgs e)
        {
            // Opens the 'Webpage' sending the web address as a string
            Webpage page = new Webpage(Address_txt.Text.ToLower());  // ToLower() to simplify any input validation on the other end
            DialogResult res = page.ShowDialog();
            if (res == DialogResult.No)
            {
                MessageBox.Show(page.Error);    // Fetch Error message from Webpage and display to user
            }
            // else OK, no action required
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
