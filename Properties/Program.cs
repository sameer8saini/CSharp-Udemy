
Employee emp1 = new Employee();
emp1.Id = 1;
emp1.Name = "Sameer Saini";
emp1.ChangeSalaryToOneYearSalary();

Console.WriteLine($"Id is {emp1.Id}, Name is {emp1.Name}, Salary is {emp1.Salary}");

public class Employee
{
    private int _Id;
    private string _Name;
    private int _Salary = 10000;


    public int Id 
    {
        set 
        {
            if (value > 0)
            {
                _Id = value;
            }
            else
            {
                throw new Exception("Id cannot be less than 0");
            }
        }
        get 
        {
            return _Id;
        }
    }

    public string Name
    {
        get 
        {
            return _Name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name cannot be Null or Empty");
            }

            _Name = value;
        }
    }

    public int Salary
    {
        get
        {
            return _Salary;
        }
    }


    public void ChangeSalaryToOneYearSalary()
    {
        _Salary = _Salary + 1000;
    }
}

