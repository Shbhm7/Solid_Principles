
using System;
class Program {
    static void Main()
    {
Employee employee = new Employee();
Console.WriteLine ("Enter the Id ");
employee.ID = int.Parse(Console.ReadLine());
Console.WriteLine ("Enter the FirstName" );
employee.FirstName = Console.ReadLine();
Console.WriteLine ("Enter the LastName" );
employee.LastName = Console.ReadLine();
SalaryCalculator calculate = new SalaryCalculator();
decimal result = (decimal)calculate.CalculateSalary(employee);
Console.WriteLine ("Salary of "+ employee.FirstName + "is" + result);
Console.ReadLine();

    }
}
