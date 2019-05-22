using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiIsg
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        static int schedInt = 10;
        DateTime next = DateTime.Now;
        fileMan fman = new fileMan();
        wsClass wsf = new wsClass();
        string inbox, outbox, succcess, error;

        public Main()
        {
            InitializeComponent();

        }
        private void reloadini()
        {
            INIFile ini = new INIFile(@"C:\tes\setting\config.ini");
            inbox = ini.Read("Direktori", "Inbox");
            outbox = ini.Read("Direktori", "Outbox");
            succcess = ini.Read("Direktori", "Success");
            error = ini.Read("Direktori", "Error");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            reloadini();

            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            // t.Start();  //this will use t_Tick() method
            button1.Hide();
            button4.Hide();
            button2.Hide();
            button3.Hide();
        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            string log = "";
            int jum = 0;

            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = jamText(hh.ToString() + ":" + mm.ToString() + ":" + ss.ToString());

            //update label
            txtJam.Text = time;

            if (next < DateTime.Now)
            {
                
                jum = fman.cekDir(inbox);
                log = "[" + DateTime.Now.ToString("HH:MM:ss") + "]  " + jum.ToString() + " files on Inbox";
                updateLog(log);

                if (jum > 0)
                {
                    //konversi
                    string[] files = fman.getFile(inbox);
                    if (files != null && files.Length > 0)
                    {
                        foreach (string i in files)
                        {
                            int conFile = fman.xlsToTxt(i, "xlsx");

                            if (conFile > 0)
                            {
                                fman.moveFile(i, error);
                                log = "[" + DateTime.Now.ToString("HH:MM:ss") + "]  " + conFile.ToString() + " new files Converted";
                                updateLog(log);
                            }
                            else
                            {
                                fman.moveFile(i, error);
                            }
                        }
                    }
                }

                int jumOut = fman.cekDir(outbox);
                log = "[" + DateTime.Now.ToString("HH:MM:ss") + "]  " + jumOut.ToString() + " files on Outbox";
                updateLog(log);

                if (jumOut > 0)
                {
                    string[] files = fman.getFile(outbox);
                    string pes = "";
                    string[] fName = null;
                    if (files != null && files.Length > 0)
                    {
                        foreach (string i in files)
                        {
                            pes = wsf.invokeProd("", "", i);
                            //pes = wsf.invokeProdUoi("", "", i);
                            string[] has = pes.Split('|');
                            fName = i.Split('\\');
                            string namaFile = fName[fName.Length - 1];
                            System.Console.WriteLine(namaFile + " " + pes);
                            log = "[" + DateTime.Now.ToString("HH:MM:ss") + "]  " + namaFile + " " + pes;
                            updateLog(log);

                            if (has[0] == "failed")
                            {
                                fman.moveFile(i, error);
                            }
                            else
                            {
                                fman.moveFile(i, succcess);
                            }
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }

                next = DateTime.Now.AddSeconds(schedInt);
                txtNext.Text = jamText(next.Hour.ToString() + ":" + next.Minute.ToString() + ":" + next.Second.ToString());
            }
        }

        private void updateLog(string log)
        {
            string lognew = "";
            lognew = log + Environment.NewLine;
            txtLog.Text = lognew + txtLog.Text;
        }

        private string jamText(string jam)
        {
            string jamNew = "";
            string bgJam = "";
            string[] arjam = jam.Split(':');
            foreach(string spJam in arjam)
            {
                if (spJam.Length <= 1)
                {
                    bgJam = "0" + spJam;
                }
                else
                {
                    bgJam = spJam;
                }
                jamNew = jamNew + bgJam + ":";
            }
            jamNew = jamNew.Remove(jamNew.Length - 1);
            return jamNew;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var ws = new wsClass();
            string pesan = ws.cekLogin("","");
            MessageBox.Show(pesan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fm = new fileMan();
            

            var ws = new wsClass();
            string[] pesan = fm.getFile(outbox);
            string pes = ws.invokeProd("", "", pesan[0]);
            MessageBox.Show(pes);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fm = new fileMan();
            //int jum = fm.jumlah("c:\\tes\\MB51Jan-Apr.xlsx", "xlsx");
            //MessageBox.Show(jum.ToString()); 
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDirInput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog brFolder = new FolderBrowserDialog();
            DialogResult result = brFolder.ShowDialog();
            if (!string.IsNullOrWhiteSpace(brFolder.SelectedPath))
            {
               // txtDirInput.Text = brFolder.SelectedPath;
            }
        }


        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            reloadini();
            button1.Hide();
            button4.Hide();
            string gel = btnStart.Text;
            
            if (gel == "Start")
            {
                t.Start();
                next=DateTime.Now.AddSeconds(schedInt);
                txtNext.Text = jamText(next.Hour.ToString()+":" + next.Minute.ToString()+":" + next.Second.ToString());
                btnStart.Text = "Stop";
            }
            else
            {
                t.Stop();
                btnStart.Text = "Start";
            }
            
        }

        private void schedullerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //showPanel(pnScheduller);
        }

        private void showPanel(Panel panelName)
        {
            hidePanel();
            panelName.Show();
        }

        private void hidePanel()
        {
            pnHome.Hide();
            pnScheduller.Hide();
            pnSetting.Hide();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //showPanel(pnHome);
        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //showPanel(pnSetting);
            Setting f3 = new Setting();
            f3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            konversi kon = new konversi();
            wsClass ws = new wsClass();
            //string str = ws.cekLogin("adminkomdn", "ediimdn");
            string str = ws.cekLoginUoi("adminuoi", "adminuoi1");

            //string str = kon.strToTxt("5659|9033|2019|9533156626|4|01.01.2019||01.01.2019||996001665|21105542|SODIUM ISETHIONATE AQUEOUS SOLUTION 57%|-14.076.900|261|KG|01.01.2019|AMRULLA_Y500|T73A||03:11:33|||||");
            MessageBox.Show(str);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var fm = new fileMan();
            List<string> jum = fm.jumlah("c:\\tes\\xls\\tes.xlsx", "xlsx");
            jum.ForEach(el => Console.WriteLine(el));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var fm = new fileMan();
            fm.xlsToTxt("c:\\tes\\xls\\satu.xlsx", "xlsx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string e = "";
            var fm = new fileMan();
            var ws = new wsClass();
            string[] files = fm.getFile(outbox);
            string pes = "";
            string[] fName = null;
            if (files != null && files.Length>0)
            {
                foreach (string i in files)
                {
                    try
                    {
                        pes = ws.invokeProd("", "", i);
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                    //string[] has = pes.Split('|');
                    //fName = i.Split('\\');
                    string namaFile = "";// fName[fName.Length - 1];
                    System.Console.WriteLine(namaFile + " " + pes);
                    //if (has[0] == "failed")
                    //{
                    //    fm.moveFile(i, "c:\\tes\\error\\");
                    //}
                    //else
                    //{
                    //    fm.moveFile(i, "c:\\tes\\success\\");
                    //}
                }
            }
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
