///Employee.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Information
{
    class Employee
    {
        public string firstName;
        public string middleName;

        public string lastName;
        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}




////Form.cs /////////




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.firstName = firstNameTextBox.Text;
            anEmployee.middleName = middleNameTextBox.Text;
            anEmployee.lastName = lastNameTextBox.Text;
            ListViewItem item = new ListViewItem();
            item.Text = anEmployee.GetFullName();
            employeeListView.Items.Add(item);
        }
    }
}

