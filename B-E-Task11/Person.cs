using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task11
{
    class Person
    {
        private static int _id;
        public Person()
        {
            Id = ++_id;
        }
        //Id-nin set olunmazi duzgun olmadigindan sadece get etmeye icaze verirem ve yalniz  birdefe conustructorda set edirem;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} , Name :{Name} , Surname :{Surname} , Age :{Age} ";
        }
    }
}
