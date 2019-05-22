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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.00)
            {
                this.Opacity += 0.01;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.01;
            }
            else
            {
                timer2.Enabled = false;
                this.Close();
            }
        }

        private void Setting_MouseClick(object sender, MouseEventArgs e)
        {
            writeini("Inbox", textBox1.Text);
            writeini("Outbox", textBox2.Text);
            writeini("Success", textBox3.Text);
            writeini("Error", textBox4.Text);
            timer2.Start();
            timer1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = fbd.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox4.Text = fbd.SelectedPath;
            }
        }
        private void writeini(string title, string set)
        {
            INIFile ini = new INIFile(@"C:\tes\setting\config.ini");
            ini.Write("Direktori", title , set);
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            INIFile ini = new INIFile(@"C:\tes\setting\config.ini");
            textBox1.Text = ini.Read("Direktori", "Inbox");
            textBox2.Text = ini.Read("Direktori", "Outbox");
            textBox3.Text = ini.Read("Direktori", "Success");
            textBox4.Text = ini.Read("Direktori", "Error");
        }
        
    }
}
