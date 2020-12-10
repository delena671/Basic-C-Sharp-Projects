using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG244
{
    interface IQuittable
    {
        string firstName { get; set; }
        string lastName { get; set; }
        void Quit();
    }
}
