public class Employee
{
    public Employee()
    {
        newId++;
        ID = newId;
    }

    private static int newId;

    public int ID { get; private set; }
    public string Name { get; set; }
    public string Department { get; set; }
}