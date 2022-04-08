using System;
using System.Xml;

namespace RealEstate_Profile.Entities
{
    class ExchangeRates
    {

        XmlDocument xml = null;

        const string adres = "http://www.tcmb.gov.tr/kurlar/today.xml";

        public enum KurKodu : byte

        {

            USD, GBP, EUR

        }


        public enum Tur : byte

        {

            ForexBuying, //Döviz alış

            ForexSelling, //Döviz satış

            BanknoteBuying, //Efektif alış

            BanknoteSelling, //Efektif satış

        }

        public ExchangeRates()

        {

            xml = new XmlDocument();

            try
            {
                xml.Load(new XmlTextReader(adres));
            }
            catch (Exception)
            {

                Exception ex;
            }


        }

        public string TlKarsiligi(string kodu, Tur turu)

        {

            string kod = kodu.ToString();

            string tur = turu.ToString();



            XmlNodeList MyNode = xml.SelectNodes("/Tarih_Date/Currency[@Kod ='" + kod + "']/" + tur);

            return MyNode.Item(0).InnerText;

        }
    }
}
