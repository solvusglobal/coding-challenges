public class Employee {
    public string Name;
    public string Type;
    public double HoursWorked;
    public double HourlyRate;
    public double Bonus;
}

public class PayrollCalculator {
    public double CalculateSalary(Employee employee) {
        double salary = 0;

        if (employee.Type == "FullTime") {
            salary = employee.HoursWorked * employee.HourlyRate + employee.Bonus;
        }
        else if (employee.Type == "PartTime") {
            salary = employee.HoursWorked * employee.HourlyRate;
        }
        else if (employee.Type == "Intern") {
            salary = employee.HoursWorked * (employee.HourlyRate / 2);
        }

        return salary;
    }
}

public class Program {
    public static void Main() {
        var employees = new List<Employee> {
            new Employee { Name = "John", Type = "FullTime", HoursWorked = 40, HourlyRate = 25, Bonus = 500 },
            new Employee { Name = "Jane", Type = "PartTime", HoursWorked = 20, HourlyRate = 20, Bonus = 0 },
            new Employee { Name = "Alice", Type = "Intern", HoursWorked = 30, HourlyRate = 15, Bonus = 0 }
        };

        var payrollCalculator = new PayrollCalculator();

        foreach (var employee in employees) {
            Console.WriteLine($"{employee.Name}'s salary: {payrollCalculator.CalculateSalary(employee)}");
        }
    }
}
