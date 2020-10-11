using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OOPEssentialTraining
{

    public class DateFirstTry
    {

        //Instance  Variable
        private String month;
        public int day;
        public int year; //a four digit number. 

        //static void Main(string[] args)
        //{
        //    DateFirstTry dt = new DateFirstTry();
        //    dt.happyGreeting();
        //    dt.readInputfromKeyboard();
        //    dt.getMonth();


        //}
        //}
        //Using Instance variable
        //month.equalsIgnoreCase("February)

        // the parentnesis of a method has values those are called as parameters and 
        // the value provided to the parameter on that method invocation is called arguments

        public void makeItnewYear()
        {
            this.month = "January";
            this.day = 1;

        }
        public void writeOutput()
        {
            Console.WriteLine(month + " " + day + ", " + year);
        }

        //If condition
        public void yellIfnewYear()
        {
            if (this.month == "January" && this.day == 1)
            {
                Console.WriteLine("Hurray!!");
            }
            else
            {
                Console.WriteLine("Not a new Year Day");
            }
        }

        //Write a method called getNextYear that could be added to the class
        //DateSecondTry in Display 4.2. The method getNextYear returns an int value
        //equal to the value of the year instance variable plus one.


        //Read Input from Keyboard

        public void readInputfromKeyboard()
        {

            var val = Console.ReadLine();

            int convertToInt = Convert.ToInt32(val);
            Console.WriteLine(convertToInt);
        }

        //How to convert a month which is a string to a number and return an int based on the month
        //i.e return 1 if month is januaruy and retirn 2 if month is february

        public int getMonth()
        {
            this.month = "January";
            if (month.Equals("January", StringComparison.InvariantCultureIgnoreCase))
                return 1;
            else
            {
                return 0;
            }
        }


        //Homework Questions
        public int getNextYear()
        {
            return this.year + 1;
        }

        public void happyGreeting()
        {
            this.day = 3;
            for (int i = 0; i < this.day; i++)
            {
                Console.WriteLine("Happy Days!!");
            }
        }


    }


    public class DateThirdTry
    {

        private string month;
        private int day;
        private int year;

        static void Main(string[] args)
        {
            DateThirdTry dt = new DateThirdTry();
            LeapYear lp = new LeapYear();
            lp.DateOk(2, 30, 1992);
            //  dt.setDate(1, 1, 1);

            dt.day = 15;
        }


        public void writeOutput()
        {
            Console.WriteLine(this.month + " " + day + ", " + year);
        }
        public void setDate(int newDay, int newMonth, int newYear)
        {

            this.day = newDay;
            this.month = monthString(newMonth);
            this.year = newYear;
        }

        public string monthString(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "Febrauary";
                case 3:
                    return "March";
                case 4:
                    return "April";
                default:
                    return "Error";

            }

        }

        //Seif-Test Excercises 5
        public double fractionDone(int targetDay)
        {
            targetDay = 12;
            this.day = 10;
            double timePassedInthisMonth = this.day / targetDay;
            return timePassedInthisMonth;
        }


        //Seif-Test Excercises 6
        public int advanceYear(int advanceYear)
        {
            return this.year + advanceYear;
        }

        //Seif-Test Excercises 7
        public void setDateNew(int newMonth, int newDay, int newYear)
        {
            month = monthString(newMonth);
            day = newDay;
            year = newYear;
            Console.WriteLine("Date changed to "
             + newMonth + " " + newDay + ", " + newYear);
        }
        //No instances 


        public void multiWriteOutput(int count)
        {
            while (count > 0)
            {//WriteOutput does not exist in the cou
                writeOutput();
                count--;
            }
        }

        public void multiWriteOutput1(int count)
        {
            while (count > 0)
            {

                writeOutput();
                //If we do not have thwriteoutput it is invalid
                count--;
            }

        }

        public int getDay()
        {
            return this.day;
        }

        public int getYear()
        {
            return this.year;
        }

        public int getMonth()
        {
            if (this.month.Equals("January", StringComparison.InvariantCultureIgnoreCase))
                return 1;
            else if (this.month.Equals("February", StringComparison.InvariantCultureIgnoreCase))
                return 2;
            else if (this.month.Equals("March", StringComparison.InvariantCultureIgnoreCase))
                return 3;
            else if (this.month.Equals("April", StringComparison.InvariantCultureIgnoreCase))
                return 4;
            else if (this.month.Equals("May", StringComparison.InvariantCultureIgnoreCase))
                return 5;
            else if (this.month.Equals("June", StringComparison.InvariantCultureIgnoreCase))
                return 6;
            else if (this.month.Equals("July", StringComparison.InvariantCultureIgnoreCase))
                return 7;
            else if (this.month.Equals("August", StringComparison.InvariantCultureIgnoreCase))
                return 8;
            else if (this.month.Equals("September", StringComparison.InvariantCultureIgnoreCase))
                return 9;
            else if (this.month.Equals("October", StringComparison.InvariantCultureIgnoreCase))
                return 10;
            else if (this.month.Equals("November", StringComparison.InvariantCultureIgnoreCase))
                return 11;
            else if (this.month.Equals("December", StringComparison.InvariantCultureIgnoreCase))
                return 12;
            else
            {
                return 0;
            }
        }
        public bool isBetween(int lowyear, int highYear)
        {
            return ((this.year > lowyear) && (this.year < highYear));
        }


        //public bool precedes(DateThirdTry otherDate)
        //{
        //    return ((this.year < otherDate.year)
        //        || (this.year == otherDate.year && getMonth() < otherDate.getMonth()
        //        || (year == otherDate.year && month.Equals(otherDate.month)) && day < otherDate.day));
        //}




        // we used month since we are compairing the objects
        // we used getMonth() since we are compairing the property here not the object
        //. Consider the definition of the method monthString in Display 4.4. Why are
        //there no break statements in the switch statement?

        //since it has to check all the cases from jan to dec


        //The method writeOutput in Display 4.2 uses the instance variables month,
        //day, and year, but gives no object name for these instance variables.Every
        // instance variable must belong to some object. To what object or objects do
        //these instance variables in the definition of writeOutput belong

        //Answer: These should ideally belongs to dateSecondtry

        // Rewrite the definitions of the methods getDay and getYear in Display 4. using the this parameter.


        // Rewrite the method getMonth in Display 4.2 using the this parameter. Methods That Return a Boolean Val


        //    In the definition of precedes in Display 4.7, we used
        //month.equals(otherDate.month)
        // to test whether two months are equal; but we used
        //getMonth() < otherDate.getMonth()
        //to test whether one month comes before another.Why did we use month in
        //one case and getMonth in another case?

        //14. What is the fundamental rule for testing methods?
        //Every method should be tested in a program in which every other method in the testing
        // program has already been fully tested and debugged.
    }

    public class LeapYear
    {
        public string month;
        public int day;
        public int year;

        public bool DateOk(int _month, int _day, int _year)
        {

            if (this.getDaysInAMonth(_year,_day) == 29 || this.getDaysInAMonth(_year,_day) == 28)
            {

                return ((_month >= 1) && (_month <= 12) && (_year >= 1000) && (_year <= 9999));
            }
            return false;

        }

        public int getDaysInAMonth(int year, int _day)
         {
            int[] daysIfLeapYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] daysIfNotLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (this.FindLeapYear(year) == true && daysIfLeapYear[0] == 31 && daysIfLeapYear[1] == 29 && daysIfLeapYear[2] == 31
                    && daysIfLeapYear[3] == 30 && daysIfLeapYear[4] == 31 && daysIfLeapYear[5] == 30
                    && daysIfLeapYear[6] == 31 && daysIfLeapYear[7] == 31 && daysIfLeapYear[8] == 30
                    && daysIfLeapYear[9] == 31 && daysIfLeapYear[10] == 30 && daysIfLeapYear[11] == 31)
            {

                int daysInJan = daysIfLeapYear[0];
                int daysInfeb = daysIfLeapYear[1];
                int daysInMarch = daysIfLeapYear[2];
                int daysInApril = daysIfLeapYear[3];
                int daysInMay = daysIfLeapYear[4];
                int daysInJune = daysIfLeapYear[5];
                int daysIuly = daysIfLeapYear[6];
                int daysInAugust = daysIfLeapYear[7];
                int daysInSeptember = daysIfLeapYear[8];
                int daysInOctober = daysIfLeapYear[9];
                int daysInNovember = daysIfLeapYear[10];
                int daysInDec = daysIfLeapYear[11];
                if (_day > daysInJan || _day > daysInfeb || _day > daysInMarch || _day > daysInApril || _day > daysInMay || _day > daysInJune || _day > daysIuly || _day > daysInAugust
                        || _day > daysInSeptember || _day > daysInOctober || _day > daysInNovember || _day > daysInDec)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return daysIfLeapYear[1];
            }
            else if (daysIfNotLeapYear[0] == 31 && daysIfNotLeapYear[1] == 28 && daysIfNotLeapYear[2] == 31
                    && daysIfNotLeapYear[3] == 30 && daysIfNotLeapYear[4] == 31 && daysIfNotLeapYear[5] == 30
                    && daysIfNotLeapYear[6] == 31 && daysIfNotLeapYear[7] == 31 && daysIfNotLeapYear[8] == 30
                    && daysIfNotLeapYear[9] == 31 && daysIfNotLeapYear[10] == 30 && daysIfNotLeapYear[11] == 31)
            {
                int daysInJan = daysIfNotLeapYear[0];
                int daysInfeb = daysIfNotLeapYear[1];
                int daysInMarch = daysIfNotLeapYear[2];
                int daysInApril = daysIfNotLeapYear[3];
                int daysInMay = daysIfNotLeapYear[4];
                int daysInJune = daysIfNotLeapYear[5];
                int daysIuly = daysIfNotLeapYear[6];
                int daysInAugust = daysIfNotLeapYear[7];
                int daysInSeptember = daysIfNotLeapYear[8];
                int daysInOctober = daysIfNotLeapYear[9];
                int daysInNovember = daysIfNotLeapYear[10];
                int daysInDec = daysIfNotLeapYear[11];
                if (_day > daysInJan || _day > daysInfeb || _day > daysInMarch || _day > daysInApril || _day > daysInMay || _day > daysInJune || _day > daysIuly || _day > daysInAugust
                        || _day > daysInSeptember || _day > daysInOctober || _day > daysInNovember || _day > daysInDec)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return daysIfNotLeapYear[1];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }


        public bool FindLeapYear(int year)
        {
            if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
            {
                return true;
            }
            return false;

        }

    }
}

//10,9,8,7,6,5,4,3,2,1
//Have to do 10 -19 tomorrow

