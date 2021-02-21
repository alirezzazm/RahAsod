using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
  public  class QeimatPaye
    {
        int a = 2400;
        int b = 2080;
        int c = 600;
        int d = 0;
        string[] nc = {"beneli","peykan","samand" };
        public int Cars(string nameCar)
        {
            if (nameCar == nc[0])
            {
                return c;
            }
            else if (nameCar == nc[1])
            {
                return b;
            }
            else if (nameCar == nc[2])
            {
                return a;
            }

            else
            {
                return d;
            }

        }

    
    }
}
