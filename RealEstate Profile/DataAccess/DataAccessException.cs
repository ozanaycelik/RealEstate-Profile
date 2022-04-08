using System;

namespace RealEstate_Profile.DataAccess
{
    class DataAccessException : Exception
    {

        public string ErrorDescription { get; set; }
        public int ErrorNumber { get; set; }
    }
}
