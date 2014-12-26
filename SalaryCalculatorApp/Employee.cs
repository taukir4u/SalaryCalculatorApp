using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string employeName;
        public double basicSalary;
        public double houseRent;
        public double medicalAllowance;

        public Employee(string employeeName, double basicAmount)
        {
            this.employeName = employeeName;
            this.basicSalary = basicAmount;
        }

        public double HouseRent(double bAmount, double presentBasic)
        {
            return ((basicSalary*presentBasic)/100);
        }

        public double MedicalAllowance(double bAmount, double presentBasic)
        {
            return ((basicSalary*presentBasic)/100);
        }

        public string GetSalary(double Salary, double HouseRent, double Allowance)
        {
            double salary = Salary + HouseRent + Allowance;
            return (employeName + "Your Salary: "+salary);
        }
    }
}
