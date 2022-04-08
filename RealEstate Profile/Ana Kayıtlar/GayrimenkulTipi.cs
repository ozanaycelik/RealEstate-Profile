using DevExpress.XtraEditors;
using System;
using RealEstate_Profile.DataAccess;
using System.Windows.Forms;

namespace RealEstate_Profile
{
    public partial class GayrimenkulTipi : DevExpress.XtraEditors.XtraForm
    {
        public GayrimenkulTipi()
        {
            InitializeComponent();
        }
        DataLogic d1 = new DataLogic();

        string turAdi = "Tur";
        private void GayrimenkulTipi_Load(object sender, EventArgs e)
        {
            txt_yeni_tip.Properties.MaxLength = 50;
            cbx_gyr_tipleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi,turAdi));

            cbx_gyr_tipleri.SelectedIndex = 0;
        }


        string tablo_adi = "Gayrimenkul_Tipi";
        private void btn_gayr_tipi_kaydet_Click(object sender, EventArgs e)
        {
            d1.gayr_ana_kayıt_ekle(txt_yeni_tip.Text, tablo_adi);

            cbx_gyr_tipleri.Properties.Items.Clear();
            cbx_gyr_tipleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_tipleri.SelectedIndex = 0;

            txt_yeni_tip.Text = "";
        }

        private void btn_gayr_tipi_degistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_yeni_tip.Text))
            {
                XtraMessageBox.Show("Geçerli bir değer girmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d1.gayr_anakayit_degıstır(cbx_gyr_tipleri.Text, txt_yeni_tip.Text, tablo_adi);


            }
            cbx_gyr_tipleri.Properties.Items.Clear();
            cbx_gyr_tipleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_tipleri.SelectedIndex = 0;

            txt_yeni_tip.Text = "";
        }

    

        private void btn_gayr_tipi_sil_Click(object sender, EventArgs e)
        {
            d1.gayr_anakayit_sil(cbx_gyr_tipleri.Text, tablo_adi);


            cbx_gyr_tipleri.Properties.Items.Clear();
            cbx_gyr_tipleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_tipleri.SelectedIndex = 0;

            txt_yeni_tip.Text = "";
        }
    }
}