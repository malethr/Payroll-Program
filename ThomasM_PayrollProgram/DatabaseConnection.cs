using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThomasM_PayrollProgram
{
    class SqlDatabaseConnection
    {
        //Copied from connection string
        const string sDataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\ThomasM_PayrollProgram\ThomasM_PayrollProgram\EmployeeDatabase.mdf;Integrated Security=True";
        public SqlConnection dbConn()
        {
            SqlConnection oConn = new SqlConnection();

            try
            {
                oConn.ConnectionString = sDataSource;
                oConn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                //connectection failed
                oConn = null;
            }//try-catch	   

            return oConn;
        }
    }
}
