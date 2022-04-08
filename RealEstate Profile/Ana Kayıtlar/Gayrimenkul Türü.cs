using DevExpress.XtraEditors;
using RealEstate_Profile.DataAccess;
using System;
using System.Windows.Forms;

namespace RealEstate_Profile
{
    public partial class Gayrimenkul_Türü : DevExpress.XtraEditors.XtraForm
    {
        public Gayrimenkul_Türü()
        {
            InitializeComponent();
        }

        DataLogic d1 = new DataLogic();

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        string turAdi = "Tur";
        private void Gayrimenkul_Türü_Load(object sender, EventArgs e)
        {

            txt_yeni_tur.Properties.MaxLength = 50;
            cbx_gyr_turleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_turleri.SelectedIndex = 0;


        }
        string tablo_adi = "Gayrimenkul_Turu";
        private void btn_gayr_turu_kaydet_Click(object sender, EventArgs e)
        {
            d1.gayr_ana_kayıt_ekle(txt_yeni_tur.Text, tablo_adi);

            cbx_gyr_turleri.Properties.Items.Clear();
            cbx_gyr_turleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_turleri.SelectedIndex = 0;

            txt_yeni_tur.Text = "";
        }

        private void btn_gayr_turu_degistir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_yeni_tur.Text))
            {
                XtraMessageBox.Show("Geçerli bir değer girmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d1.gayr_anakayit_degıstır(cbx_gyr_turleri.Text, txt_yeni_tur.Text, tablo_adi);


            }
            cbx_gyr_turleri.Properties.Items.Clear();
            cbx_gyr_turleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_turleri.SelectedIndex = 0;

            txt_yeni_tur.Text = "";

        }

        private void btn_gayr_turu_sil_Click(object sender, EventArgs e)
        {
            d1.gayr_anakayit_sil(cbx_gyr_turleri.Text, tablo_adi);


            cbx_gyr_turleri.Properties.Items.Clear();
            cbx_gyr_turleri.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_gyr_turleri.SelectedIndex = 0;

            txt_yeni_tur.Text = "";
        }


    }
}