using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ThomasM_PayrollProgram
{
    class Validator
    {
        public bool isSSN(string ssn)
        { 
            Regex regx = new Regex(@"^\d{9}");
            return regx.IsMatch(ssn);
        }
    }
}