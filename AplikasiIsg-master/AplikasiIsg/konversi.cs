using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;



namespace AplikasiIsg
{
    class konversi
    {
        private string dirInbox = "";
        private string dirOutbox = "C:\\Tes\\Outbox\\";

        public string toTanggal(string inpTanggal)
        {
            string[] arTanggal = inpTanggal.Split('.');
            string tanggal = arTanggal[2] + arTanggal[1] + arTanggal[0];
            return tanggal;
        }

        public string konversiXlsTxtProd(string xlsFile)
        {
            //string dirInbox = "";
            //string dirOutbox = "";
            string hasil = "";

            return hasil;
          
        }

        public string strToTxt(string flatLong)
        {
            string hasil = "";
            string[] linetxt = null;
            

            try
            {
                // Check if file already exists. If yes, delete it.     
                //if (File.Exists(fileName))
                //{
                //    File.Delete(fileName);
                //}

                linetxt = flatLong.Split('|');
                string nomorTransaksi = linetxt[3]+ linetxt[4];
                string tipeProd = "MASUK";
                string tanggal = toTanggal(linetxt[5]);
                string ket = linetxt[9];
                string kodeBarang = linetxt[10];
                string jumBarang = linetxt[12].Replace("-","");
                string satuan = linetxt[14];
                string namaFile = "PRODUKSI_" + DateTime.Now.ToString("yyyyMMddHHmmss") + nomorTransaksi +  ".txt";
                string fileName = dirOutbox + namaFile;

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("CAP|1|1|1|1|"+ nomorTransaksi +"|" + namaFile);
                    sw.WriteLine("HDR|R|"+tipeProd+"|"+nomorTransaksi+"||"+ tanggal +"||"+ ket );
                    sw.WriteLine("DTL|" + nomorTransaksi + "|" + kodeBarang + "|1|" + jumBarang + "|" + satuan + "|" + ket);
                }

                // Write file contents on console.     
                //using (StreamReader sr = File.OpenText(fileName))
                //{
                  //  string s = "";
                  //  while ((s = sr.ReadLine()) != null)
                  //  {
                  //      Console.WriteLine(s);
                  //  }
               // }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

           // wsClass ws = new wsClass();
           // string has = ws.invokeProd("","",fileName);
         

            return "1";
        }

        public void xlsToTxt(string fname)
        {
            
        }
    }
}
