using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger waringLogger = new WaringinLogger(AbstractLogger.WARNING);
            AbstractLogger infoLogger = new InfoLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(waringLogger);
            waringLogger.SetNextLogger(infoLogger);

            errorLogger.LogMessage(AbstractLogger.INFO, "This is info message");
            errorLogger.LogMessage(AbstractLogger.WARNING, "This is waring message");
            errorLogger.LogMessage(AbstractLogger.ERROR, "This is error message");

            Console.ReadKey();
        }
    }
}
