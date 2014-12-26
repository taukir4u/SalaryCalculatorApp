using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bAmount = Convert.ToDouble(basicSalaryTextBox.Text);
            Employee aEmployee = new Employee(employeeNameTextBox.Text, bAmount);
            double presentHouseRent = Convert.ToDouble(houseRentTextBox.Text);
            double presentMedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double HouseRent = aEmployee.HouseRent(bAmount, presentHouseRent);
            double MedicalAllowance = aEmployee.MedicalAllowance(bAmount, presentMedicalAllowance);

            MessageBox.Show(aEmployee.GetSalary(bAmount, HouseRent, MedicalAllowance));
        }
    }
}
