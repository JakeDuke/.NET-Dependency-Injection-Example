using System.Collections.Generic;

public interface IEmployeeDAL
{
    List<Employee> SelectAllEmployees();
}
public class EmployeeDAL : IEmployeeDAL
{
    public List<Employee> SelectAllEmployees()
    {
        List<Employee> ListEmployees = new List<Employee>();
        //Get the Employees from the Database
        //for now we are hard coded the employees
        ListEmployees.Add(new Employee() { Name = "Bill", Department = "IT" });
        ListEmployees.Add(new Employee() { Name = "Kumar", Department = "HR" });
        ListEmployees.Add(new Employee() { Name = "Harold", Department = "HR" });
        ListEmployees.Add(new Employee() { Name = "Rout", Department = "Payroll" });
        ListEmployees.Add(new Employee() { Name = "Donald", Department = "FBI" });
        return ListEmployees;
    }
}
