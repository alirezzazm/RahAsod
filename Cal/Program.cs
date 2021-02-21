using CalculationInsurace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name Car:");
            string qeymat = InsuraceCal.NameCar = Console.ReadLine();
            QeimatPaye qeimat = new QeimatPaye();
            int q = qeimat.Cars(qeymat);

            Console.WriteLine("Model Car:");

            int model = InsuraceCal.ModelCar = int.Parse(Console.ReadLine());
            TashdidModel tashdid = new TashdidModel();
            int t = tashdid.Tashdid(model);


            Console.WriteLine("StartInsuraceNow Car:");
            var startnow = InsuraceCal.StartInsuraceNow = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("EndInsuraceNow Car:");
            var endnow = InsuraceCal.EndInsuraceNow = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("StartInsuracePass Car:");
            var startpass = InsuraceCal.StartInsuracePass = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("EndInsuracePass Car:");
            var endpass = InsuraceCal.EndInsuracePass = DateTime.Parse(Console.ReadLine());
            JarimeClass jarime = new JarimeClass();
            int j = jarime.Jarime(endpass, startnow);




            Console.WriteLine("Financial Car:");
            int mali = InsuraceCal.Financial = int.Parse(Console.ReadLine());
            MaliClass mali1 = new MaliClass();
            int m = mali1.Mali(mali);


            Console.WriteLine("DriverPercent Car:");
            InsuraceCal.DriverPercent = int.Parse(Console.ReadLine());
            Console.WriteLine("DriverInsurace Car:");
            InsuraceCal.DriverInsurace = int.Parse(Console.ReadLine());


            Console.WriteLine("AccidentBody Car:");
            bool a = InsuraceCal.AccidentBody = bool.Parse(Console.ReadLine());
            JaniMali janiMali = new JaniMali();
            int result1 = janiMali.JaniAccident(a);



            Console.WriteLine("AccidentFinancial Car:");
            bool b = InsuraceCal.AccidentFinancial = bool.Parse(Console.ReadLine());
            int result2 = janiMali.MaliAccident(b);




            Console.WriteLine("----------------------------------");
            Console.WriteLine($"NameCar:{InsuraceCal.NameCar}");
            Console.WriteLine($"StartInsuraceNow:{InsuraceCal.StartInsuraceNow}");
            Console.WriteLine($"EndInsuraceNow:{InsuraceCal.EndInsuraceNow}");
            Console.WriteLine($"StartInsuracePass:{InsuraceCal.StartInsuracePass}");
            Console.WriteLine($"EndInsuracePass:{InsuraceCal.EndInsuracePass}");
            Console.WriteLine($"DriverPercent:{InsuraceCal.DriverPercent}%");
            Console.WriteLine($"DriverInsurace:{InsuraceCal.DriverInsurace}%");
            Console.WriteLine($"ModelCar:{ InsuraceCal.ModelCar}");
            Console.WriteLine($"Financial: {InsuraceCal.Financial}");
            Console.WriteLine($"AccidentBody: {InsuraceCal.AccidentBody}");
            Console.WriteLine($"AccidentFinancial: {InsuraceCal.AccidentFinancial}");

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Jarime For Baraye dir Kard: {j}");
            Console.WriteLine($"Hazineye Posheshe Mali: {m}");
            Console.WriteLine($"Jarime Tashdid model: {t}");
            Console.WriteLine($"Takhfif bime name nahaii:{result1},{result2}");
            Console.WriteLine($"QeymatPaye:{q}");

            Console.WriteLine("----------------------------------");
            QeymatNahaii nahaii = new QeymatNahaii();
            float c = nahaii.JameQeymat(j, m, t, result1, result2, q);
            Console.WriteLine($"QeymatNahaii:{c}");


            Console.ReadKey();
        }
    }
}
