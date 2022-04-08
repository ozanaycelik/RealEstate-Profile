using DevExpress.XtraEditors;
using RealEstate_Profile.Core.Helper;
using RealEstate_Profile.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace RealEstate_Profile.DataAccess
{
    class DataLogic
    {

        public static string _error;



        public static string ConnectionString = ConfigHelper.ConnectionStringSql();



        static DataAccess dataAccess = new DataAccess(ConnectionString, ref _error);

        private static DataAccessException exception;



        /// <summary>
        /// Kullanıcı Giriş Ekranı 
        /// </summary>
        /// <param name="kullanici_adi"></param>
        /// <param name="sifre"></param>
        public static bool Giriş_Ekranı(string kullanici_adi, string sifre, bool _ekranAc)
        {


            var query = @"SELECT * FROM Kullanici_Listesi where kullanici_adi=@p1 and sifre=@p2";

            var parms = new[]
            {
                new SqlParameter("@p1",kullanici_adi),
                new SqlParameter("@p2",sifre)
            };

            var result = dataAccess.ExecuteDataReader(query, parms);

            if (result.Read())
            {
                _ekranAc = true;
            }
            else
            {
                XtraMessageBox.Show("Hatalı kullanıcı adı veya şifre girişi yapıldı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return _ekranAc;
        }


        public void Sifre_sifirla(string kullanici_adi)
        {
            var query = @"Select * from Kullanici_Listesi where kullanici_adi=@p1";

            var parms = new[]
            {
                new SqlParameter("@p1",kullanici_adi)
            };

            var result = dataAccess.ExecuteDataReader(query, parms);

            if (result.Read())
            {

                var delete_query = @"Update Kullanici_Listesi set sifre='' where kullanici_adi=@p1";
                var parms1 = new[]
            {
                new SqlParameter("@p1",kullanici_adi)
            };

                var delete_result = dataAccess.ExecuteNonQuery(delete_query, parms1, ref exception);


                XtraMessageBox.Show("Şifreniz Sıfırlanmıştır !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı sistemde bulunamadı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void kullanici_ekle(string kullanici_adi, string sifre)
        {
            var query = @"select * from Kullanici_Listesi where kullanici_adi=@p1";

            var parms = new[]
            {
                new SqlParameter("@p1",kullanici_adi)
            };

            var result = dataAccess.ExecuteDataReader(query, parms);

            if (result.Read())
            {
                XtraMessageBox.Show("Kullanıcı adı sistemde mevcuttur !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var insert_query = @"INSERT INTO Kullanici_Listesi VALUES (@p1,@p2)";

                var insert_parms = new[]
            {
                new SqlParameter("@p1",kullanici_adi),
                new SqlParameter("@p2",sifre)
            };

                var insert_result = dataAccess.ExecuteNonQuery(insert_query, insert_parms, ref exception);

                XtraMessageBox.Show(string.Concat("Kullanıcı adı=", kullanici_adi, " , Şifre = *****", " oluşturulmuştur. "), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //var query = @"  select TOP 1 convert(varchar(50),
        //                        CONVERT(VARCHAR(50),YEAR(GETDATE()))+
        //                            CONVERT(VARCHAR(50),MONTH(GETDATE()))+
        //                                CONVERT(VARCHAR(50),
        //                                        ROW_NUMBER() OVER(ORDER BY ISNULL( ID,1)))+1) 
        //                            as 'Son' FROM Portfolio_ order by ID DESC";

        public static bool PortfoyArat(string portfoyNumber)
        {
            var bayrak = true;
            var query = @"select * from Portfolio_ where PortfolioNumber=@p1";

            var parms = new[]
            {
                new SqlParameter("@p1",portfoyNumber)
            };


            var result = dataAccess.ExecuteDataReader(query, parms);

            if (result.Read())
            {
                bayrak = true;
            }
            else
            {
                bayrak = false;
            }

            return bayrak;
        }

        public static string portfoy_no()
        {
            var result = string.Empty;

            var query = @"  select TOP 1 convert(varchar(50),
                                CONVERT(VARCHAR(50), YEAR(GETDATE())) +
                                    CONVERT(VARCHAR(50), MONTH(GETDATE())) +
                                        CONVERT(VARCHAR(50),
                                           ISNULL(ID, 1)) + 1)
                                    as 'Son' FROM Portfolio_ order by ID DESC";



            var reader = dataAccess.ExecuteDataReader(query);

            while (reader.Read())
            {
                result = reader["Son"].ToString();
            }


            return result;

        }


        public static List<string> combocagir1(string tablo_adi, string kolon_adi)
        {

            var serviceresult = new List<string>();
            var query = string.Concat(@"select * from " + tablo_adi);

            var result = dataAccess.ExecuteDataReader(query);

            while (result.Read())
            {
                var item = new Gayrimenkul_turu();

                //item.Id = int.Parse(result["ID"].ToString());
                item.Tur = result[kolon_adi].ToString();

                serviceresult.Add(item.Tur);
            }

            return serviceresult;
        }


        /// <summary>
        /// yeni yazdığımız değer bir tabloda var ise o değeri eklemeden yeni değeri veitabanına yazar!!!
        /// </summary>
        /// <param name="deger"></param>
        /// <param name="tablo_adi"></param>
        /// <param name="kolon_adi"></param>
        public void AddValueWithNoMessage(string deger, string tablo_adi, string kolon_adi)
        {
            var query1 = string.Concat(@"select * from " + tablo_adi + " where " + kolon_adi + "=@p1");


            var parms = new[]
            {
                new SqlParameter("@p1", deger)
            };


            var result = dataAccess.ExecuteDataReader(query1, parms);

            if (result.Read())
            {
                //ekleme yok
            }
            else
            {
                var insert_query = string.Concat(@"INSERT INTO ", tablo_adi, " VALUES (@p1)");

                var insert_parms = new[]
            {
                new SqlParameter("@p1",deger),

            };

                var insert_result = dataAccess.ExecuteNonQuery(insert_query, insert_parms, ref exception);
            }


        }


        #region Ana Kayıtlar ekle-değiştir-çıkar
        /// <summary>
        /// Metodun açıklaması işlevini anlatan ifade 
        /// </summary>
        /// <param name="deger"></param>
        /// <param name="tablo_adi"></param>
        public void gayr_ana_kayıt_ekle(string deger, string tablo_adi)
        {
            var query1 = string.Concat(@"select * from " + tablo_adi + " where Tur=@p1");


            var parms = new[]
            {
                new SqlParameter("@p1", deger)
            };


            var result = dataAccess.ExecuteDataReader(query1, parms);

            if (result.Read())
            {
                XtraMessageBox.Show(string.Concat(deger, " sistemde mevcuttur !"), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var insert_query = string.Concat(@"INSERT INTO ", tablo_adi, " VALUES (@p1)");

                var insert_parms = new[]
            {
                new SqlParameter("@p1",deger),

            };

                var insert_result = dataAccess.ExecuteNonQuery(insert_query, insert_parms, ref exception);
            }


        }

        public void gayr_anakayit_degıstır(string eski_deger, string yeni_deger, string tablo_adi)
        {
            var update_query = string.Concat(@"update ", tablo_adi, " SET Tur=@p1 where Tur=@p2 ");

            var parms = new[]
            {
                new SqlParameter("@p1",yeni_deger),
                new SqlParameter("@p2",eski_deger)
            };

            var update_result = dataAccess.ExecuteNonQuery(update_query, parms, ref exception);

        }

        public void gayr_anakayit_sil(string deger, string tablo_adi)
        {
            var delete_query = string.Concat(@"DELETE FROM ", tablo_adi, " WHERE Tur=@p1 ");

            var parms = new[]
            {
                new SqlParameter("@p1",deger)
            };

            var delete_result = dataAccess.ExecuteNonQuery(delete_query, parms, ref exception);

        }
        #endregion


        public static int AddPortfolio(Entities.PortfolioTable arrayPortfolio)
        {

            var result = 0;
            var query = @"INSERT INTO [dbo].[Portfolio_]
           (
            [PortfolioNumber]
           ,[CustomerName]
           ,[CustomerSurname]
           ,[CustomerType]
           ,[Phone1]
           ,[Phone2]
           ,[Email]
           ,[Status]
           ,[NetTotal]
           ,[GayrTuru]
           ,[GayrType]
           ,[GayrStatus]
           ,[TapuStatus]
           ,[BrutArea]
           ,[NetArea]
           ,[City]
           ,[Town]
           ,[Mahalle]
           ,[PortfolioDate])
     VALUES  
            (@PortfolioNumber
            ,@CustomerName
            ,@CustomerSurname
            ,@CustomerType
            ,@Phone1
            ,@Phone2
            ,@Email
            ,@Status
            ,@NetTotal
            ,@GayrTuru
            ,@GayrType
            ,@GayrStatus
            ,@TapuStatus
            ,@BrutArea
            ,@NetArea
            ,@City
            ,@Town
            ,@Mahalle
            ,@PortfolioDate)";

            var parms = new[]
            {
               new SqlParameter("@PortfolioNumber",arrayPortfolio.PortfolioNumber),
               new SqlParameter("@CustomerName",arrayPortfolio.CustomerName),
               new SqlParameter("@CustomerSurname",arrayPortfolio.CustomerSurname),
               new SqlParameter("@CustomerType",arrayPortfolio.CustomerType),
               new SqlParameter("@Phone1",arrayPortfolio.Phone1),
               new SqlParameter("@Phone2",arrayPortfolio.Phone2),
               new SqlParameter("@Email",arrayPortfolio.Email),
               new SqlParameter("@Status",arrayPortfolio.Status),
               new SqlParameter("@NetTotal",arrayPortfolio.NetTotal),
               new SqlParameter("@GayrTuru",arrayPortfolio.GayrTuru),
               new SqlParameter("@GayrType",arrayPortfolio.GayrType),
               new SqlParameter("@GayrStatus",arrayPortfolio.GayrStatus),
               new SqlParameter("@TapuStatus",arrayPortfolio.TapuStatus),
               new SqlParameter("@BrutArea",arrayPortfolio.BrutArea),
               new SqlParameter("@NetArea",arrayPortfolio.NetArea),
               new SqlParameter("@City",arrayPortfolio.City),
               new SqlParameter("@Town",arrayPortfolio.Town),
               new SqlParameter("@Mahalle",arrayPortfolio.Mahalle),
               new SqlParameter("@PortfolioDate",arrayPortfolio.PortfolioDate)

            };

            result = dataAccess.ExecuteNonQuery(query, parms, ref exception);

            return result;

        }


        public static List<PortfolioTable> GetPortfolios(DateTime begDate, DateTime endDate, string town, string Mahalle)
        {
            var serviceResult = new List<PortfolioTable>();

            var query = @" SELECT PortfolioNumber,PortfolioDate,CustomerName,CustomerSurname,Phone1,NetTotal,City,Town,Mahalle FROM Portfolio_
                                    where (PortfolioDate between @begDate and @endDate) and Town LIKE @town and Mahalle LIKE @Mahalle ";

            var parms = new[]
            {
                new SqlParameter("@begDate",begDate),
                new SqlParameter("@endDate",endDate),
                new SqlParameter("@town",town),
                new SqlParameter("@Mahalle",Mahalle)
            };

            var result = dataAccess.GetDataTable(query, parms, ref exception);

            serviceResult = result.AsEnumerable().Select(s => new PortfolioTable
            {
                PortfolioNumber = s.Field<string>("PortfolioNumber"),
                PortfolioDate = s.Field<DateTime>("PortfolioDate"),
                CustomerName = s.Field<string>("CustomerName"),
                CustomerSurname = s.Field<string>("CustomerSurname"),
                Phone1 = s.Field<string>("Phone1"),
                NetTotal = Convert.ToDouble(s.Field<double>("NetTotal")),
                City = s.Field<string>("City"),
                Town = s.Field<string>("Town"),
                Mahalle = s.Field<string>("Mahalle")
            }).ToList();

            return serviceResult;
        }


        /// <summary>
        /// ChangePortfolio show
        /// </summary>
        /// <param name="value"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static string ShowUp(string value, string columns)
        {
            var reader = string.Empty;
            var query = string.Concat(@"SELECT 
       [PortfolioNumber]
      ,[CustomerName]
      ,[CustomerSurname]
      ,[CustomerType]
      ,[Phone1]
      ,[Phone2]
      ,[Email]
      ,[Status]
      ,[NetTotal]
      ,[GayrTuru]
      ,[GayrType]
      ,[GayrStatus]
      ,[TapuStatus]
      ,[BrutArea]
      ,[NetArea]
      ,[City]
      ,[Town]
      ,[Mahalle]
      ,[PortfolioDate]
  FROM [dbo].[Portfolio_] where PortfolioNumber = @p1");

            var parms = new[]
            {
                new SqlParameter("@p1",value)
            };

            var result = dataAccess.ExecuteDataReader(query, parms);

            while (result.Read())
            {
                //item.Id = int.Parse(result["ID"].ToString());
                reader = result[columns].ToString();

            }
            return reader.ToString();

        }


        public void DeletePortfolio(string deger)
        {

            var query = @"Delete from Portfolio_ where PortfolioNumber=@PortfolioNumber";

            var parms = new[]
            {
                new SqlParameter("PortfolioNumber",deger)
            };

            var result = dataAccess.ExecuteNonQuery(query, parms, ref exception);

        }


        public static bool FlagResult(bool flag)
        {

            return flag;
        }



        public void UpdatePortfolio(string PortfolioNumber, string CustomerName, string CustomerSurname,
            string CustomerType, string Phone1, string Phone2, string Email, string Status, string NetTotal, string GayrTuru, string GayrType, string GayrStatus, string TapuStatus,
            string BrutArea, string NetArea, string City, string Town, string Mahalle, string PortfolioDate)
        {

            var query = @"UPDATE Portfolio_
   SET [CustomerName] = @CustomerName
      ,[CustomerSurname] = @CustomerSurname
      ,[CustomerType] = @CustomerType
      ,[Phone1] = @Phone1
      ,[Phone2] = @Phone2
      ,[Email] = @Email
      ,[Status] = @Status
      ,[NetTotal] = @NetTotal
      ,[GayrTuru] = @GayrTuru
      ,[GayrType] = @GayrType
      ,[GayrStatus] = @GayrStatus
      ,[TapuStatus] = @TapuStatus
      ,[BrutArea] = @BrutArea
      ,[NetArea] = @NetArea
      ,[City] = @City
      ,[Town] = @Town
      ,[Mahalle] = @Mahalle
      ,[PortfolioDate] = convert(date,@PortfolioDate,104)
 WHERE PortfolioNumber= @PortfolioNumber";

            var parms = new[]
            {

                new SqlParameter("@PortfolioNumber",PortfolioNumber),
                new SqlParameter("@CustomerName",CustomerName),
                new SqlParameter("@CustomerSurname",CustomerSurname),
                new SqlParameter("@CustomerType",CustomerType),
                new SqlParameter("@Phone1",Phone1),
                new SqlParameter("@Phone2",Phone2),
                new SqlParameter("@Email",Email),
                new SqlParameter("@Status",Status),
                new SqlParameter("@NetTotal",NetTotal),
                new SqlParameter("@GayrTuru",GayrTuru),
                 new SqlParameter("@GayrType",GayrType),
                new SqlParameter("@GayrStatus",GayrStatus),
                new SqlParameter("@TapuStatus",TapuStatus),
                new SqlParameter("@BrutArea",BrutArea),
                new SqlParameter("@NetArea",NetArea),
                new SqlParameter("@City",City),
                new SqlParameter("@Town",Town),
                new SqlParameter("@Mahalle",Mahalle),
                new SqlParameter("@PortfolioDate",PortfolioDate)
            };

            var result = dataAccess.ExecuteNonQuery(query, parms, ref exception);

        }
    }
}
