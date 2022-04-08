using DevExpress.XtraEditors;
using System;
using RealEstate_Profile.DataAccess;
using System.Windows.Forms;

namespace RealEstate_Profile
{
    public partial class frm_giris : DevExpress.XtraEditors.XtraForm
    {
        public frm_giris()
        {
            InitializeComponent();
        }

        DataLogic d1 = new DataLogic();

        public void Panel_ac_kapa(Panel open, Panel close)
        {
            open.Visible = true;

            close.Visible = false;
        }

        private void frm_giris_Load(object sender, EventArgs e)
        {
            Panel_ac_kapa(pnl_ana_giris, pnl_kayit_ol);
            Panel_ac_kapa(pnl_ana_giris, pnl_sifre_unut);
            txt_giris_kullanici.Properties.MaxLength = 15;
            txt_giris_sifre.Properties.MaxLength = 10;
            txt_kullanici_adi_sifre_sifirla.Properties.MaxLength = 15;
            txt_kullanici_ekle.Properties.MaxLength = 15;
            txt_sifre_ekle.Properties.MaxLength = 10;
            txt_sifre_onay.Properties.MaxLength = 10;

        }

        private void lbl_sifre_unuttum_Click(object sender, EventArgs e)
        {
            Panel_ac_kapa(pnl_sifre_unut, pnl_ana_giris);
            Panel_ac_kapa(pnl_sifre_unut,pnl_kayit_ol);
        }

        private void lbl_ana_menü_dön_Click(object sender, EventArgs e)
        {
            Panel_ac_kapa(pnl_ana_giris, pnl_kayit_ol);
            Panel_ac_kapa(pnl_ana_giris, pnl_sifre_unut);
        }

        private void lbl_kullanici_ekle_Click(object sender, EventArgs e)
        {
            Panel_ac_kapa(pnl_kayit_ol, pnl_ana_giris);
            Panel_ac_kapa(pnl_kayit_ol, pnl_sifre_unut);
        }

        private void lbl_ana_menü_2_Click(object sender, EventArgs e)
        {
            Panel_ac_kapa(pnl_ana_giris, pnl_kayit_ol);
            Panel_ac_kapa(pnl_ana_giris, pnl_sifre_unut);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Portfoy_ekranı p1 = new Portfoy_ekranı();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool _ekranAc = false;

           _ekranAc=DataLogic.Giriş_Ekranı(txt_giris_kullanici.Text,txt_giris_sifre.Text,_ekranAc);

            if (_ekranAc==true)
            {

               

                p1.Text = string.Concat("Portföyüm  //  Kullanıcı Adı = ", txt_giris_kullanici.Text);

                this.Hide();
                p1.ShowDialog();

                
            }
            
        }

        private void btn_kayit_ol_Click(object sender, EventArgs e)
        {

            if (txt_sifre_ekle.Text==txt_sifre_onay.Text)
            {
                d1.kullanici_ekle(txt_kullanici_ekle.Text, txt_sifre_onay.Text);

                txt_kullanici_ekle.Text = string.Empty;
                txt_sifre_ekle.Text = string.Empty;
                txt_sifre_onay.Text = string.Empty;
                Panel_ac_kapa(pnl_ana_giris, pnl_kayit_ol);
                Panel_ac_kapa(pnl_ana_giris, pnl_sifre_unut);
            }

            else
            {
                XtraMessageBox.Show("Girmiş olduğunuz şifreler eşleşmiyor !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_sifre_sifirla_Click(object sender, EventArgs e)
        {
            d1.Sifre_sifirla(txt_kullanici_adi_sifre_sifirla.Text);

            txt_kullanici_adi_sifre_sifirla.Text = string.Empty;
            Panel_ac_kapa(pnl_ana_giris, pnl_kayit_ol);
            Panel_ac_kapa(pnl_ana_giris, pnl_sifre_unut);
        }

        private void txt_kullanici_ekle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_sifre_ekle.Select();
            }
        }

        private void txt_giris_kullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_giris_sifre.Select();
            }
        }

        private void txt_giris_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_giris_Click(null, null);
            }
        }
    }
}
