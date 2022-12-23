using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monkey_Fox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string url = urlbox.Text;
            if (url.Split('.')[0] == "www")
            {
                web.Navigate(url);
            }
            else
            {
                web.Navigate("https://www.google.com/search?q="+url);


            }
            
        }

        private void web_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void back_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void next_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void yt_Click(object sender, EventArgs e)
        {
            web.Navigate("www.youtube.com");
        }

        private void fb_Click(object sender, EventArgs e)
        {
            web.Navigate("www.facebook.com");
        }

        private void web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlbox.Text = web.Url.ToString();
        }
    }
}
