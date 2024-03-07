
Employee[] employees = new Employee[4];

employees[0] = new Employee()
{
    FirstName = "Normal",
    LastName = "Employee"
};

employees[1] = new PartTimeEmployee()
{
    FirstName = "PartTime",
    LastName = "Employee"
};

employees[2] = new FullTimeEmployee()
{
    FirstName = "FullTime",
    LastName = "Employee"
};

employees[3] = new ContractorEmployee()
{
    FirstName = "Contractor",
    LastName = "Employee"
};


foreach (Employee employee in employees)
{
    employee.PrintFullName();
}



public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}


public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - PartTime");
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - FullTime");
    }
}

public class ContractorEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - Contractor");
    }
}