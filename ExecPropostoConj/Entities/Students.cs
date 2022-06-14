using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecPropostoConj.Entities
{
    internal class Students
    {
        public int Registration { get; set; }

        public Students(int registration)
        {
            Registration = registration;
        }

        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Students))
            {
                return false;
            }
            return Registration.Equals(((Students)obj).Registration);
        }
    }
}
