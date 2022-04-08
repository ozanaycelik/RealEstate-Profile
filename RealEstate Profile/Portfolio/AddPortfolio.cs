using DevExpress.XtraEditors;
using RealEstate_Profile.Core.Helper;
using RealEstate_Profile.DataAccess;
using RealEstate_Profile.Entities;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealEstate_Profile
{
    public partial class AddPortfolio : DevExpress.XtraEditors.XtraForm
    {
        public AddPortfolio()
        {
            InitializeComponent();
        }


        DataLogic d1 = new DataLogic();
        Gayrimenkul_Türü ga = new Gayrimenkul_Türü();

        string mahalleTable = "Mahalleler";
        string mahalleKolonAdi = "Mahalle";



        public static string ilce_dosyasi = string.Concat(@"C:\Users\USER\source\repos\RealEstate Profile\RealEstate Profile\bin\Debug\Xml\Towns.xml");
        public static string il_dosyasi = string.Concat(@"C:\Users\USER\source\repos\RealEstate Profile\RealEstate Profile\bin\Debug\Xml\Cities.xml");

        //public static string XmlFileName => "IL-ILCE.XML";
        //public static string ReadPath => string.Concat("@",Application.StartupPath, "\\", XmlFileName);


        private void AddPortfolio_Load(object sender, EventArgs e)
        {

            TabIndexControl();

            var cities = ConfigHelper.DeserializeXml<Cities>(il_dosyasi);

            foreach (var city in cities.City)
            {
                cbx_il_listesi.Properties.Items.Add(city.Name);
            }

            //XmlDocument doc_il = new XmlDocument();
            //doc_il.Load(il_dosyasi);

            //XmlNodeList nodes = doc_il.GetElementsByTagName("NAME");
            //foreach (XmlNode n in nodes)
            //{
            //    cbx_il_listesi.Properties.Items.Add(n.InnerXml.ToString());
            //}

            //XmlDocument doc_ilce = new XmlDocument();
            //doc_ilce.Load(ilce_dosyasi);
            //XmlNodeList town = doc_ilce.GetElementsByTagName("NAME");
            //foreach (XmlNode n in town)
            //{
            //    cbx_town_list.Properties.Items.Add(n.InnerXml.ToString());
            //}

            date_pt.DateTime = DateTime.Today;


            txt_portfoy_number.Text = DataLogic.portfoy_no();

            if (string.IsNullOrEmpty(txt_portfoy_number.Text))
            {
                txt_portfoy_number.Text = string.Concat(DateTime.Now.Year + "" + DateTime.Now.Month + "" + 1);
            }


            string genelKolonAdi = "Tur";

            string tablo_gayr_turu = "Gayrimenkul_Turu";
            cbx_gayr_turu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_gayr_turu, genelKolonAdi));

            string tablo_gayr_tipi = "Gayrimenkul_Tipi";
            cbx_gyr_tipi.Properties.Items.AddRange(DataLogic.combocagir1(tablo_gayr_tipi, genelKolonAdi));

            string tablo_gayr_durumu = "Gayrimenkul_Durumu";
            cbx_gayr_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_gayr_durumu, genelKolonAdi));

            string tablo_tapu_durumu = "Tapu_Durumları";
            cbx_tapu_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_tapu_durumu, genelKolonAdi));


            cbx_mahalle_list.Properties.Items.AddRange(DataLogic.combocagir1(mahalleTable, mahalleKolonAdi));

            cbx_gayr_turu.SelectedIndex = 0;

            cbx_gyr_tipi.SelectedIndex = 0;

            cbx_gayr_durumu.SelectedIndex = 0;

            cbx_tapu_durumu.SelectedIndex = 0;

            cbx_il_listesi.SelectedIndex = 0;
            cbx_town_list.SelectedIndex = 0;
        }


        private void TabIndexControl()
        {
            date_pt.TabIndex = 1;
            txt_cus_name.TabIndex = 2;
            txt_cus_surname.TabIndex = 3;
            cbx_cus_type.TabIndex = 4;
            txt_cepNo_1.TabIndex = 5;
            txt_phone2.TabIndex = 6;
            txt_email_add.TabIndex = 7;
            cbx_status.TabIndex = 8;
            txt_nettotal.TabIndex = 9;
            cbx_gayr_turu.TabIndex = 10;
            cbx_gyr_tipi.TabIndex = 11;
            cbx_gayr_durumu.TabIndex = 12;
            cbx_tapu_durumu.TabIndex = 13;
            txt_brutArea.TabIndex = 14;
            txt_netArea.TabIndex = 15;
            cbx_il_listesi.TabIndex = 16;
            cbx_town_list.TabIndex = 17;
            cbx_mahalle_list.TabIndex = 18;

        }

        private void btn_ekle_kapat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Yaptığınız işlem iptal olacaktır !", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Birşey yapmama gerek yok!
            }
        }

        public void porfolioAdd()
        {

            if (string.IsNullOrEmpty(cbx_mahalle_list.Text))
            {
                //Boş değeri eklemiyoruz !!
            }
            else
            {
                d1.AddValueWithNoMessage(cbx_mahalle_list.SelectedItem.ToString(), mahalleTable, mahalleKolonAdi);
            }


            Entities.PortfolioTable p1 = new Entities.PortfolioTable();

            p1.PortfolioNumber = txt_portfoy_number.Text;
            p1.PortfolioDate = date_pt.DateTime;
            p1.CustomerName = txt_cus_name.Text;
            p1.CustomerSurname = txt_cus_surname.Text;
            p1.CustomerType = cbx_cus_type.Text;
            p1.Phone1 = txt_cepNo_1.Text;
            p1.Phone2 = txt_phone2.Text;
            p1.Email = txt_email_add.Text;

            if (string.IsNullOrEmpty(txt_nettotal.Text))
            {
                p1.NetTotal = 0;
            }
            else
            {
                p1.NetTotal = Convert.ToDouble(txt_nettotal.Text);
            }
            if (string.IsNullOrEmpty(txt_brutArea.Text))
            {
                p1.BrutArea = 0;
            }
            else
            {
                p1.BrutArea = Convert.ToDouble(txt_brutArea.Text);
            }
            if (string.IsNullOrEmpty(txt_netArea.Text))
            {
                p1.NetArea = 0;
            }
            else
            {
                p1.NetArea = Convert.ToDouble(txt_netArea.Text);
            }
            p1.Status = cbx_status.Text;
            p1.GayrTuru = cbx_gayr_turu.Text;
            p1.GayrType = cbx_gyr_tipi.Text;
            p1.GayrStatus = cbx_gayr_durumu.Text;
            p1.TapuStatus = cbx_tapu_durumu.Text;
            p1.City = cbx_il_listesi.Text;
            p1.Town = cbx_town_list.Text;
            p1.Mahalle = cbx_mahalle_list.Text;
            DataLogic.AddPortfolio(p1);

            this.Close();

            XtraMessageBox.Show(string.Concat(txt_portfoy_number.Text, " numaralı portföy sisteme eklenmiştir."), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cus_name.Text) && string.IsNullOrEmpty(txt_cus_surname.Text))
            {
                XtraMessageBox.Show("Müşteri adı veya soyadı boş bırakılamaz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {


                if (string.IsNullOrEmpty(txt_email_add.Text))
                {
                    //Devam edebilir.

                    porfolioAdd();
                }
                else
                {
                    string email = txt_email_add.Text;
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(email);
                    if (match.Success)
                    {
                        // Devam edebilir.

                        porfolioAdd();

                        Portfolios.portfolios p1 = new Portfolios.portfolios();
                        p1.Uygula();
                    }
                    else
                    {
                        XtraMessageBox.Show("Hatalı email girişi lütfen kontrol ediniz !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }

        }

        private void cbx_il_listesi_SelectedValueChanged(object sender, EventArgs e)
        {


            cbx_town_list.Properties.Items.Clear();

            var selectedCity = cbx_il_listesi.SelectedItem.ToString();


            var towns = ConfigHelper.DeserializeXml<Towns>(ilce_dosyasi).Town.Where(x => x.CityCode == selectedCity);

            cbx_town_list.Properties.Items.AddRange(towns.Select(x => x.Name).ToList());

            cbx_town_list.SelectedIndex = 0;
        }
    }
}