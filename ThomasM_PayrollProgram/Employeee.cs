using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasM_PayrollProgram
{
    // Start of interface for tax calcuations for social tax and federal tax
    public interface ITaxCalculator
    {
        double GetSocialTax(double grosspay);
        double GetFederalTax(double grosspay);
    }// End of interface

    // Second interface
    public interface IOvertimeCalculator
    {
        double GetOvertimeRate(double rate);
        double GetOvertimePay(double overtimerate, double overtimehours);
        double GetOvertimeHours(double hours);
    }

    //Start of Abstract class for Employee inheriting interface ItaxCalculator
    public abstract class Employeee : ITaxCalculator, IOvertimeCalculator
    {
        // Create empty Constructor
        public Employeee() { }

        // Create overloaded constructor for Employee which is the base components.
        public Employeee(string sFirstName, string sLastName, string sSocialSecurity, double dRate, double dWorkHours)
        {
            FirstName = sFirstName;
            LastName = sLastName;
            SocialSecurity = sSocialSecurity;
            Rate = dRate;
            WorkHours = dWorkHours;
            OvertimeRate = GetOvertimeRate(Rate);
            OvertimeHours = GetOvertimeHours(WorkHours);
            TotalRegularPay = GetRegularPay();
            TotalOvertimePay = GetOvertimePay(OvertimeRate, OvertimeHours);
            GrossPay = TotalOvertimePay + TotalRegularPay;
            SocialTax = GetSocialTax(GrossPay);
            FederalTax = GetFederalTax(GrossPay);
            Deductions = getDeductions();
            NetPay = GrossPay - Deductions;
        }

        //Getter and setter functions for the needed variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurity { get; set; }
        public double Rate { get; set; }
        public double WorkHours { get; set; }
        public double OvertimeRate { get; set; }
        public double OvertimeHours { get; set; }
        public double TotalRegularPay { get; set; }
        public double TotalOvertimePay { get; set; }
        public double SocialTax { get; set; }
        public double FederalTax { get; set; }
        public double GrossPay { get; set; }
        public double Deductions { get; set; }
        public double NetPay { get; set; }

        // Assume that minimum work hours per two weeks is 80.
        private const int minWorkHours = 80;

        // Function that calculate the overtime hours from excess hours.
        public double GetOvertimeHours(double hours)
        {
            WorkHours = hours;
            if (WorkHours > minWorkHours)
            {
                return WorkHours - minWorkHours;
            }
            else
            {
                return 0;
            }
        }

        // Overtime function assume that it is 1.5 times the normal rate per hour.
        public double GetOvertimeRate(double rate)
        {
            Rate = rate;
            return Math.Round(Rate * 1.5, 2);
        }

        // Regular pay is calculated from regular minimum work hours times regular rate.
        double GetRegularPay()
        {
            if (WorkHours <= minWorkHours)   // Checks if workhours inputted is below min work hours if greater than 80, 80 is multiplied to rate as regular pay.
            {                               // the excess will be computed and added in the Overtimepay function
                return WorkHours * Rate;
            }
            else
            {
                return minWorkHours * Rate;
            }
        }

        // Calculates and return the overtimepay function
        public double GetOvertimePay(double overtimeHours, double overtimeRate)
        {

            return Math.Round(OvertimeHours * OvertimeRate, 2);
        }

        // Calculates the social tax assuming the percentage is 6.2%.
        public double GetSocialTax(double dGrossPay)
        {
            dGrossPay = GrossPay;
            return Math.Round(dGrossPay * 0.062, 2);
        }

        // Assume a fixed 15% tax but will provide more if else statement for the appropriate rate for different salary amounts.
        public double GetFederalTax(double dGrossPay)
        {
            dGrossPay = GrossPay;
            return Math.Round(dGrossPay * 0.15, 2);
        }

        //abstract method
        public abstract double getDeductions();
        public abstract bool isWorkHoursValid(double dWorkHours);
    } //End of abstract class


    // Start of Contract class using base class EMployee
    public class Contract : Employeee
    {
        // Constructors
        public Contract() { }
        public Contract(string sFirstName, string sLastName, string sSocialSecurity, double dRate, double dWorkHours) : base(sFirstName, sLastName, sSocialSecurity, dRate, dWorkHours)
        { }

        //Calculates the deduction which only includes social tax and federal tax for contract employees.
        public override double getDeductions()
        {
            return Math.Round(SocialTax + FederalTax);
        }

        // Maximum working hours for contract employees
        private const double maxWorkHours = 90;

        //abstract method for workhours validation
        public override bool isWorkHoursValid(double dWorkHours)
        {
            if (dWorkHours <= maxWorkHours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }// End of Contract Class

    // Start of Regular class using base class Employee
    public class Regular : Employeee
    {
        // Constructors
        public Regular() { }

        // Additional Insurance benefit for Regular Employees
        public Regular(string sFirstName, string sLastName, string sSocialSecurity, double dRate, double dWorkHours, string dInsurance) : base(sFirstName, sLastName, sSocialSecurity, dRate, dWorkHours)
        {
            Insurance = dInsurance;
            InsuranceCost = getInsuranceCost(Insurance);
        }

        // Getter and setter for insurance and insurance cost
        public string Insurance { get; set; }
        public double InsuranceCost { get; set; }

        // Assume insurance cost have different cost for different types
        public double getInsuranceCost(string insurance)
        {
            if (insurance == "regular")
            {
                return 33.33;
            }
            else if (insurance == "premium")
            {
                return 55.55;
            }
            else
            {
                return 25.00;
            }
        }

        // Create enum for different insurance types
        private enum InsuranceTypes { regular, premium, others }
        // Checktype function with default type value

        // Assume default insurance type is others
        private const string DefaultInsuranceType = "others";

        // Validates if insurance type is based among the choices listed
        private string CheckInsuranceType(string sInsuranceType)
        {
            if (Enum.IsDefined(typeof(InsuranceTypes), sInsuranceType))
                return sInsuranceType;
            else
                return DefaultInsuranceType;
        }

        // Total deductions for regular employees include the insurance cost
        public override double getDeductions()
        {
            return Math.Round(SocialTax + FederalTax + InsuranceCost);
        }

        // Assume max working hours for regular employees is 110 hours per 2 weeks
        private const double maxWorkHours = 110;

        //abstract method
        public override bool isWorkHoursValid(double dWorkHours)
        {
            if (dWorkHours <= maxWorkHours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

