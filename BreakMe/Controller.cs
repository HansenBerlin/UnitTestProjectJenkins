using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakMe
{
    public class Controller : Model
    {
        public Controller()
        {
            Calculate();
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return  a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b != 0) return a - b;
            else return 0;
        }

        public static double Calculate()
        {
            switch (InputOperator)
            {
                case "+":
                    return Add(InputNumberOne, InputNumberTwo);
                case "-":
                    return Substract(InputNumberOne, InputNumberTwo);
                case "*":
                    return Multiply(InputNumberOne, InputNumberTwo);
                case "/":
                    return Divide(InputNumberOne, InputNumberTwo);
                default:
                    return 0;
            }
        }

    }


}
