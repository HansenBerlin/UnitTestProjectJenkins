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
            AskForNumberInput(true);
            AskForOperationInput();
            AskForNumberInput(false);
        }
        public static double AskForNumberInput(bool firstNumber)
        {
            double value = 0;
            while (double.TryParse(Console.ReadLine(), out value))
            {
                break;
            }
            if (firstNumber) return InputNumberOne;
            else return InputNumberTwo;
        }

        public static string AskForOperationInput()
        {
            string operation = "0";
            while (operation != "+" && operation != "-" && operation != "/" && operation != "*")
            {
                operation = Console.ReadLine();                
            }
            return InputOperator;
        }

        public void ShowOutput()
        {
            Console.WriteLine(Output);
        }
    }
}
