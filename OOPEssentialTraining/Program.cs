using System;
using System.Runtime.CompilerServices;

namespace OOPEssentialTraining
{
    //class Program
    //{
    //    public int MyProperty { get; set; }
    //    static void Main(string[] args)
    //    {
        
    //    Console.WriteLine("Hello World!");
            
    //}

        public class DateFirstTry
        {

            //Instance  Variable
            private String month;
            public int day;
            public int year; //a four digit number. 
            public void writeOutput() { 
                Console.WriteLine(month + " " + day + ", " + year); 
            }

        static void Main(string[] args)
        {
            DateFirstTry dt = new DateFirstTry();
            dt.happyGreeting();


        }
        //}
        //Using Instance variable
        //month.equalsIgnoreCase("February)

        // the parentnesis of a method has values those are called as parameters and 
        // the value provided to the parameter on that method invocation is called arguments

        public void makeItnewYear() {
                this.month = "January";
                this.day = 1;
               
            }

            //If condition
            public void yellIfnewYear() {
                if (this.month == "January" && this.day==1)
                {
                    Console.WriteLine("Hurray!!");
                }
                else {
                    Console.WriteLine("Not a new Year Day");
                }
            }

            //Write a method called getNextYear that could be added to the class
            //DateSecondTry in Display 4.2. The method getNextYear returns an int value
            //equal to the value of the year instance variable plus one.

            public int getNextYear() {
                return this.year + 1;
            }

            public void happyGreeting() {
                this.day = 3;
                for (int i = 0; i < this.day; i++) 
                 {
                    Console.WriteLine("Happy Days!!");
                }
            }
        }
        }

