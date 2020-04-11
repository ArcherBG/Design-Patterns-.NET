﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDemo
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int WARNING = 2;
        public static int ERROR = 3;
        protected int level;
 
        private AbstractLogger nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (this.level == level)
            {
                Write(message);
            }
            if(this.nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(string message);
    }
}
