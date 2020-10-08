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
             dt.setDate(1,1,1);
         

        }

        public void writeOutput()
        {
            Console.WriteLine(month + " " + day + ", " + year);
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

        public void multiWriteOutput1(int count) {
            while (count > 0) {

                writeOutput();
                //If we do not have thwriteoutput it is invalid
                count--;
            }
                         
        }

        public int getDay()
        {
            return this.day;
        }

        public int getYear() {
            return this.year;
         }

        public int getMonth() {
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
            else {
                return 0;
            }
        }
        public bool isBetween(int lowyear, int highYear)
        {
            return((this.year > lowyear) && (this.year < highYear));
        }


        public bool precedes(DateThirdTry otherDate) {
            return ((this.year < otherDate.year) 
                || (this.year == otherDate.year && getMonth() < otherDate.getMonth()
                || (year == otherDate.year && month.Equals(otherDate.month))&& day<otherDate.day)));
        }
    }
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
//10,9,8,7,6,5,4,3,2,1
//Have to do 10 -19 tomorrow

