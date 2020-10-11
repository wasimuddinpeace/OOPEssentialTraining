//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;

//namespace OOPEssentialTraining
//{
//    class LeapYear
//    {
//        public string month;
//        public int day;
//        public int year;

//        public bool DateOk(int _month, int _day, int _year)
//        {

//            if (this.getDaysInAMonth(_year) == 29 || this.getDaysInAMonth(_year) == 28)
//            {

//               return ((_month >= 1) && (_month <= 12) && (_day >= 1)
//                       && (_day <= 31) & (_year >= 1000) && (_year <= 9999));
//            }
//            return false;

//        }

//        public int getDaysInAMonth(int year)
//        {
//            int[] daysIfLeapYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//            int[] daysIfNotLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

//            if (this.FindLeapYear(year) == true && daysIfLeapYear[0] == 31 && daysIfLeapYear[1] == 29 && daysIfLeapYear[2] == 31
//                    && daysIfLeapYear[3] == 30 && daysIfLeapYear[4] == 31 && daysIfLeapYear[5] == 30
//                    && daysIfLeapYear[6] == 31 && daysIfLeapYear[7] == 31 && daysIfLeapYear[8] == 30
//                    && daysIfLeapYear[9] == 31 && daysIfLeapYear[10] == 30 && daysIfLeapYear[11] == 31)
//            {
//                return daysIfLeapYear[1];
//            }
//            else if (daysIfNotLeapYear[0] == 31 && daysIfNotLeapYear[1] == 28 && daysIfNotLeapYear[2] == 31
//                    && daysIfNotLeapYear[3] == 30 && daysIfNotLeapYear[4] == 31 && daysIfNotLeapYear[5] == 30
//                    && daysIfNotLeapYear[6] == 31 && daysIfNotLeapYear[7] == 31 && daysIfNotLeapYear[8] == 30
//                    && daysIfNotLeapYear[9] == 31 && daysIfNotLeapYear[10] == 30 && daysIfNotLeapYear[11] == 31)
//            {
//                return daysIfNotLeapYear[1];
//            }
//            else {
//                return 0;
//             }
//        }


//        public bool FindLeapYear(int year)
//        {
//            if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
//            {
//                return true;
//            }
//            return false;

//        }
//        //private String monthString(int monthNumber)
//        //{
//        //    switch (monthNumber)
//        //    {
//        //        case 1:
//        //            return "January";
//        //        case 2:
//        //            return "February";
//        //        case 3:
//        //            return "March";
//        //        case 4:
//        //            return "April";
//        //        case 5:
//        //            return "May";
//        //        case 6:
//        //            return "June";
//        //        case 7:
//        //            return "July";
//        //        case 8:

//        //            return "August";
//        //        case 9:
//        //            return "September";
//        //        case 10:
//        //            return "October";
//        //        case 11:
//        //            return "November";
//        //        case 12:
//        //            return "December";
//        //        default:
//        //            Console.WriteLine("Fatal Error");
//        //            return "Error"; //to keep the compiler happy
//        //    }
//        //}




//    }
//}