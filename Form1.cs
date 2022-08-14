using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using System.IO;

namespace BrowSharp1
{
    public partial class Form1 : Form
    {
        static string[] options;
        static string[] defaultOptions = {"https://www.google.com/search?q=", "light"};
        static bool searchBoxClicks = false;
        public Form1()
        {
            InitializeComponent();
//Theme
            Read:
            try
            {
                options = File.ReadAllLines("options.bso");
            }
            catch
            {
                File.Create("options.bso");
                File.WriteAllLines("options.bso", defaultOptions);
            }
            if (options[1] == "dark")
            {
                BackColor = Color.DimGray;
                textBox1.BackColor = Color.Gray;
                goto Read;
            }
            else if (options[1] == "black")
            {
                BackColor = Color.Black;
                textBox1.BackColor = Color.DimGray;
                Image backImg = Image.FromFile(@"img\backW.png");
                Image forwardImg = Image.FromFile(@"img\forwardW.png");
                Image refreshImg = Image.FromFile(@"img\refreshW.png");
                Image optionsImg = Image.FromFile(@"img\settingsW.png");
                backBtn.Image = backImg;
                forwardBtn.Image = forwardImg;
                refreshBtn.Image = refreshImg;
                optionsBtn.Image = optionsImg;
            }
            else if (options[1] == "light")
            {
                textBox1.BackColor = Color.LightGray;
            }
            else
            {
                BackColor = Color.White;
                options[1] = "light";
                File.Delete("options.bso");
                File.WriteAllLines("options.bso", defaultOptions);
            }
            chromiumWebBrowser1.Load("https://www.google.com");
        }
//Key Down
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            UriKind uriKind = UriKind.RelativeOrAbsolute;
            if (e.KeyCode == Keys.Enter && ((Uri.IsWellFormedUriString(textBox1.Text, uriKind) && textBox1.Text.Contains('.')) || textBox1.Text.Contains(@":\")))
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                chromiumWebBrowser1.Load(options[0] + textBox1.Text.Replace(' ', '+'));
            }
        }
//Control Buttons
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoBack)
            {
                chromiumWebBrowser1.Back();
            }
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoForward)
            {
                chromiumWebBrowser1.Forward();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Refresh();
        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = chromiumWebBrowser1.Address;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(!searchBoxClicks)
            {
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
                searchBoxClicks = true;
            }
            else
            {
                searchBoxClicks = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            searchBoxClicks = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchBoxClicks = false;
        }
    }
}
