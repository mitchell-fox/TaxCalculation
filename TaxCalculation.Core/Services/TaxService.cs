using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculation.Core.Interfaces;

namespace TaxCalculation.Core.Services
{
    public class TaxService
    {
        private readonly ITaxCalculator taxCalculator;

        public TaxService(ITaxCalculator taxCalculator)
        {
            this.taxCalculator = taxCalculator;
        }

        public TaxRate GetTaxRateForLocation(Location location)
        {
            return taxCalculator.
        }

        public Taxes CalculateTaxesForOrder(Order order)
        {

        }
    }
}
