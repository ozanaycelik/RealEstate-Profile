using RealEstate_Profile.Ana_Kayıtlar;
using System;
using System.Windows.Forms;
using RealEstate_Profile.Portfolios;
using RealEstate_Profile.DataInsert;
using System.Drawing;

namespace RealEstate_Profile
{
    public partial class Portfoy_ekranı : DevExpress.XtraEditors.XtraForm
    {
        public Portfoy_ekranı()
        {
            InitializeComponent();
        }

      


        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_giris f1 = new frm_giris();
            this.Hide();
            f1.Show();
        }


        private void Portfoy_ekranı_Load(object sender, EventArgs e)
        {
            lbl_sayac.BackColor = Color.White;

            timer1.Start();

            panelControl1.Visible = false;

            cbx_firstvalue.Properties.Items.Add(Entities.ExchangeRates.KurKodu.USD);
            cbx_firstvalue.Properties.Items.Add(Entities.ExchangeRates.KurKodu.GBP);
            cbx_firstvalue.Properties.Items.Add(Entities.ExchangeRates.KurKodu.EUR);


            cbx_secondvalue.Properties.Items.Add(Entities.ExchangeRates.KurKodu.USD);
            cbx_secondvalue.Properties.Items.Add(Entities.ExchangeRates.KurKodu.GBP);
            cbx_secondvalue.Properties.Items.Add(Entities.ExchangeRates.KurKodu.EUR);
        }


        private void yeniPortföyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPortfolio a1 = new AddPortfolio();


            a1.ShowDialog();

            

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void gayrimenkulTürleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gayrimenkul_Türü ga = new Gayrimenkul_Türü();
            ga.StartPosition = FormStartPosition.CenterParent;
            ga.ShowDialog();
        }

        private void gayrimenkulTiplerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GayrimenkulTipi gt = new GayrimenkulTipi();
            gt.StartPosition = FormStartPosition.CenterParent;
            gt.ShowDialog();

        }

        private void gayrimenkulDurumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GayrimenkulDurumu gd = new GayrimenkulDurumu();
            gd.StartPosition = FormStartPosition.CenterParent;
            gd.ShowDialog();
        }

        private void tapuDurumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tapu_Durumu td = new Tapu_Durumu();
            td.StartPosition = FormStartPosition.CenterParent;
            td.ShowDialog();
        }

        private void portföyAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataInsert.DataInsert dı = new DataInsert.DataInsert();
            dı.StartPosition = FormStartPosition.CenterParent;

            dı.ShowDialog();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            portfolios p1 = new portfolios();

            p1.StartPosition = FormStartPosition.CenterParent;
            p1.ShowDialog();
        }

        private void kurHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelControl1.Visible = true;

            txt_hesapla.Visible = false;

            cbx_firstvalue.SelectedIndex = 0;

            cbx_secondvalue.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txt_firstvalue.Text.Replace(".",","));
            double sayi2 = double.Parse(txt_secondvalue.Text.Replace(".", ","));
            double sonuc = 0;



            if (cbx_secondvalue.SelectedItem=="TL")
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 * sayi2;
            }

            txt_hesapla.Text = sonuc.ToString();

            txt_hesapla.Visible = true;
        }

        private void cbx_firstvalue_Properties_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbx_firstvalue.SelectedItem=="TL")
            {
                txt_firstvalue.Text = "1";
            }
            else
            {
                Entities.ExchangeRates E1 = new Entities.ExchangeRates();

                var kur = string.Empty;

                kur = E1.TlKarsiligi(cbx_firstvalue.SelectedItem.ToString(), Entities.ExchangeRates.Tur.ForexBuying);

                txt_firstvalue.Text = kur;
            }

            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            panelControl1.Visible = false;
        }

        int saniye = 0;
        int dakika = 0;
        int saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye++;

            if (saniye == 59)
            {
                saniye = 0;
                dakika++;

                if (dakika==59)
                {
                    dakika = 0;
                    saat++;

                    if (saat==59)
                    {
                        saniye = 0;
                        dakika = 0;
                        saat = 0;
                    }
                }
            }

           lbl_sayac.Text = string.Concat(" Kullanım Süresi = " ,saat,":",dakika,":", saniye);
            
        }


       
       
    }
}