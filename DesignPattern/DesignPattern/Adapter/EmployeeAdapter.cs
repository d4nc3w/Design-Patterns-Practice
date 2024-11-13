// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();
    
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employeesList = new List<Employee>();

            //     {"101","John","SE","10000"},
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                int id = int.Parse(employeesArray[i, 0]);
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                decimal salary = decimal.Parse(employeesArray[i, 3]);

                Employee employee = new Employee(id, name, designation, salary);
                employeesList.Add(employee);
            }
            
            thirdPartyBillingSystem.ProcessSalary(employeesList);
            
        }
    }
}
