using System.Transactions;

namespace Task105A.L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to the deparment.");
                Console.WriteLine("Please choose.");
                Console.WriteLine("1.Add employee");
                Console.WriteLine("2.See all employees");
                Console.WriteLine("0.The and");
                string input = Console.ReadLine();
                Department deparment = new Department();

                switch (input)
                {

                    case "1":
                        Employee employee = CreateEmployee();
                        deparment.AddEmployee(employee);
                        Console.WriteLine("Enter an employee name:");
                        break;
                    case "2":
                        deparment.GetAllEmployees();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("The and");
                        break;
                    default:
                        Console.WriteLine("Choose properly!!!");
                        break;
                }

            } while (exit != true);
        }
        public static Employee CreateEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the employee's name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee's surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Please enter the employee's age");
            employee.Age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the employee's salary");
            employee.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the employee's department name");
            employee.DepartmentName = Console.ReadLine();

            return employee;

        }
    }
}


