using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class HR_Department
    {
        public HR_Department()
        {

        }
        public HR_Department(int employeesNumber)
        {
            EmployeesNumber = employeesNumber;
        }

        private static int _employeesNumber;
        public static int EmployeesNumber
        {
            get
            {
                return _employeesNumber;
            }
            set
            {
                _employeesNumber = value;
            }
        }

        public void HireEmployee()
        {
            EmployeesNumber++;
        }

        public void DismissEmployee()
        {
            if (EmployeesNumber == 0)
            {
                Console.WriteLine("There are not employees for dismissing left!");
            }
            else
            {
                EmployeesNumber--;
            }
        }

        public int GetEmployeeNumber()
        {
            return EmployeesNumber;
        }
    }            
}
