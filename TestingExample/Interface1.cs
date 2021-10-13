using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Div(int a, int b);
        int Multiply(int a, int b);

    }
}
