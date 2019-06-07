// MariaLita Thomas
// Week09: Assignment 8
// This program demonstrates the basic payroll program displaying paystub information.

/**********************************************************************************
 * Changes as of Week9:
 *  -   Additional save, view list, search, update, delete and exit button.
 *  -   Additional class for SQL Database:
 *          DatabaseConnection.cs
 *          QueryString.cs
 *          ExecuteSQL.cs
 *  -   Additional EmployeeDatabase.mdf was added
 *  -   Additional DataGridView for the display of data
 *  -   Major modification on FormEmpInfo.cs
 *  -   Search Button only for lastname
 *  -   Remove the third option from FormMenu (View All)
 *********************************************************************************/

/***************************************************************************************
* Bugs
*   No validation implemented on textbox inputs for data type validation and format
* Code
*   Needs to rename the buttons and labels for better readability of code
*   Search query can only search last name
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ThomasM_PayrollProgram
{   
    // Start of main program
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }        
    }
}
