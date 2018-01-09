using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.ExamplesForHumans
{
    public class CompositeClient
    {
        static void Demo()
        {
            // Prepare the employees
            var john = new Developer("John Doe", 12000);
            var jane = new Designer("Jane Doe", 15000);

            // Add them to organization
            var organization = new Organization();

            organization.AddEmployee(john);
            organization.AddEmployee(jane);

            Console.WriteLine("Net salaries: " + organization.GetNetSalaries()); // Net Salaries: 27000
            
            Console.ReadLine();
        }
    }
}
