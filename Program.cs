//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input i = new Input();
            string choice = "";
            string text = "";


            while (choice != "1" && choice != "2")
            {
                Console.Write("Choose Option 1 or 2: ");
                choice = Console.ReadLine();
            }


            if (choice == "1")
            {
                text = i.manualTextInput();
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse a = new Analyse();

            //Receive a list of integers back
            List<int> values = a.analyseText(text);

            //Report the results of the analysis
            Console.WriteLine("Sentences: " + values[0]);
            Console.WriteLine("Consonants: " + values[1]);
            Console.WriteLine("Vowels: " + values[2]);
            Console.WriteLine("Upper Case: " + values[3]);
            Console.WriteLine("Lower Case: " + values[4]);

            //TO ADD: Get the frequency of individual letters?

           
        }
    }
}