using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using HtmlAgilityPack;
using System.Threading;

namespace DemoGetData
{
    public partial class Form1 : Form
    {
        private string m_data;
        private string m_xPath;
        private string m_Address;
        public Form1()
        {
            InitializeComponent();
            m_data = string.Empty;
            m_xPath = string.Empty;
            m_Address = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            dataResult.Text = string.Empty;
            m_Address = txtWeb.Text;
            //if (txtWeb.Text.Trim().Contains("https") == false)
            //{
            //    m_Address = "https://" + txtWeb.Text + "/";
            //}
           

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(m_Address);
            string getIdOrClass = string.Empty;
            if (radioId.Checked)
            {
                m_xPath = "//" + txtTag.Text + "[@id='" + txtIDDiv.Text + "']";
            }
            else
            {
                m_xPath = "//" + txtTag.Text + "[@class='" + txtClass.Text + "']";
            }
            //HtmlNode rateNode = doc.DocumentNode.SelectSingleNode("//" + txtTag.Text + "[@" + getIdOrClass + "='" + txtIDDiv.Text + "']");
            var titles = doc.DocumentNode.SelectNodes(m_xPath);
            if (titles != null)
            {
                foreach (var title in titles)
                {
                    m_data += title.InnerText + Environment.NewLine;
                }
            }
            dataResult.Text = m_data;


        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            // time consuming operation
            worker.ReportProgress(10, null);
            // ... another stuff
        }


        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }


    }

}
