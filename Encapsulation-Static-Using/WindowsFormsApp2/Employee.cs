using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }

        public string EmployeeSetName { get; set; }


    }
    class empMassage
    { //static using 
        static empMassage()
        {
            MessageBox.Show("show massage");
        }
    }

    
}
