using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object
            Input n = new Input();
            string userInput = n.get_String();
            string inputUpper = n.print_Upper();
            Console.WriteLine("In upper case: " + inputUpper);
            string inputLower = n.print_Lower();
            Console.WriteLine("In lower case: " + inputLower);
            Console.ReadLine();
        }
        public class Input
        {
            //variables
            public string userInput;
            public string inputUpper;
            public string inputLower;
            //class for accepting the string from user
            public string get_String()
            {
                Console.WriteLine("Please enter a string: ");
                userInput = Console.ReadLine();
                return userInput; //returns a string value 
            }
            //to print the string in upper case
            public string print_Upper()
            {
                inputUpper = userInput.ToUpper();
                return inputUpper; //returns a string value 
            }
            //to print the string in upper case
            public string print_Lower()
            {
                inputLower = userInput.ToLower();
                return inputLower; //returns a string value 
            }
        }

    }
    
}
