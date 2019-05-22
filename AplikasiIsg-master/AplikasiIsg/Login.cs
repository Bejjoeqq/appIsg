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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if(user=="" || pass == "")
            {
                MessageBox.Show("Username dan Password belum di isi");
            }
            else
            {
                pbLoading.Visible = true;
                try
                {
                    var ws = new wsClass();
                    string pesan = ws.cekLogin(user, pass);
                    string[] respon = pesan.Split('|');
                    string pes = "";
                    pbLoading.Visible = false;
                    if (respon[0] == "failed")
                    {
                        MessageBox.Show("Login Gagal");
                    }else
                    {
                        //MessageBox.Show("Login Berhasil");
                        Main frm = new Main();
                        this.Hide();
                        frm.Show();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    pbLoading.Visible = false;
                }
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
