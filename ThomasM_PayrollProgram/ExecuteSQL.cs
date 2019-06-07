using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ThomasM_PayrollProgram
{
    class ExecuteSQL
    {
        public DataTable GetRecords(SqlConnection oConn, string sSQL)
        {
            SqlDataReader theData;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandText = sSQL;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = oConn;
                theData = cmd.ExecuteReader();
                DataTable theTable = new DataTable();
                theTable.Load(theData);

                return theTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetRecords() : " + ex.Message);

                return null;

            }//try-catch	


        }

        public int InsertRecord(SqlConnection oConn, string sSQL, string FirstName, string LastName, string type, string SSN, string netpay)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sSQL, oConn);
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();
                return 1;//Success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in InsertRecord() : " + ex.Message);

                return 0;
            }

        }
        public int DeleteRecord(SqlConnection oConn, string sSQL)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sSQL, oConn);
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();
                return 1;//Success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DeleteRecord() : " + ex.Message);

                return 0;
            }

        }

        public int UpdateRecord(SqlConnection oConn, string sSQL)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sSQL, oConn);
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();
                return 1;//Success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in UpdateRecord() : " + ex.Message);

                return 0;
            }

        }

        public DataTable SearchRecords(SqlConnection oConn, string sSQL)
        {
            SqlDataReader theData;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandText = sSQL;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = oConn;
                theData = cmd.ExecuteReader();
                DataTable theTable = new DataTable();
                theTable.Load(theData);

                return theTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in SearchRecords() : " + ex.Message);

                return null;

            }//try-catch	


        }
    }
}
