using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
    class JaniMali
    {
        
        public int MaliAccident(bool mali_accident)
        {
            if (mali_accident)
            {
                int drI = InsuraceCal.DriverInsurace - 20;
                return drI;
            }
            else
            {
                int drI2 = InsuraceCal.DriverInsurace;
                return drI2;
            }
           
            
        }
        public int JaniAccident(bool jani_accident)
        {
            
            if (jani_accident)
            {
                int drI = InsuraceCal.DriverInsurace - 40;
                return drI;
            }
            else
            {
                int drI2 = InsuraceCal.DriverInsurace;
                return drI2;
            }
        }
    }
}
