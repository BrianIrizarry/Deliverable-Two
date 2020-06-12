using System;
using System.Linq;

namespace Deliverable_2

{
    class Program
    {
        static void Main(string[] args)

        {
            // INTRODUCTION TO USER

            Console.Write("Welcome to Spy School. Let's begin with encryption. Please enter a secret password to be encrypted: ");



            //VARIABLES 

            string input = Console.ReadLine();

            string message = "";

            int checksum = 0;



            // CODE ASSIGNING NUMBER VALUES TO LETTERS OF THE ALPHABET

            for (int i = 0; i < input.Length; i++)

            {
                int unicodeValue = input[i];



                // CODE FOR ToUpper() IN ORDER TO SUM THE UPPER CASE UNICODE VALUES

                if (unicodeValue >= 'a' && unicodeValue <= 'z')
                {

                    unicodeValue = unicodeValue - 'a' + 'A';
                }


                //CODE ADDING unicodeValue (NOW UPPER CASE) TO checksum

                checksum += unicodeValue;



                // DECLARE encodedLetter VARIABLE 
                int encodedLetter = (unicodeValue - 'A' + 1);



                // build the message for output
                message += encodedLetter + "-";
            }

            Console.WriteLine("Your original password has been encrypted to " + message);
           
            Console.WriteLine("Message checksum is " + checksum);
            
            Console.WriteLine("Have a great day and keep your head down out there.");

        }















            
        
    }
}