using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task11
{
    class Eploy:Person
    {
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} , Name :{Name} , Surname :{Surname} , Age :{Age} , Salary : {Salary}";
        }
    }
}
