using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakMe
{
    class View : Model
    {
        public View()
        {
            Console.WriteLine("Input first number:");
            AskForNumberInput(true);
            Console.WriteLine("Input operand:");
            AskForOperationInput();
            Console.WriteLine("Input second number:");
            AskForNumberInput(false);
        }

        public static double AskForNumberInput(bool firstNumber)
        {
            string input;
            double value;
            do
            {
                input = Console.ReadLine();   
            } while (!double.TryParse(input, out value));  
           
            if (firstNumber) return InputNumberOne = value;
            else return InputNumberTwo = value;
        }

        public static string AskForOperationInput()
        {
            string operation = "";
            do
            {
                operation = Console.ReadLine();
            } while (operation != "+" && operation != "-" && operation != "/" && operation != "*");
            return InputOperator = operation;
        }

        public static void ShowOutput()
        {
            Console.WriteLine(InputNumberOne + InputOperator + InputNumberTwo + "=" + Output);
        }
    }
}
