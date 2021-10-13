using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample
{
    public class Program
    {
        public static int addResult, subResult, multiplyResult, divResult;
        public static ICalculator calc;

        static void Main(string[] args)
        {
            Console.WriteLine("first interger?");
            string integer1 = Console.ReadLine();

            Console.WriteLine("second interger?");
            string integer2 = Console.ReadLine();

            int a = int.Parse(integer1);
            int b = int.Parse(integer2);

            //without Interface
            //Calculator calc = new Calculator();
            //calc.Add(a, b);

            //using interface alone
            //calc = new Calculator();
            //CallCalculatorMethods(a,b);

            //using dependancy injection 
            CalculatorManagement management = new CalculatorManagement(calc);
            management.CallCalculatorMethods(a, b);

        }


        //in a dependancy injection, this method wont be called.
        //this will be called in the CalcManagement
        //method is used in "interface mode"
        public static void CallCalculatorMethods(int a, int b)
        {
            addResult = calc.Add(a, b);
            Console.WriteLine("Add: " + addResult);
            subResult = calc.Sub(a, b);
            Console.WriteLine("Add: " + subResult);
            multiplyResult = calc.Multiply(a, b);
            Console.WriteLine("Add: " + multiplyResult);
            divResult = calc.Div(a, b);
            Console.WriteLine("Add: " + divResult);

        }
    }
}
