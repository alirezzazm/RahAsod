using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationInsurace
{
    public static class InsuraceCal
    {

       
       



        public static string NameCar { get; set; }

        //تاریخ شروع و پایان بیمه نامه قبلی برای دیر کرد یا جریمه
        public static DateTime StartInsuracePass { get; set; }
        public static DateTime EndInsuracePass { get; set; }

        //تاریخ شروع و پایان بیمه نامه جدید برای اینکه کوتاه مدت می خواهد بزند
        public static DateTime StartInsuraceNow { get; set; }
        public static DateTime EndInsuraceNow { get; set; }

        //پوشش مالی در هر قسمت قیمت های متفاوتی دارد
        public static int Financial { get; set; }


        //مدل ماشین مهم است چون از سال 1383 در سال 1399 به قیمت ها تشدید مدل می خورد
        public static int ModelCar { get; set; }

        //درصد تخفیف راننده برای کم کردن قیمت بیمه نامه
        public static int DriverPercent { get; set; }
        //درصد تخفیف بیمه نامه برای کم کردن قیمت بیمه نامه
        public static int DriverInsurace { get; set; }

        //ایا خسارت مالی داشته است یا خیر
        public static bool AccidentFinancial { get; set; }

        //ایا خسارت جانی داشته است یا خیر
        public static bool AccidentBody { get; set; }



    }
}
