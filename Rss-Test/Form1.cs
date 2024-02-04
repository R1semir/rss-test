using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;
namespace Rss_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string link;
        void rssdenadresegit()
        {
            listBox1.Items.Clear();
            XmlTextReader oku = new XmlTextReader(link);
            while (oku.Read())
            {
                if (oku.Name == "title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }
        }

        private void btnHürriyet_Click(object sender, EventArgs e)
        {
            
            link = "https://www.ntv.com.tr/gundem.rss";
            rssdenadresegit();
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            link = "http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml";
            rssdenadresegit();
        }

        private void btnNtv_Click(object sender, EventArgs e)
        {
            link = "https://www.ntv.com.tr/gundem.rss";
            rssdenadresegit();

        }
    }
}
