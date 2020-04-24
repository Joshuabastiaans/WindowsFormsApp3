using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUrl.Text))
                webBrowser.Navigate(txtUrl.Text);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void txtUrl_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyPress != (char)13)
            {
                return;
            }
            webBrowser.Navigate(txtUrl.Text);
        }
    }
}
