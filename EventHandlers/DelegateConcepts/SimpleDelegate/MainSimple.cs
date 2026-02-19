using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.DelegateConcepts.SimpleDelegate
{
    public class MainSimple
    {
        public static void Run()
        {
            var calculator = new Calculator();

            Calculate calc = calculator.Add;
            var addResult = calc(10, 20);
            Console.WriteLine($"Addition Result: {addResult}");

            calc = calculator.Subtract;
            var subResult = calc(30, 15);
            Console.WriteLine($"Subtraction Result: {subResult}");
        }
    }
}
