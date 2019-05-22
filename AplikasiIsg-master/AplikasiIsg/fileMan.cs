using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace AplikasiIsg
{
    class fileMan
    {
        public bool isNotEmptyFolder(string direktori)
        {
            bool hasil = false;
            string[] files = System.IO.Directory.GetFiles(direktori);
            if (files.Length > 0)
                hasil = true;

            return hasil;
        }

        public int cekDir(string path)
        {
            int jumFile = 0;
            jumFile = System.IO.Directory.GetFiles(path).Length;
            return jumFile;
        }
        public string[] getFile(string direktori)
        {
            string[] files = null;
            if (isNotEmptyFolder(direktori))
            {
                files = System.IO.Directory.GetFiles(direktori);
            }
            return files;
        }

        public bool moveFile(string filename, string dirTujuan)
        {
            bool hasil = false;
            string[] fName = filename.Split('\\');
            string namaFile = fName[fName.Length - 1];
            if (File.Exists(dirTujuan + namaFile))
            {
                Random r = new Random();
                int rInt = r.Next(0, 100); //for ints
                File.Move(filename, dirTujuan + rInt.ToString() + namaFile);
            }else
            {
                File.Move(filename, dirTujuan + namaFile);
            }
            return hasil;
        }

        public static ISheet get_sheet_file_object(string path, string formatfile)
        {
            try
            {
                if (formatfile == "xls" || formatfile == "XLS")
                {
                    HSSFWorkbook XLS_Workbook = default(HSSFWorkbook);
                    using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        XLS_Workbook = new HSSFWorkbook(file);
                    }

                    //return XLS_Workbook.GetSheet("sheet1");
                    return XLS_Workbook.GetSheetAt(0);
                }
                else if (formatfile == "xlsx" || formatfile == "XLSX")
                {
                    XSSFWorkbook XLSX_Workbook = null;

                    using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        XLSX_Workbook = new XSSFWorkbook(file);
                    }

                    //return XLSX_Workbook.GetSheet("sheet1");
                    return XLSX_Workbook.GetSheetAt(0);
                }
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                return null;
            }

            return null;
        }


        public List<string> jumlah(string filePath,string ext)
        {
            List<string> txFlat = null;
            ISheet Sheet = null;
            bool loop = true;
            int header = 1;
            int jumkolom = 25;
            int startkolom = 2;
            int jumrow = 0;
            int i = 3,jmldata=1;
            bool isValidRow = false;
            string kalimat = "",kal="";

            try
            {

                Sheet = fileMan.get_sheet_file_object(filePath, ext);
            }
            catch(Exception e)
            {
                Console.WriteLine("1 " + e);
            }

            while (loop)
            {
                isValidRow = false;
                try
                {
                    bool bar = false;
                    kalimat = "";
                    for (int x = startkolom; x < startkolom + jumkolom; x++)
                    {
                        //Console.Write(Sheet.GetRow(i).GetCell(x));
                        //Console.Write(i.ToString()+" "+x.ToString()+" "+Sheet.GetRow(i).GetCell(x));
                        //if (x == 5 || x == 11 || x == 13 || x == 15)
                        //{
                            try
                            {
                                   
                                kal = Sheet.GetRow(i).GetCell(x) == null ? "" : Sheet.GetRow(i).GetCell(x).ToString().Trim();
                                kalimat = kalimat + "|" + kal;
                                if (x == 15 && kal == "261")
                                {
                                    bar = true;
                                }
                            }
                            catch(Exception e)
                            {
                            Console.WriteLine("2 " + e);

                                kal="";
                            }
                        //}
                        loop = true;
                    }
                    if (!bar)
                    {
                            kalimat = "";
                        bar = false;
                    }
                }
                catch(Exception e)
                {
                    loop = false;
                    break;
                    Console.WriteLine(i.ToString() + " " + e);
                }

                if (i >= Sheet.LastRowNum)
                {
                    loop = false;
                    break;
                }

                i++;
                if (kalimat != "" || kalimat !=null) {
                    txFlat.Add(kalimat);
                    Console.WriteLine(jmldata.ToString() + " " + kalimat);
                    //konversi kon = new konversi();

                    //string str = kon.strToTxt(kalimat);
                    //MessageBox.Show(str);
                    jmldata++;
                }
            }
            jumrow = i;
            return txFlat;
        }

        private static string Tabs(int n)
        {
            return new String('|', n);
        }

        public int xlsToTxt(string filePath, string ext)
        {
            ISheet Sheet = null;
            int i = 2;
            konversi kon = new konversi();
            string pes = "";

            try
            {
                Sheet = fileMan.get_sheet_file_object(filePath, ext);
            }
            catch (Exception e)
            {
                Console.WriteLine("1 " + e);
            }
            int x = 4,k=0,rowcount=1;
            string kal = "";
            while ( i <= Sheet.LastRowNum)
            {
                try
                {
                    IRow row = Sheet.GetRow(i);
                    if (row == null)
                    {
                        kal = "";
                    }else
                    {
                        int mul = 26 - row.LastCellNum;
                        ICell c = row.GetCell(15);
                        if (c != null)
                        {
                            if (c.ToString() == "261")
                            {
                                for (k = 2; k < row.LastCellNum; k++)
                                {
                                    c = row.GetCell(k);
                                    if (c == null)
                                    {
                                        kal = kal + "|";
                                    }
                                    else
                                    {
                                        kal = kal + c.ToString().Trim() + "|";
                                    }
                                }
                                kal = kal + Tabs(mul);
                                rowcount++;
                            }
                        }                                                               
                    }
                   
                }catch(Exception e)
                {
                    Console.WriteLine("2 " + e);
                    kal = "";
                }
                if (kal != "")
                {
                    Console.WriteLine(rowcount + " " + kal);
                    pes = kon.strToTxt(kal);
                }
                kal = "";
                i++;
            }
            return rowcount;
        }
    }
}
