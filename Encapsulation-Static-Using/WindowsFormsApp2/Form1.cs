using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName = txtEmpName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(txtEmpAge.Text);
            employeeDetails.EmployeePosition = txtEmpPosition.Text;
            employeeDetails.EmployeeSetName = label9.Text;

            Form2 frm = new Form2();
            frm.label1.Text = employeeDetails.EmployeeName;
            frm.label5.Text = employeeDetails.EmployeeAge.ToString();
            frm.label6.Text = employeeDetails.EmployeePosition;
            frm.label7.Text = employeeDetails.EmployeeSetName;
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = "Miyuranga";

            //static call direct veriable in the class
            Student.StudentNumber = 1;
            Student.getAddNote();
        }

        private void btnMassage_Click(object sender, EventArgs e)
        {
            empMassage empmsg = new empMassage();
            
        }
    }
}
