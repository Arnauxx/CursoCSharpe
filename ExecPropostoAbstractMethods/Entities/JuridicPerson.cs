using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecPropostoAbstractMethods.Entities
{
    class JuridicPerson : Person
    {
        public int Employees { get; set; }

        public JuridicPerson(string name, double income, int employees)
            : base(name, income)
        {
            Employees = employees;
        }


        public override double Tax()
        {
            if(Employees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }



    }
}
