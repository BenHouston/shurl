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
    public partial class Webpage : Form
    {
        // Leaving these commented to show/talk about a failed attempt...
        //private char[] ASCIImap = new char[47]
        //    { '.', '/', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 
        //    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '$', '-', '_', '+', '!', '*', '(', ')', ','  };

        //private char[] Base62map = new char[64]
        //    { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 
        //    's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
        //    'U', 'V', 'W', 'X', 'Y', 'Z', '-', '+'};

        public Webpage(string address)
        {
            InitializeComponent();
        }

        private void Webpage_Load(object sender, EventArgs e)
        {
            LinkMap.InitialiseTable();
        }

        private void Convert_btn_Click(object sender, EventArgs e)
        {
            ShortLink_txt.Text = LongtoShort(LongLink_txt.Text);
        }

        private string LongtoShort(string longaddr)
        {
            // ToDo...
            // implement conversion of long address to short address
            return "Not yet implemented...";
        }
    }
}
