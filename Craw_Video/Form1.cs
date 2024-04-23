using Craw_Video.Controller;
using Craw_Video.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craw_Video
{
    public partial class Form1 : Form
    {
        private string TypeRadioWebsite = "";
        private string endcusor = "";
        private bool isNextPage = true;
        private int demSl = 0;
        public Form1()
        {
            Chilkat.Global glob = new Chilkat.Global();
            bool success = glob.UnlockBundle("ADSVN8.CBX1124_zUkOHNdJpY9b");
            TypeRadioWebsite = "inspireuplift";
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            demSl = 0;
            Rundownload(RegexShopName());
        }
        public string RegexShopName()
        {
            string linkShop = txtLink.Text.Trim();

            string shopName = "";
            string pattern = @"(?:instagram.com\/)([^?]+)";

            Match match = Regex.Match(linkShop, pattern);

            if (match.Success)
            {
                shopName = match.Groups[1].Value;
            }
            if(shopName.Split('/').Length > 1)
            {
                shopName = shopName.Split('/')[0];
            }
            return shopName;
        }
        public void Rundownload(string username)
        {
            Thread thread = new Thread(() =>
            {
                string id_user = Instargram_Viewer.GetId_User(username);
                if(id_user == "")
                {
                    MessageBox.Show("Error!");
                    return;
                }
                List<string> urls = Instargram_Viewer.Get_Urls_Video(id_user);
                DownloadFiles(urls, txtPathSave.Text.Trim(), username);
                
                while (Instargram_Viewer.isNext == true && Instargram_Viewer.encursor != "")
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        lbStatus.Text = "SLEEP GET URL 10 giay ";
                    }));
                    Thread.Sleep(10000);
                    urls = Instargram_Viewer.Get_Urls_Video(id_user, Instargram_Viewer.isNext, Instargram_Viewer.encursor);
                    DownloadFiles(urls, txtPathSave.Text.Trim(), username);
                }
                
                Thread.Sleep(10000);
                MessageBox.Show("Done");
            });
            thread.IsBackground = true;
            thread.Start(); 

        }
        public  void DownloadFiles(List<string> videoUrls, string savePath,string username)
        {
            try
            {
                savePath = savePath + "\\" + username;
                if (!Directory.Exists(savePath))
                {
                    // Create the folder.
                    Directory.CreateDirectory(savePath);
                }
                foreach (string url in videoUrls)
                {
                    demSl++;
                    Invoke(new MethodInvoker(() =>
                    {
                        lbStatus.Text = "Download Done: " + demSl;
                        rtbLog.SelectionColor = Color.Black;
                        rtbLog.AppendText("running download : " + url + "\n");
                    }));


                    TimeSpan myDateResult = DateTime.Now.TimeOfDay;
                    bool isDownload = DownloadFile(url, savePath + "\\" + myDateResult.Ticks.ToString() + ".mp4");


                    Invoke(new MethodInvoker(() =>
                    {
                        if(isDownload)
                        {
                            rtbLog.SelectionColor = Color.Black;
                            rtbLog.AppendText("download done --------> \n\n ");
                        }
                        else
                        {
                            demSl -= 1;
                            rtbLog.SelectionColor = Color.Red;
                            rtbLog.AppendText("download ERROR --------> \n ");
                        }
                        
                    }));
                }
            }
            catch (Exception ex)
            {

            }
        }
        public  bool DownloadFile(string url, string savePath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, savePath);
                }
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPathSave.Text = "";
                    txtPathSave.Text = fbd.SelectedPath;
                }
            }
        }
        

    }
}
