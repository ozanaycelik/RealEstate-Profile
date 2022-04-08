using RealEstate_Profile.Entities;
using RealEstate_Profile.DataAccess;
using RealEstate_Profile.Portfolio;
using System;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraBars;
using RealEstate_Profile.Core.Helper;
using System.Collections;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraPrinting;

namespace RealEstate_Profile.Portfolios
{
    public partial class portfolios : DevExpress.XtraEditors.XtraForm
    {
        public portfolios()
        {
            InitializeComponent();
        }

        Entities.PortfolioTable p1 = new Entities.PortfolioTable();

        string mahalleTable = "Mahalleler";
        string mahalleKolonAdi = "Mahalle";

        public static string ilce_dosyasi = string.Concat(@"C:\Users\USER\source\repos\RealEstate Profile\RealEstate Profile\bin\Debug\Xml\Towns.xml");

        /// <summary>
        /// Gridview için seçili olanları bulacağız.
        /// </summary>
        //private void GridMultiSelect()
        //{
        //    gridView1.OptionsSelection.MultiSelect = true;
        //    gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        //}

        private void portfolios_Load(object sender, EventArgs e)
         {
        

            dt_begDate.Text = string.Concat("01.01.", DateTime.UtcNow.Year.ToString());
            dt_endDate.Text = string.Concat("31.12.", DateTime.UtcNow.Year.ToString());


            var towns = ConfigHelper.DeserializeXml<Towns>(ilce_dosyasi);

            foreach (var city in towns.Town)
            {
                cbx_town_get.Properties.Items.Add(city.Name);
            }

            //XmlDocument doc_ilce = new XmlDocument();
            //doc_ilce.Load(ilce_dosyasi);
            //XmlNodeList town = doc_ilce.GetElementsByTagName("NAME");
            //foreach (XmlNode n in town)
            //{
            //    cbx_town_get.Properties.Items.Add(n.InnerXml.ToString());
            //}

            cbx_mahalle_get.Properties.Items.AddRange(DataLogic.combocagir1(mahalleTable, mahalleKolonAdi));

            cbx_mahalle_get.SelectedItem = "Hepsi";
            cbx_town_get.SelectedItem = "Hepsi";

            Uygula();


        }

        public void Uygula()
        {
            string allTown = string.Empty;

            if (cbx_town_get.SelectedItem == "Hepsi")
            {
                allTown = "%";
            }
            else
            {
                allTown = cbx_town_get.Text.ToString();
            }

            string allMahalle = string.Empty;

            if (cbx_mahalle_get.SelectedItem == "Hepsi")
            {
                allMahalle = "%";
            }
            else
            {
                allMahalle = cbx_mahalle_get.Text.ToString();
            }

            gridControl1.DataSource = DataLogic.GetPortfolios(dt_begDate.DateTime, dt_endDate.DateTime, allTown, allMahalle);
        }
        private void btn_uygula_Click(object sender, EventArgs e)
        {

            Uygula();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {

            int mouse_index = gridView1.GetFocusedDataSourceRowIndex();

            string portfolioNumber = gridView1.GetRowCellValue(mouse_index, "PortfolioNumber").ToString();

            ChangePortfolio cp = new ChangePortfolio();

            cp.Text = string.Concat("Portföy = ", portfolioNumber);

            //cp.ShowDialog();

            //this.Close();


        }

        ContextMenuStrip PopupMenu = new ContextMenuStrip();
        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {



            if (e.Button == MouseButtons.Right)
            {
                popup_menu.ShowPopup(Control.MousePosition);


                //if (barManager1.SelectLink("Ekle"))
                //{

                //}



            }
        }


        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            AddPortfolio a1 = new AddPortfolio();

            a1.ShowDialog();

            Uygula();
        }

        private void barbtn_change_ItemClick(object sender, ItemClickEventArgs e)
        {

            
            int mouse_index = gridView1.GetFocusedDataSourceRowIndex();

            string portfolioNumber = gridView1.GetRowCellValue(mouse_index, "PortfolioNumber").ToString();

            ChangePortfolio cp = new ChangePortfolio();

            cp.Text = string.Concat("Portföy = ", portfolioNumber);

            cp.ShowDialog();

            Uygula();

        }


        DataLogic d1 = new DataLogic();
        private void barbtn_delete_ItemClick(object sender, ItemClickEventArgs e)
        {



            int mouse_index = gridView1.GetFocusedDataSourceRowIndex();

            string portfolioNumber = gridView1.GetRowCellValue(mouse_index, "PortfolioNumber").ToString();

            

            DialogResult dialogResult = XtraMessageBox.Show(string.Concat(portfolioNumber, " numaralı portföy silinecektir !"), "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                d1.DeletePortfolio(portfolioNumber);

                Uygula();
            }
            else
            {

            }
            
        }

       

        
      
        private void barbtn_look_ItemClick(object sender, ItemClickEventArgs e)
        {
            int mouse_index = gridView1.GetFocusedDataSourceRowIndex();

            string portfolioNumber = gridView1.GetRowCellValue(mouse_index, "PortfolioNumber").ToString();

            ChangePortfolio cp = new ChangePortfolio();

            cp.flag += 1;

            cp.Text = string.Concat("Portföy = ", portfolioNumber);

            cp.ShowDialog();


        }



        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            popup_menu.ShowPopup(barManager1, new System.Drawing.Point(MousePosition.X, MousePosition.Y));
        }

        private void barbtn_toplu_sil_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dataSource = ((IEnumerable)gridView1.DataSource).Cast<PortfolioTable>().ToList();
          

            var CheckingColumn = dataSource.Where(x => x.Check == true);

            var selectPortfolio = CheckingColumn.Select(x => x.PortfolioNumber);

            DialogResult dialogResult = XtraMessageBox.Show(string.Concat("Seçilen kayıtlar silinecektir !"), "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (var item in selectPortfolio)
                {
                    d1.DeletePortfolio(item.ToString());
                }


            }
            else
            {

            }

            Uygula();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.A || e.KeyCode==Keys.Control)
            {


                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(i, "Check", true);


                }

            }



        }

        private void btn_excel_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Portföylerim (" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")";
            saveFileDialog1.Filter = "XLS Dosyaları (*.xls)|*.xls";

            saveFileDialog1.InitialDirectory = "c:";

            //eğer saveFileDiaolog1 açıldığında Evet’e tıklanırsa

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                DevExpress.XtraPrinting.XlsExportOptions _Options = new DevExpress.XtraPrinting.XlsExportOptions();

                _Options.SheetName = "Portföylerim(" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")";

                gridView1.ExportToXls(saveFileDialog1.FileName, _Options);

                if (MessageBox.Show("Aktarılan dosyayı şimdi görmek ister misiniz?", "Excel dosyası", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Kaydedilen Excel Dosyasını açar.

                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }

            }
        }
    }
}

