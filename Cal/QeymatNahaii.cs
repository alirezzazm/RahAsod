using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
    public class QeymatNahaii
    {



        public float JameQeymat(int jarime, int mali, int tashdid, int takhfifbime, int takhfifranande, int qeymatpaye)
        {
            float cal = qeymatpaye - (qeymatpaye * takhfifbime / 100);


            try
            {
                if (jarime != 0 || tashdid != 0 || mali != 11)
                {
                    return cal + jarime + tashdid + mali;

                }


                else if (tashdid != 0 || jarime != 0)
                {
                    return cal + jarime + tashdid;
                }
                else if (tashdid != 0 || mali != 11)
                {
                    return cal + tashdid + mali;
                }
                else if (jarime != 0 || mali != 11)
                {
                    return cal + jarime + mali;
                }



                else if (mali != 11)
                {
                    return cal + mali;
                }
                else if (tashdid != 0)
                {
                    return cal + tashdid;
                }
                else if (jarime != 0)
                {
                    return cal + jarime;
                }



                else
                {
                    return cal;
                }

            }
            catch (Exception)
            {

                throw new Exception("it is problem"); 

            }
          

        }

    }
}
