using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    public class ElectionEligibilityYears
    {
        
        /**
         * The function calculates the number of years that person voted up to this age.
         * 
         * Assumed eligibility age for be able to vote is 18 years old
         * Assumed the election date is before the birthday on the year
         * 
         * TODO: 
         * requesting eligibility age input 
         * comparing birthday and election date     
         */

        public object Calculate(int age)
        {
            if (age < 18) throw new Exception("Invalid Age");

            var eligibleYears = age - 18;
            
            var eligibilityYears = 0;

            for (int i = 1; i <= eligibleYears; i++)
            {
                if (i % 4 == 0) eligibilityYears++;

            }
            return eligibilityYears;
        }
    }
}
