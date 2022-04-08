using DevExpress.XtraEditors;
using RealEstate_Profile.DataAccess;
using System;
using System.Windows.Forms;

namespace RealEstate_Profile.Ana_Kayıtlar
{
    public partial class GayrimenkulDurumu : DevExpress.XtraEditors.XtraForm
    {
        public GayrimenkulDurumu()
        {
            InitializeComponent();
        }
        DataLogic d1 = new DataLogic();


        string tablo_adi = "Gayrimenkul_Durumu";


        string turAdi = "Tur";
        private void GayrimenkulDurumu_Load(object sender, EventArgs e)
        {
            txt_yeni_durumu.Properties.MaxLength = 50;
            cbx_gyr_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));


            cbx_gyr_durumu.SelectedIndex = 0;
        }

        private void btn_gayr_tipi_kaydet_Click(object sender, EventArgs e)
        {
            d1.gayr_ana_kayıt_ekle(txt_yeni_durumu.Text, tablo_adi);

            cbx_gyr_durumu.Properties.Items.Clear();
            cbx_gyr_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_durumu.SelectedIndex = 0;

            txt_yeni_durumu.Text = "";
        }

        private void btn_gayr_durumu_degistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_yeni_durumu.Text))
            {
                XtraMessageBox.Show("Geçerli bir değer girmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d1.gayr_anakayit_degıstır(cbx_gyr_durumu.Text, txt_yeni_durumu.Text, tablo_adi);


            }
            cbx_gyr_durumu.Properties.Items.Clear();
            cbx_gyr_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_durumu.SelectedIndex = 0;

            txt_yeni_durumu.Text = "";
        }

        private void btn_gayr_durumu_sil_Click(object sender, EventArgs e)
        {
            d1.gayr_anakayit_sil(cbx_gyr_durumu.Text, tablo_adi);


            cbx_gyr_durumu.Properties.Items.Clear();
            cbx_gyr_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_durumu.SelectedIndex = 0;

            txt_yeni_durumu.Text = "";
        }
    }
}