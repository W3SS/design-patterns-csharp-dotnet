using System.Collections.Generic;

namespace CompositePattern.ExamplesForHumans
{
    public class Organization
    {
        protected List<IEmployee> employees;

        public void AddEmployee(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;

            foreach (var employee in this.employees)
            {
                netSalary += employee.GetSalary();
            }

            return netSalary;
        }
    }
}
