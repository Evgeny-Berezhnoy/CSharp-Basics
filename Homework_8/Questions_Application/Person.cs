using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_Application
{
    public class Person  {

        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public override string ToString() {

            return $"{this.FirstName};{this.LastName};{this.SecondName};{this.Age}";
        
        }

    }
}
