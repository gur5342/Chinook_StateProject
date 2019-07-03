using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public partial class Invoice :Entity
    {
        public override string ToText()
        {
            return $"{BillingCountry}";
        }

        public string CustomerFirstName{ get; internal set; }
        public string CustomerLastName { get; internal set; }
    }
}
