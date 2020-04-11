using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    public interface IState
    {
        void DoAction(Context context);
    }
}
