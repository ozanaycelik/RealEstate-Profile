using DevExpress.XtraEditors;
using RealEstate_Profile.Core.Helper;
using RealEstate_Profile.DataAccess;
using RealEstate_Profile.Entities;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealEstate_Profile.Portfolio
{
    public partial class ChangePortfolio : DevExpress.XtraEditors.XtraForm
    {
        public ChangePortfolio()
        {
            InitializeComponent();
        }

        Portfolios.portfolios p1 = new Portfolios.portfolios();
        DataLogic d1 = new DataLogic();
        public static string ilce_dosyasi = string.Concat(@"C:\Users\USER\source\repos\RealEstate Profile\RealEstate Profile\bin\Debug\Xml\Towns.xml");
        public static string il_dosyasi = string.Concat(@"C:\Users\USER\source\repos\RealEstate Profile\RealEstate Profile\bin\Debug\Xml\Cities.xml");


        public static bool FlagControl(bool flag)
        {
            return flag;
        }

        public int flag = 1;
        private void ChangePortfolio_Load(object sender, EventArgs e)
        {
            TabIndexControl();


            lookUpCities.Visible = false;


            if (flag == 2)
            {
                ChangeScreenLoad();

                txt_brutArea.ReadOnly = true;
                btn_change.Visible = false;
                txt_cepNo_1.ReadOnly = true;
                txt_cus_name.ReadOnly = true;
                txt_cus_surname.ReadOnly = true;
                txt_email_add.ReadOnly = true;
                txt_netArea.ReadOnly = true;
                txt_nettotal.ReadOnly = true;
                txt_phone2.ReadOnly = true;
                cbx_cus_type.ReadOnly = true;
                cbx_gayr_durumu.ReadOnly = true;
                cbx_gayr_turu.ReadOnly = true;
                cbx_gyr_tipi.ReadOnly = true;
                cbx_il_listesi.ReadOnly = true;
                date_pt.ReadOnly = true;
                cbx_mahalle_list.ReadOnly = true;
                cbx_status.ReadOnly = true;
                cbx_tapu_durumu.ReadOnly = true;
                cbx_town_list.ReadOnly = true;
            }
            else
            {
                ChangeScreenLoad();
            }


        }

        /// <summary>
        /// Tab Indexleri tek bir yerden kontrol ettiğimiz metod!
        /// </summary>
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


        /// <summary>
        /// Devexpressin look up componenti xmlden 2 tane değer gösterebilirsin.
        /// </summary>
        private void LookUpCities()
        {

            var cities = ConfigHelper.DeserializeXml<Cities>(il_dosyasi);

            foreach (var city in cities.City)
            {
                cbx_il_listesi.Properties.Items.Add(city.Name);
            }



            // lookup devexpress componenti işe yarar:)
            lookUpCities.Properties.DataSource = cities.City;
            lookUpCities.Properties.ValueMember = "Code";
            lookUpCities.Properties.DisplayMember = "Name";
        }

        public void ChangeScreenLoad()
        {


            var cities = ConfigHelper.DeserializeXml<Cities>(il_dosyasi);

            foreach (var city in cities.City)
            {
                cbx_il_listesi.Properties.Items.Add(city.Name);
            }




            var towns = ConfigHelper.DeserializeXml<Towns>(ilce_dosyasi);

            foreach (var town in towns.Town)
            {
                cbx_town_list.Properties.Items.Add(town.Name);
            }




            // Aşağıdaki uygulama uzun hali ve sınıfa atma çok zor!!
            //XmlDocument doc_ilce = new XmlDocument();
            //doc_ilce.Load(ilce_dosyasi);
            //XmlNodeList town = doc_ilce.GetElementsByTagName("NAME");
            //foreach (XmlNode n in town)
            //{
            //    cbx_town_list.Properties.Items.Add(n.InnerXml.ToString());


            //    //City.Add(new City
            //    //{
            //    //    TownName = string.Concat(n.InnerXml)
            //    //});
            //}



            string genelKolonAdi = "Tur";

            string tablo_gayr_turu = "Gayrimenkul_Turu";
            cbx_gayr_turu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_gayr_turu, genelKolonAdi));

            string tablo_gayr_tipi = "Gayrimenkul_Tipi";
            cbx_gyr_tipi.Properties.Items.AddRange(DataLogic.combocagir1(tablo_gayr_tipi, genelKolonAdi));

            string tablo_gayr_durumu = "Gayrimenkul_Durumu";
            cbx_gayr_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_gayr_durumu, genelKolonAdi));

            string tablo_tapu_durumu = "Tapu_Durumları";
            cbx_tapu_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_tapu_durumu, genelKolonAdi));


            string mahalleTable = "Mahalleler";
            string mahalleKolonAdi = "Mahalle";
            cbx_mahalle_list.Properties.Items.AddRange(DataLogic.combocagir1(mahalleTable, mahalleKolonAdi));


            var substring = this.Text;
            txt_portfoy_number.Text = substring.Substring(10, this.Text.Length - 10);

            date_pt.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "PortfolioDate").ToString();
            txt_cus_name.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "CustomerName").ToString();
            txt_cus_surname.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "CustomerSurname").ToString();
            cbx_cus_type.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "CustomerType").ToString();

            txt_cepNo_1.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "Phone1").ToString();
            txt_phone2.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "Phone2").ToString();
            txt_email_add.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "Email").ToString();
            cbx_status.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "Status").ToString();

            txt_nettotal.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "NetTotal").ToString();
            cbx_gayr_turu.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "GayrTuru").ToString();
            cbx_gyr_tipi.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "GayrType").ToString();
            cbx_gayr_durumu.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "GayrStatus").ToString();
            cbx_tapu_durumu.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "TapuStatus").ToString();
            txt_brutArea.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "BrutArea").ToString();
            txt_netArea.Text = DataLogic.ShowUp(txt_portfoy_number.Text, "NetArea").ToString();
            cbx_il_listesi.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "City").ToString();
            cbx_town_list.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "Town").ToString();
            cbx_mahalle_list.SelectedItem = DataLogic.ShowUp(txt_portfoy_number.Text, "Mahalle").ToString();
        }
        public static bool Flag_Control(bool flag)
        {
            return flag;
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
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

                    d1.UpdatePortfolio(txt_portfoy_number.Text, txt_cus_name.Text, txt_cus_surname.Text, cbx_cus_type.Text, txt_cepNo_1.Text, txt_phone2.Text, txt_email_add.Text, cbx_status.Text
               , txt_nettotal.Text, cbx_gayr_turu.Text, cbx_gyr_tipi.Text, cbx_gayr_durumu.Text, cbx_tapu_durumu.Text, txt_brutArea.Text, txt_netArea.Text,
               cbx_il_listesi.Text, cbx_town_list.Text, cbx_mahalle_list.Text, date_pt.Text);

                    XtraMessageBox.Show(string.Concat(txt_portfoy_number.Text, "numaralı portföy güncellenmiştir !"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    string email = txt_email_add.Text;
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(email);
                    if (match.Success)
                    {
                        // Devam edebilir.

                        d1.UpdatePortfolio(txt_portfoy_number.Text, txt_cus_name.Text, txt_cus_surname.Text, cbx_cus_type.Text, txt_cepNo_1.Text, txt_phone2.Text, txt_email_add.Text, cbx_status.Text
               , txt_nettotal.Text, cbx_gayr_turu.Text, cbx_gyr_tipi.Text, cbx_gayr_durumu.Text, cbx_tapu_durumu.Text, txt_brutArea.Text, txt_netArea.Text,
               cbx_il_listesi.Text, cbx_town_list.Text, cbx_mahalle_list.Text, date_pt.Text);

                        XtraMessageBox.Show(string.Concat(txt_portfoy_number.Text, "numaralı portföy güncellenmiştir !"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Hatalı email girişi lütfen kontrol ediniz !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }


        }

        private void cbx_il_listesi_Properties_SelectedValueChanged(object sender, EventArgs e)
        {

            // var city = lookUpCities.EditValue;

            cbx_town_list.Properties.Items.Clear();

            var selectedCity = cbx_il_listesi.SelectedItem.ToString();


            var towns = ConfigHelper.DeserializeXml<Towns>(ilce_dosyasi).Town.Where(x => x.CityCode == selectedCity);

            cbx_town_list.Properties.Items.AddRange(towns.Select(x => x.Name).ToList());

            cbx_town_list.SelectedIndex = 0;
        }
    }
}