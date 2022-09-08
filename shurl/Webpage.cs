using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;

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

        public string Error = "";
        private string Address;

        public Webpage(string address)
        {
            InitializeComponent();
            Address = address;  // Stores adress as a global so that Webpage_Load can use it
        }

        private void Webpage_Load(object sender, EventArgs e)
        {
            // If a shortlink was used...
            string regEx = @"^shurl.com/.+";
            if (Regex.IsMatch(Address, regEx))
            {
                string code = Address.Split('/')[1];
                string link = LinkMap.GetLongLink(code);
                if (link == "na")   // GetLongLink will return "na" when code is not found in table
                {
                    Error = "Error: Link not found";
                    DialogResult = DialogResult.No;
                    Close();
                    return;
                }
                else
                {
                    System.Diagnostics.Process.Start(link); // Opens Web address in default browser
                    Close();
                    return;
                }
            }
            // If web address does not match our website...
            regEx = @"^(https://)?(www.)?shurl.com/?$";
            if (!Regex.IsMatch(Address, regEx))
            {
                Error = "This 'browser' can only display the shurl.com website";
                DialogResult = DialogResult.No;
                Close();
            }
            // else the address was shurl.com and no action is needed, so proceed to display window
        }

        private void Convert_btn_Click(object sender, EventArgs e)
        {
            string shortaddr = LinkMap.GetShortLink(LongLink_txt.Text); 
            // Currently no error checking in conversion. It will save any link in the table and return a corresponding code
            ShortLink_txt.Text = "shurl.com/" + shortaddr;
        }

        private void Copy_btn_Click(object sender, EventArgs e)
        {
            // Just a little added convenience for the user
            Clipboard.SetText(ShortLink_txt.Text);
            ShortLink_txt.SelectAll();
        }
    }
}
