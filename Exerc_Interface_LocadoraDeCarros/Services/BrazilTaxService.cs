using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Interface_LocadoraDeCarros.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
