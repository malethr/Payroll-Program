using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThomasM_PayrollProgram
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        //Enter button function
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdo_contract.Checked == true)
            {
                FormEmpInfo emp = new FormEmpInfo("Contract");
                emp.Show();
                
            }
            else if (rdo_regular.Checked == true)
            {
                FormEmpInfo emp = new FormEmpInfo("Regular");
                emp.Show();
              
            }
        }
    }
}
