using DevExpress.XtraEditors;
using RealEstate_Profile.DataAccess;
using RealEstate_Profile.Extensions.CastExtensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace RealEstate_Profile.DataInsert
{
    public partial class DataInsert : DevExpress.XtraEditors.XtraForm
    {
        public DataInsert()
        {
            InitializeComponent();
        }

        private void DataInsert_Load(object sender, EventArgs e)
        {
            //buttonEdit1.Text = Application.StartupPath + "\\TestBook.xlsx";

            dataGridView1.Visible = false;
        }

        DataLogic d1 = new DataLogic();

        string SheetName = string.Empty;
        private void btn_aktarim_Click(object sender, EventArgs e)
        {
            //d1.ExcelDataTransfer(buttonEdit1.Text, SheetName);

            if (string.IsNullOrEmpty(buttonEdit2.Text))
            {
                XtraMessageBox.Show("Lütfen geçerli bir excel belgesi giriniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GetExcelFile();
            }

        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string DosyaYolu;
            string DosyaAdi;
            //DataTable dt;
            OpenFileDialog file = new OpenFileDialog();
            bool bayrak = true;

            file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";

            if (file.CheckPathExists == bayrak)
            {


                if (file.ShowDialog() == DialogResult.OK)
                {
                    DosyaYolu = file.FileName;// seçilen dosyanın tüm yolunu verir
                    DosyaAdi = file.SafeFileName;// seçilen dosyanın adını verir.
                    ExcelApp.Application excelApp = new ExcelApp.Application();
                    if (excelApp == null)
                    { //Excel Yüklümü Kontrolü Yapılmaktadır.
                        MessageBox.Show("Excel yüklü değil.");
                        return;
                    }
                    //Excel Dosyası Açılıyor.
                    ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DosyaYolu);
                    //Excel Dosyasının Sayfası Seçilir.
                    ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];

                    //Excel Dosyasının ne kadar satır ve sütun kaplıyorsa tüm alanları alır.
                    ExcelApp.Range excelRange = excelSheet.UsedRange;
                    int satirSayisi = excelRange.Rows.Count; //Sayfanın satır sayısını alır.
                    int sutunSayisi = excelRange.Columns.Count;//Sayfanın sütun sayısını alır.
                    buttonEdit2.Text = DosyaYolu;
                    SaveFileDialog save = new SaveFileDialog();
                    save.FileName = DosyaAdi;

                    SheetName = excelSheet.Name.ToString();
                }
                //Okuduktan Sonra Excel Uygulamasını Kapatıyoruz.
                //excelApp.Quit();
                // System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                else
                {
                    XtraMessageBox.Show("Lütfen geçerli bir excel belgesi giriniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void GetExcelFile()
        {
            object misValue = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(buttonEdit2.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range last = xlWorksheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            string dss = GetExcelColumnName(last.Column) + last.Row;
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.get_Range("A1:" + dss, misValue);
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            DataTable dt = new DataTable("dtExcel");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            DataRow dr;

            //lblInfo.Text = rowCount + " satır " + colCount + " kolon okunacak";
            for (int j = 1; j <= colCount; j++)
            {
                dt.Columns.Add(GetExcelColumnName(j), Type.GetType("System.String"));
            }

            Microsoft.Office.Interop.Excel.Range oRng;
            for (int i = 1; i < rowCount; i++)
            {
                if (i == 1)
                    continue;

                dr = ds.Tables["dtExcel"].NewRow();
                for (int j = 1; j <= colCount; j++)
                {
                    oRng = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[i, j];
                    string strValue = oRng.Text.ToString();
                    dr[GetExcelColumnName(j)] = strValue;
                }
                ds.Tables["dtExcel"].Rows.Add(dr);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            var data = new List<Entities.PortfolioTable>();
            data = dt.AsEnumerable().Select(s => new Entities.PortfolioTable
            {
                PortfolioNumber = s.Field<string>("A"),
                PortfolioDate = s.Field<string>("B").ToDateTime(),
                CustomerName = s.Field<string>("C"),
                CustomerSurname = s.Field<string>("D"),
                CustomerType = s.Field<string>("E"),
                Phone1 = s.Field<string>("F"),
                Phone2 = s.Field<string>("G"),
                Email = s.Field<string>("H"),
                Status = s.Field<string>("I"),
                NetTotal = s.Field<string>("J").ToDouble(),
                GayrTuru = s.Field<string>("K"),
                GayrType = s.Field<string>("L"),
                GayrStatus = s.Field<string>("M"),
                TapuStatus = s.Field<string>("N"),
                BrutArea = s.Field<string>("O").ToDouble(),
                NetArea = s.Field<string>("P").ToDouble(),
                City = s.Field<string>("Q"),
                Town = s.Field<string>("R"),
                Mahalle = s.Field<string>("S")


            }).ToList();

            List<int> l1 = new List<int>();

            var sayac_ = 0;
            foreach (var item in data.ToList())
            {


                var flag = true;
                flag = DataLogic.PortfoyArat(item.PortfolioNumber);
                if (flag == true)
                {
                    l1.Add(sayac_);
                    string deger = item.PortfolioNumber;
                    //data.Remove(item.PortfolioNumber).ToString();

                    data.RemoveAt(sayac_);
                    sayac_--;
                }

                sayac_++;

            }

            dataGridView1.DataSource = data;

            var sayac = 0;
            foreach (var item in data)
            {

                DataLogic.AddPortfolio(item);

                sayac++;
            }

            XtraMessageBox.Show(string.Concat(sayac, " kayıt başarıyla aktarılmıştır."), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #region TryBulkInsert
            //SqlConnection connect = new SqlConnection(DataLogic.ConnectionString);

            //SqlBulkCopy objbulk = new SqlBulkCopy(connect);


            //// Excelden data table aldığımız veriyi bulk insert yöntemi ile kolayca insert edeceğiz.
            //objbulk.DestinationTableName = "Portfolio_";

            //objbulk.ColumnMappings.Add("A", "PortfolioNumber");
            ////objbulk.ColumnMappings.Add("B", "PortfolioDate");
            //objbulk.ColumnMappings.Add("C", "CustomerName");
            //objbulk.ColumnMappings.Add("D", "CustomerSurname");
            //objbulk.ColumnMappings.Add("E", "CustomerType");
            //objbulk.ColumnMappings.Add("F", "Phone1");
            //objbulk.ColumnMappings.Add("G", "Phone2");
            //objbulk.ColumnMappings.Add("H", "Email");
            //objbulk.ColumnMappings.Add("I", "Status");
            //objbulk.ColumnMappings.Add("J","NetTotal").ToDouble();
            //objbulk.ColumnMappings.Add("K", "GayrTuru");
            //objbulk.ColumnMappings.Add("L", "GayrType");
            //objbulk.ColumnMappings.Add("M", "GayrStatus");
            //objbulk.ColumnMappings.Add("N", "TapuStatus");
            ////objbulk.ColumnMappings.Add("O", "BrutArea");
            ////objbulk.ColumnMappings.Add("P", "NetArea");
            //objbulk.ColumnMappings.Add("Q", "City");
            //objbulk.ColumnMappings.Add("R", "Town");
            //objbulk.ColumnMappings.Add("S", "Mahalle");


            ////insert bulk Records into DataBase.  
            //connect.Open();
            //    objbulk.WriteToServer(dt);


            //    connect.Close();
            #endregion


        }

        private void buttonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (string.IsNullOrEmpty(buttonEdit2.Text))
            {
                GetExcelFile();
            }
            else
            {
                XtraMessageBox.Show("Lütfen geçerli bir excel belgesi giriniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


}


