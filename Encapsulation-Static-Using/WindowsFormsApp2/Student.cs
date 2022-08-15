using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Student
    {
        public static int StudentNumber { get; set; }

        public static void getAddNote()
        {
            MessageBox.Show("static");
        }
    }
}
