using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AplikasiIsg
{
    class wsClass
    {
        public string cekLogin(string user,string pass)
        {
            string hasil = null;
            var ws = new inkaber.inkaberWS();
            hasil = ws.login(user,pass);
            return hasil;
        }

        public string cekLoginUoi(string user, string pass)
        {
            string hasil = null;
            var ws = new wsUoi.inkaberWS();
            hasil = ws.login(user, pass);
            return hasil;
        }

        public string invokeProd(string user,string pass,string file)
        {
            string hasil = null;
            string str = File.ReadAllText(file);
            var ws = new inkaber.inkaberWS();
            try
            {
                hasil = ws.process("adminkomdn", "ediimdn", "produksi", str);
            }
            catch
            {
                hasil = "failed|Koneksi Gagal";
            }
            
            return hasil;
        }

        public string invokeProdUoi(string user, string pass, string file)
        {
            string hasil = null;
            string str = File.ReadAllText(file);
            var ws = new wsUoi.inkaberWS();
            try
            {
                hasil = ws.process("adminuoi", "adminuoi1", "produksi", str);
            }
            catch
            {
                hasil = "failed|Koneksi Gagal";
            }

            return hasil;
        }
    }
}
