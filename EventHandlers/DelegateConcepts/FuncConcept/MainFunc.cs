using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.DelegateConcepts.FuncConcept
{
    public class MainFunc
    {
        public static void Run()
        {
            Func<int, int, int> multiply = (a, b) => a * b;

            var result = multiply(5, 6);
            Console.WriteLine($"Multiplication Result: {result}");
        }
    }
}
