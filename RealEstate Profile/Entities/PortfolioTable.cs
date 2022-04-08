using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Profile.Entities
{
    class PortfolioTable
    {

        public string PortfolioNumber { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }
        public string CustomerType { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public double NetTotal { get; set; }

        public string GayrTuru { get; set; }
        public string GayrType { get; set; }

        public string GayrStatus { get; set; }
        public string TapuStatus { get; set; }

        public double BrutArea { get; set; }
        public double NetArea { get; set; }
        public string City { get; set; }

        public string Town { get; set; }
        public string Mahalle { get; set; }

        public DateTime PortfolioDate { get; set; }
        public virtual bool Check { get; set; }
    }
}
