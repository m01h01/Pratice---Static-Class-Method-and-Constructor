using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice___Static_Class__Method__and_Constructor
{
    static class BusinessInfo
    {
        static string _businessName;
        static double _taxAmount;
        static BusinessInfo() 
        {
            BusinessName = "Cafe Nior";
            TaxAmount = 0.1;
        }

        public static string BusinessName { get => _businessName; set => _businessName = value; }
        public static double TaxAmount { get => _taxAmount; set => _taxAmount = value; }
    }
}
