using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.DelegateConcepts.ActionConcept
{
    public class MainAction
    {
        public static void Run()
        {
            Action<string> log = message =>
            {
                Console.WriteLine($"Log: {message}");
            };

            log("Action delegate executed");
        }

        public static void Execute()
        {
            
        }
        
    }
}
