/////////////Form1/////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = FirstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fullName = FirstName + " " + lastName;
            FullNameTextBox.Text = fullName;
            //MessageBox.Show("Hi, " + " Hello World in C#");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_Load(object sender, EventArgs e)
        {

        }
    }
}


//////////////program.cs////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new show());
        }
    }
}

