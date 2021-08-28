using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExecPropostoSectionTen.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        private double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return base.Name +
            " $ " +
            TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
            " (Custom fee: $ " +
            CustomsFee.ToString("F2", CultureInfo.InvariantCulture) +
            ")";
        }
    }
}
