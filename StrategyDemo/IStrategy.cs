using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    public interface IStrategy
    {
        int Execute(int a, int b);
    }
}
