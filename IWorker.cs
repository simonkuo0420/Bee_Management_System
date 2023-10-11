using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_Management_System
{
    internal interface IWorker
    {
        string Job { get; }
        void WorkTheNextShift();
    }
}
