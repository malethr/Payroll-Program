
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThomasM_PayrollProgram
{
    public partial class FormEmpInfo : Form
    {
        public FormEmpInfo(string choice)
        {
            InitializeComponent();
            lbl_required.Text = lbl_required.Text + " for " + choice + " Employees:";
            label39.Text = choice;
            if (choice == "Contract")
            {
                lbl_insurance.Hide();
                grpBox_insurance.Hide();
            }
        }

    
        //Calculate Pay Button
        private void button1_Click(object sender, EventArgs e)
        {
            string sChoice = label39.Text;
            string sFirstName = tb_fname.Text;
            string sLastName = tb_lname.Text;
            double dRate = double.Parse(tb_rate.Text);
            double dWorkHours = double.Parse(tb_workhours.Text);
            string sSocialSecurity = tb_social.Text;
            string sInsurance = "";
            if (rdo_basic.Checked)
            {
                sInsurance = rdo_basic.Text;
            }
            else
            {
                sInsurance = rdo_premium.Text;
            }
            lblx_empName.Text = sLastName + ", " + sFirstName;
            lblx_ss.Text = sSocialSecurity;
            lblx_grp_rate.Text = dRate.ToString();
            lblx_grp_workhours.Text = dWorkHours.ToString();
            switch (sChoice)
            {
                case "Contract":
                    Contract con = new Contract(sFirstName, sLastName, sSocialSecurity, dRate, dWorkHours);
                    lblx_totalreg.Text = "$ " + (con.TotalRegularPay).ToString();
                    lblx_overtimerate.Text = "$ " + con.OvertimeRate.ToString();
                    lblx_othours.Text = "  " + con.OvertimeHours.ToString();
                    lblx_totalOvertimeEarnings.Text = "$ " + con.TotalOvertimePay.ToString();
                    lbx_totalGrossPay.Text = "$ " + con.GrossPay.ToString();
                    lblx_fedTax.Text = "$ " + con.FederalTax.ToString();
                    lblx_SocialSecurity.Text = "$ " + con.SocialTax.ToString();
                    lblx_ins.Text = "$ 0.00";
                    lblx_ttlDeductions.Text = "$ " + con.Deductions.ToString();
                    lblx_netpay.Text = "$ " + con.NetPay.ToString();
                    break;
                case "Regular":
                    Regular reg = new Regular(sFirstName, sLastName, sSocialSecurity, dRate, dWorkHours, sInsurance);
                    lblx_totalreg.Text = "$ " + (reg.TotalRegularPay).ToString();
                    lblx_overtimerate.Text = "$ " + reg.OvertimeRate.ToString();
                    lblx_othours.Text = "  " + reg.OvertimeHours.ToString();
                    lblx_totalOvertimeEarnings.Text = "$ " + reg.TotalOvertimePay.ToString();
                    lbx_totalGrossPay.Text = "$ " + reg.GrossPay.ToString();
                    lblx_fedTax.Text = "$ " + reg.FederalTax.ToString();
                    lblx_SocialSecurity.Text = "$ " + reg.SocialTax.ToString();
                    lblx_ins.Text = "$ " + reg.InsuranceCost.ToString();
                    lblx_ttlDeductions.Text = "$ " + reg.Deductions.ToString();
                    lblx_netpay.Text = "$ " + reg.NetPay.ToString();
                    break;
            }

        }

        //Save Button
        private void button2_Click(object sender, EventArgs e)
        {
            string theQuery = "";

            SqlDatabaseConnection dbC = new SqlDatabaseConnection();
            QueryString str = new QueryString();
            ExecuteSQL sql = new ExecuteSQL();

            int iResult;

            theQuery = str.BuildEmployeeQuery(QueryString.QueryType.Insert, tb_fname.Text, tb_lname.Text, label39.Text, tb_social.Text, lblx_netpay.Text);
            iResult = sql.InsertRecord(dbC.dbConn(), theQuery, tb_fname.Text, tb_lname.Text, label39.Text, tb_social.Text, lblx_netpay.Text);

            if (iResult == 0)
            {
                MessageBox.Show("Insert Failed!");
            }

        }

        //Exit Button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Update Button
        private void button4_Click(object sender, EventArgs e)
        {
            string theQuery = "";
            SqlDatabaseConnection dbC = new SqlDatabaseConnection();
            QueryString str = new QueryString();
            ExecuteSQL sql = new ExecuteSQL();
            int iResult;
            if (textHiddenEmployeeID.Text != "")
            {
                theQuery = str.BuildEmployeeQuery(QueryString.QueryType.Update, tb_fname.Text, tb_lname.Text, label39.Text, tb_social.Text, lblx_netpay.Text, textHiddenEmployeeID.Text);
                iResult = sql.UpdateRecord(dbC.dbConn(), theQuery);

                if (iResult == 0)
                {
                    MessageBox.Show("Update Failed!");

                }//end if (iResult

                int rowIndex = 0;
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    if (Row.Cells[0].FormattedValue.ToString() == textHiddenEmployeeID.Text)
                    {
                        Row.Cells[1].Value = tb_fname.Text;
                        Row.Cells[2].Value = tb_lname.Text;
                        Row.Cells[3].Value = label39.Text;
                        Row.Cells[4].Value = tb_social.Text;
                        Row.Cells[5].Value = lblx_netpay.Text;
                    }
                    rowIndex++;
                }

            }//end If
            else
            {
                MessageBox.Show("There must be a user selected before update.");
            }
        }

        //ViewList Button
        private void button3_Click(object sender, EventArgs e)
        {
            string theQuery = "";
            SqlDatabaseConnection dbC = new SqlDatabaseConnection();
            QueryString str = new QueryString();
            ExecuteSQL sql = new ExecuteSQL();
            DataTable theTable = new DataTable();

            theQuery = str.BuildEmployeeQuery(QueryString.QueryType.ReturnData);

            theTable = sql.GetRecords(dbC.dbConn(), str.BuildEmployeeQuery(QueryString.QueryType.ReturnData));

            dataGridView1.DataSource = theTable;

            dbC = null;
        }

        //Change values of textbox based on the data on table when clicked
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textHiddenEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                tb_fname.Text = row.Cells["FirstName"].Value.ToString();
                tb_lname.Text = row.Cells["LastName"].Value.ToString();
                label39.Text = row.Cells["type"].Value.ToString();
                tb_social.Text = row.Cells["SocialSecurityNumber"].Value.ToString();
            }
        }

        //Delete function
        private void button5_Click(object sender, EventArgs e)
        {
            string theQuery = "";
            SqlDatabaseConnection dbC = new SqlDatabaseConnection();
            QueryString str = new QueryString();
            ExecuteSQL sql = new ExecuteSQL();
            int iResult;
            //MemberID: txtHiddenMemberID.Text allows us to specify an optional parameter
            theQuery = str.BuildEmployeeQuery(QueryString.QueryType.Delete, EmployeeID: textHiddenEmployeeID.Text);
            iResult = sql.DeleteRecord(dbC.dbConn(), theQuery);

            if (iResult == 0)
            {
                MessageBox.Show("Delete Failed!");

            }

            //Remove the deleted row from the data grid based on the EmployeeID
            List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value != null &&
                     row.Cells[0].Value.ToString() == textHiddenEmployeeID.Text) RowsToDelete.Add(row);
            foreach (DataGridViewRow row in RowsToDelete) dataGridView1.Rows.Remove(row);
            RowsToDelete.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Search Button
        private void button7_Click(object sender, EventArgs e)
        {
            string theQuery = "";
            SqlDatabaseConnection dbC = new SqlDatabaseConnection();
            QueryString str = new QueryString();
            ExecuteSQL sql = new ExecuteSQL();
            DataTable theTable = new DataTable();
            string searchTextBox = tb_search.Text;

            theQuery = str.BuildEmployeeQuery(QueryString.QueryType.Search, LastN: searchTextBox, FirstN: searchTextBox, SSN: searchTextBox);

            theTable = sql.SearchRecords(dbC.dbConn(), str.BuildEmployeeQuery(QueryString.QueryType.Search, LastN: searchTextBox, FirstN: searchTextBox, SSN: searchTextBox));

            dataGridView1.DataSource = theTable;

            dbC = null;

        }

        //Accepts only numeric values for rate
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
            
        }

        //Accepts only numeric values for workhours
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //Use of Linq techniques
        // Regular List Button 
        private void button8_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext regList = new DataClasses1DataContext();
            var regularLists = from x in regList.Employees
                               where x.Type == "Regular"
                               select x;
            dataGridView1.DataSource = regularLists;
        }

        // Contract List Button
        private void button9_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext conList = new DataClasses1DataContext();
            var contractLists = from x in conList.Employees
                                where x.Type == "Contract"
                                select x;
            dataGridView1.DataSource = contractLists;
        }
    }
}
