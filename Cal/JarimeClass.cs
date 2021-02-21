using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
    public class JarimeClass
    {
       public int Jarime(DateTime passdate,DateTime nowDate)
        {

          
            string diff2 = (nowDate - passdate).Days.ToString();

            int a = Convert.ToInt32(diff2) * 1000;

            return a;

        }

    }
}
