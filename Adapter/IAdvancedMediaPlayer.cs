using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IAdvancedMediaPlayer
    {
        void PlayVls(string fileName);
        void PlayMP4(string fileName);
    }
}
