using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Profile.DataAccess
{
    class DataAccessException : Exception
    {

        public string ErrorDescription { get; set; }
        public int ErrorNumber { get; set; }
    }
}
