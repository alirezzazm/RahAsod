using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
  public  class MaliClass
    {
        int a;
      
        public int Mali(int abc)
        {
      

            switch (abc)
            {
                case 11:
                    int v = abc * 11;
                    a = v;
                    break;

                case 22:
                    int v1 = abc * 22;
                    a = v1;
                    break;

                case 34:
                    int v2 = abc * 34;
                    a = v2;
                    break;
                default:
                    Console.WriteLine("not number write");
                    break;



            }

            return a;

        }
    }
}
