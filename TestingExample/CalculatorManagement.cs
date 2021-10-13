using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample
{
    class CalculatorManagement
    {
        //when an object of calcManagement is created,
        //the ICalculator object is also passed along with it. 

        //control becomes with calcManagement

        //inject dependance 
        //instead of prog.cs calling calc,
        //it will create an object of calcManagemnet pass the object of calc along as parameter

        private ICalculator calc; 
        public int addResult, subResult, multiplyResult, divResult;
        public CalculatorManagement(ICalculator calculator)
        {
            calc = calculator;
        }

        public void CallCalculatorMethods(int a, int b)
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
