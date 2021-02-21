using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
    public class TashdidModel
    {
        public int Tashdid(int modelCar)
        {
            DateTime dtnow = DateTime.Now;
            int dt = dtnow.Year;

            int diff2 = dt - modelCar;

            int returnforelse = 0;

            if (diff2 > 16)
            {
              int ab = diff2 - 16;

              int c= ab * 1000;
                return c;
            }

            else
            {
                return returnforelse;
            }

           
            
        }
    }
}
