using DevExpress.XtraEditors;
using RealEstate_Profile.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate_Profile.Ana_Kayıtlar
{
    public partial class Tapu_Durumu : DevExpress.XtraEditors.XtraForm
    {
        public Tapu_Durumu()
        {
            InitializeComponent();
        }
        DataLogic d1 = new DataLogic();


        string tablo_adi = "Tapu_Durumları";

        string turAdi = "Tur";


        private void Tapu_Durumu_Load(object sender, EventArgs e)
        {
            txt_tapu_durumu.Properties.MaxLength = 50;
            cbx_tapu_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));


            cbx_tapu_durumu.SelectedIndex = 0;
        }

        private void btn_tapu_durumu_kaydet_Click(object sender, EventArgs e)
        {
            d1.gayr_ana_kayıt_ekle(txt_tapu_durumu.Text, tablo_adi);

            cbx_tapu_durumu.Properties.Items.Clear();
            cbx_tapu_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_tapu_durumu.SelectedIndex = 0;

            txt_tapu_durumu.Text = "";
        }


        private void btn_tapu_durumu_degistir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tapu_durumu.Text))
            {
                XtraMessageBox.Show("Geçerli bir değer girmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d1.gayr_anakayit_degıstır(cbx_tapu_durumu.Text, txt_tapu_durumu.Text, tablo_adi);


            }
            cbx_tapu_durumu.Properties.Items.Clear();
            cbx_tapu_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_tapu_durumu.SelectedIndex = 0;

            txt_tapu_durumu.Text = "";
        }

        private void btn_tapu_durumu_sil_Click_1(object sender, EventArgs e)
        {
            d1.gayr_anakayit_sil(cbx_tapu_durumu.Text, tablo_adi);


            cbx_tapu_durumu.Properties.Items.Clear();
            cbx_tapu_durumu.Properties.Items.AddRange(DataLogic.combocagir1(tablo_adi, turAdi));

            cbx_tapu_durumu.SelectedIndex = 0;

            txt_tapu_durumu.Text = "";
        }
    }
}