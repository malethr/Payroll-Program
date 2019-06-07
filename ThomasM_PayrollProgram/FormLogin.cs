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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //Login Button Function
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            
            //Check if login parameters matched
            if (login.doesLoginMatch(tb_login.Text, tb_password.Text)){
                FormMenu menu = new FormMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login:");
            }
            
        }

   
    }
}
