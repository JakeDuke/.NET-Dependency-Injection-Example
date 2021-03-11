using System.Collections.Generic;

public interface IEmployeeBL
{
    List<Employee> GetAllEmployees();
}

public class EmployeeBL : IEmployeeBL
{
    public IEmployeeDAL _employeeDAL;
    public EmployeeBL(IEmployeeDAL employeeDAL)
    {
        _employeeDAL = employeeDAL;
    }
    public List<Employee> GetAllEmployees()
    {
        return _employeeDAL.SelectAllEmployees();
    }
}
