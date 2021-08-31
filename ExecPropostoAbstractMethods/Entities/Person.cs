using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecPropostoAbstractMethods.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        abstract public double Tax();




    }

    

}
