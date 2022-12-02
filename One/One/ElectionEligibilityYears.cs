using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    public class ElectionEligibilityYears
    {
        public object Calculate(int age)
        {
            if (age < 18) throw new Exception("Invalid Age");

            var eligibleYears = age - 18;
            
            var eligibilityYears = 0;

            for (int i = 1; i < eligibleYears; i++)
            {
                if (i % 4 == 0) eligibilityYears = +1;

            }
            return eligibilityYears;
        }
    }
}
