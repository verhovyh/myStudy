using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTest1 {
    class Employee
    {
        public int Id;
        public string Name;
        public Employee Manager;
        
        public string SayHello()
        {
            return string.Format("'Hello World!', said {0}", Name);
        }


    }
}
