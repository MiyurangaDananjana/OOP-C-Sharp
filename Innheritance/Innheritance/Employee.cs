using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innheritance
{
    class Employee : Human
    {
        protected string Position { get; set; }

        public double Salary { get; set; }

        public void Setvalues()
        {
            Name = "Charli";
            ID = 1;
            Gender = 'M';
            Age = 30;

        }
    }
}
