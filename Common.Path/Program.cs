using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var len3 = "1000006768".Length;

            var dt30 = DateTime.Today.AddDays(-1);

            Regex regex = new Regex(@"^\d{4}/\d{1,2}/\d{1,2}$");
            if (!regex.Match(@"2021/121/02").Success)
            {

            }

            Regex regex2 = new Regex(@"^\d{4}-\d{1,2}-\d{1,2}$");
            if (!regex2.Match(@"2020-03-03 项目日常会").Success)
            {

            }

            var dtStr3 = DateTime.Now.ToShortDateString();

            DateTime dt2 = Convert.ToDateTime(@"Aug 16 2019 12:00AM");

            var guid = new Guid();


            DateTime _currentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var dt3 = _currentDate.AddDays(0 - 30);

            DateTime compareDate = Convert.ToDateTime("2021-02-13 02:00:00.000");

            var str3 = $"{_currentDate:yyyy-MM-dd}";

            TimeSpan compareDateTimeSpan = new TimeSpan(compareDate.Ticks);
            TimeSpan currentDateTimeSpan = new TimeSpan(_currentDate.Ticks);

            //周
            TimeSpan diffTimeSpan = compareDateTimeSpan.Subtract(currentDateTimeSpan).Duration();
            var a = diffTimeSpan.Days != 0 && diffTimeSpan.Days % 7 == 0;


            //季度
            //if (_currentDate.Day == compareDate.Day
            //        && (_currentDate.Year != compareDate.Year || _currentDate.Month != compareDate.Month)
            //        && ((_currentDate.Year - compareDate.Year) * 12 + (_currentDate.Month - compareDate.Month)) % 3 == 0)
            //{
            //    int a = 3;

            //}
            //else
            //{
            //    int b = 4;

            //}

            //月度
            if (_currentDate.Day == compareDate.Day
                 && (_currentDate.Year != compareDate.Year || _currentDate.Month != compareDate.Month))
            {
                var a3 = 3;
            }
            else
            {
                var b = 33;
            }

            var a333 = GetCode("3");
            var a22 = GetCode("2");
            var a11 = GetCode("1");


        }



        private static int GetCode(string code)
        {
            int result = 0;

            switch (code)
            {
                case "3":
                    result = 3;
                    break;
                case "2":
                case "1":
                    result = 1;
                    break;
                default:
                    result = 99;
                    break;
            }
            return result;
        }

    }
}
