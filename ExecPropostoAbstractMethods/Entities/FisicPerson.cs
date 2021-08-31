using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExecPropostoAbstractMethods.Entities
{
    class FisicPerson : Person
    {
        public double HealthExpeditures { get; set; }

        public FisicPerson(string name, double income, double healthExpeditures)
            : base(name, income)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            if(Income < 20000.00)
            {
                return (Income * 0.15) - (HealthExpeditures * 0.5);
            }
            else
            {
                return (Income * 0.25) - (HealthExpeditures * 0.5);
            }
        }

    }
}
