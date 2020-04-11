using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    class Program
    {
        public static IExpression getMaleExpression()
        {
            IExpression rober = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");

            return new OrExpression(rober, john);
        }

        public static IExpression getMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Is John male: " + getMaleExpression().Interpret("John"));
            Console.WriteLine("Julie is a maried woman? : " + getMarriedWomanExpression().Interpret("Married Julie"));

            Console.ReadKey();
        }



    }
}
