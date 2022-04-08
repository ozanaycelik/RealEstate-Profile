using System;

namespace RealEstate_Profile.Extensions.CastExtensions
{
    public static class CastExtensions
    {


        /// <summary>
        /// Parametre verilen değeri interger a çevirmeye çalışır çeviremezse 0 döner.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt(this object value)
        {
            int ınt32;
            try
            {
                if (value == null)
                {
                    throw new Exception();
                }
                ınt32 = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                ınt32 = 0;
            }
            return ınt32;
        }

        public static decimal ToDecimal(this object value)
        {
            decimal decimal1;
            try
            {
                if (value == null)
                {
                    throw new Exception();
                }
                decimal1 = Convert.ToDecimal(value);
            }
            catch (Exception)
            {
                decimal1 = 0;
            }
            return decimal1;
        }

        public static double ToDouble(this object value)
        {
            double double_;
            try
            {
                if (value == null)
                {
                    throw new Exception();
                }
                double_ = Convert.ToDouble(value);
            }
            catch (Exception)
            {
                double_ = 0;
            }
            return double_;
        }

        public static DateTime ToDateTime(this object value)
        {
            DateTime date;
            try
            {
                if (value == null)
                {
                    throw new Exception();
                }
                date = Convert.ToDateTime(value);
            }
            catch (Exception)
            {
                date = DateTime.Now;
            }
            return date;
        }

        public static bool ToBool(this object value)
        {
            bool kontrol;

            try
            {
                if (value == null)
                {
                    throw new Exception();
                }
                kontrol = Convert.ToBoolean(value);
            }
            catch (Exception)
            {
                kontrol = false;

            }

            return kontrol;
        }

        public static string ToString(this object value)
        {
            string String;

            try
            {
                if (value == null)
                {
                    throw new Exception();
                }
                String = Convert.ToString(value);
            }
            catch (Exception)
            {
                String = string.Empty;


            }

            return String;
        }
        public static short ToInt16(this object sayi)
        {
            short ınt16;
            try
            {
                if (sayi == null)
                {
                    throw new Exception();
                }
                ınt16 = Convert.ToInt16(sayi);
            }
            catch (Exception)
            {
                ınt16 = 0;
            }
            return ınt16;
        }

        public static int ToInt32(this object sayi)
        {
            int ınt32;
            try
            {
                if (sayi == null)
                {
                    throw new Exception();
                }
                ınt32 = Convert.ToInt32(sayi);
            }
            catch (Exception)
            {
                ınt32 = 0;
            }
            return ınt32;
        }

        public static long ToInt64(this object sayi)
        {
            long ınt64;
            try
            {
                if (sayi == null)
                {
                    throw new Exception();
                }
                ınt64 = Convert.ToInt64(sayi);
            }
            catch (Exception)
            {
                ınt64 = (long)0;
            }
            return ınt64;
        }
    }
}
