using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Company
    {
        private static Company companyInstance;

        private HR_Department hr_DepartmentInstance;

        private Company(string companyName)
        {
            CompanyName = companyName;
            hr_DepartmentInstance = new HR_Department(5);
        }

        private string _commpanyName;
        public string CompanyName
        {
            get
            {
                return _commpanyName;
            }
            set
            {
                _commpanyName = value;
            }
        }

        public static Company GetCompanyInstance()
        {
            if(companyInstance == null)
            {
                companyInstance = new Company("Amazon");
            }
            return companyInstance;
        }

        public void DissmisEmployee()
        {
            hr_DepartmentInstance.DismissEmployee();
        }

        public void HireEmployee()
        {
            hr_DepartmentInstance.HireEmployee();
        }

        public int GetEmployeesNumber()
        {
            int number = hr_DepartmentInstance.GetEmployeeNumber();
            return number;
        }
    }
}
