using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BrowSharp1
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        static string[] options;

        private void Options_Load(object sender, EventArgs e)
        {
//Load saved options
            options = File.ReadAllLines("options.bso");
            engineTextbox.Text = options[0];
            if(options[1] == "dark")
            {
                darkRadio.Checked = true;
            }
            else if(options[1] == "black")
            {
               blackRadio.Checked = true;
            }
            else
            {
               lightRadio.Checked = true;
            }
        }
//Cancel
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
//Save options
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string theme;
            if (lightRadio.Checked)
            {
                theme = "light";
            }
            else if (darkRadio.Checked)
            {
                theme = "dark";
            }
            else
            {
                theme = "black";
            }
            options[0] = engineTextbox.Text;
            options[1] = theme;
            File.Delete("options.bso");
            File.WriteAllLines("options.bso", options);
            Form1 browserForm = new Form1();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
