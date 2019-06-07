using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasM_PayrollProgram
{
    class QueryString
    {
        public enum QueryType
        {
            Insert = 1,
            Update = 2,
            Delete = 3,
            ReturnData = 4,
            Search = 5
        };

        private const string sSqlQuotDelimComma = "','";
        private const string sSqlEndStringQuot = "')";

        //Get Records
        private const string sGetEmployees = "Select EmployeeID, FirstName, LastName,Type, SocialSecurityNumber, NetPay From Employee";

        //Insert Statements
        // private const string sMemberInsert = "Insert into Member (FirstName, LastName, DateOfBirth,SocialSecurityNumber) Values (@FirstName,@LastName,@DateOfBirth,@SocialSecurityNumber) SET @ID = SCOPE_IDENTITY();  ('";
        private const string sEmployeeInsert = "Insert into Employee (FirstName, LastName, Type, SocialSecurityNumber, NetPay) Values ('";
        //Delete Statements
        private const string sDeleteEmployee = "Delete from Employee Where EmployeeID = '";
        private const string sSearchEmployee = "Select EmployeeID, FirstName, LastName, Type, SocialSecurityNumber, NetPay From Employee Where LastName = '";

        //Update Statements
        //The update statements are simplistic for the demo. They update everything in the row, except the keys. Update statements
        //can be created to only update information that changed, but that requires a great deal of code and is beyond the scope of this course.
        //The number at the end of the variable name is the order in which to concatenate them for the query. 
        private const string sUpdateEmployeeFirstName1 = "Update Employee Set FirstName = '";
        private const string sUpdateEmployeeLastName2 = "', LastName = '";
        private const string sUpdateEmployeeType3 = "', Type = '";
        private const string sUpdateEmployeeSSN4 = "', SocialSecurityNumber ='";
        private const string sUpdateEmployeeWhere5 = "' Where EmployeeID =";

        //The Query type is the only mandatory input parameter. The rest are not mandatury due to the different types of queries. This
        //could also be done with multiple methods. Note how the DateTime syntax is different for default.
        public string BuildEmployeeQuery(QueryType query, string FirstN = "", string LastN = "", string type = "", string SSN = "", string netPay = "",string EmployeeID = "")
        {


            switch (query)
            {
                case QueryType.Insert:
                    {
                        SSN = SSN.Replace("-", string.Empty);
                        string tmp = sEmployeeInsert + FirstN + sSqlQuotDelimComma + LastN + sSqlQuotDelimComma + type + sSqlQuotDelimComma + SSN + sSqlQuotDelimComma + netPay + sSqlEndStringQuot;
                        return tmp;
                    }

                case QueryType.Update:
                    {
                        SSN = SSN.Replace("-", string.Empty);
                        return sUpdateEmployeeFirstName1 + FirstN + sUpdateEmployeeLastName2 + LastN + sUpdateEmployeeType3 + type + sUpdateEmployeeSSN4 + SSN + sUpdateEmployeeWhere5 + EmployeeID;
                    }
                case QueryType.Delete:
                    {
                        return sDeleteEmployee + EmployeeID;
                    }
                case QueryType.ReturnData:
                    {

                        return sGetEmployees;
                    }
                case QueryType.Search:
                    {

                        return sSearchEmployee + LastN + "' OR FirstName = '"+ FirstN+ "' OR SocialSecurityNumber ='" + SSN +"'";
                    }
                default:
                    {
                        return "";
                    }

            }



        }//End BuildEmployeeQuery





    }
}
