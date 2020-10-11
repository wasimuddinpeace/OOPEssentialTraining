using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOPEssentialTraining
{
    class GettersAndSetters
    {

        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNumber { get; set; }


        public String FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public static void main(string[] args) {
            GettersAndSetters gt = new GettersAndSetters();
            
        } 
       // If we want to expose it
        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string firstName)
        {
            // validations
            if (firstName == "Waseem")
            {
                this.firstName = firstName;
            }
        }
    }

    class waseem {
        
    }
}
