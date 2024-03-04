

Employee employeeOne = new Employee();
employeeOne.FirstName = "John";
employeeOne.LastName = "Doe";
employeeOne.Salary = 20000;
employeeOne.YearsInService = 5;
employeeOne.PrintFullName();


Employee employeeTwo = new Employee()
{
    FirstName = "Sameer",
    LastName = "Saini",
    Salary = 30000,
    YearsInService = 0
};
employeeTwo.PrintFullName();


public class Employee()
{
    public string FirstName;
    public string LastName;
    public int Salary;
    public int YearsInService;


    public void PrintFullName()
    {
        Console.WriteLine($"The full name is {FirstName} {LastName}");
    }
}