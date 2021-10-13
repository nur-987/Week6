using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample
{
    /// <summary>
    /// in the unitTest2; using moq,
    /// this class does not carry out the fuctioon. 
    /// the test is done of the program.cs class
    /// </summary>
    public class Calculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multply(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            if(b== 0)
            {
                throw new ArgumentException("B cannot be 0");
            }
            return a / b;
        }


    }
}
