using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CnnLib;
using PlugInProxy;
using MilliyetLib;

using System.Threading;

namespace Xml_RSS_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void txtRssAdresi_TextChanged(object sender, EventArgs e)
        {

        }

        CnnMethods cnn = new CnnMethods();
        MilliyetMethods milliyet = new MilliyetMethods();

        private Thread cnnThread;

        private void btnCek_Click(object sender, EventArgs e)
        {
            switch (cbRSSAdresleri.Text)
            {
                case "CNN TURK":
                    {
                        cnnThread = new Thread(cnnDoldur);
                        cnnThread.Start();
                    }
                    break;

                case "Milliyet":
                    {
                        cnnThread = new Thread(milliyetDoldur);
                        cnnThread.Start();
                    }
                    break;
                default:
                    break;
            }

           
        }

        private void cnnDoldur()
        {
            lstwHaberler.Items.Clear();
            foreach (var cnnModel in cnn.GetNews())
            {
                Thread.Sleep(100);

                ListViewItem li = new ListViewItem();
                li.Text = cnnModel.Title;
                li.SubItems.Add(cnnModel.Source);
                li.SubItems.Add(cnnModel.Link);

                lstwHaberler.Items.Add(li);

                toolStripStatusLabel1.Text = lstwHaberler.Items.Count.ToString();
            }

            toolStripStatusLabel1.Text = lstwHaberler.Items.Count + " adet haber listelenmiştir.";
        }

        private void milliyetDoldur()
        {
            lstwHaberler.Items.Clear();

            foreach (var mil in milliyet.GetNews())
            {
                Thread.Sleep(100);
                ListViewItem li = new ListViewItem();
                li.Text = mil.Title;
                li.Tag = mil.Source;
                li.SubItems.Add(mil.Source);
                li.SubItems.Add(mil.Link);
                lstwHaberler.Items.Add(li);

                toolStripStatusLabel1.Text = lstwHaberler.Items.Count.ToString();
            }

            toolStripStatusLabel1.Text = lstwHaberler.Items.Count + " adet haber listelenmiştir.";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cnnThread.ThreadState == ThreadState.Running)
            {
                cnnThread.Abort();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string description;
        public static string link;

        private void lstwHaberler_Click(object sender, EventArgs e)
        {
            IList<CnnModel> allNewsCNN = cnn.GetNews();
            IList<MilliyetModel> allNewsMilliyet = milliyet.GetNews();
            var selectedTitle = lstwHaberler.SelectedItems[0].Text;
            var selectedSource = lstwHaberler.SelectedItems[0].SubItems[1].Text;

            if (selectedSource == "Milliyet")
            {
                var selectedNewsMilliyet = allNewsMilliyet
                    .Where(a => a.Title == selectedTitle)
                    .FirstOrDefault() as MilliyetLib.MilliyetModel;

                description = selectedNewsMilliyet.Description;
                link = selectedNewsMilliyet.Link;

            }
            else if (selectedSource == "CNN Turk")
            {
                var selectedNewsCNN = allNewsCNN
                    .Where(a => a.Title == selectedTitle)
                    .FirstOrDefault() as CnnLib.CnnModel;

                description = selectedNewsCNN.Description;
                link = selectedNewsCNN.Link;

            }

            frm_Description desc = new frm_Description();
            desc.Show();

        }

        private void cbRSSAdresleri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
