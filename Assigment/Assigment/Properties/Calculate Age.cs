using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Properties
{
    internal class Calculate_Age
    {
        private int birthYear;
        
        public Calculate_Age(int birthYear)
        {
            this.birthYear = birthYear;
        }
        public int Agecalculate()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - birthYear;
        }

    }
}
