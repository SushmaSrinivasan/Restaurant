using System.Security.Cryptography.X509Certificates;

namespace Restaurant
{
    internal class Program
    {
        private static int i=0;
        public string empName;
        public int salary;

        static void Main(string[] args, string empName, int salary)
        {
            Employee[] e = new Employee[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the Employee name: ");
                empName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Employee Salary: ");
                salary = Convert.ToInt32(Console.ReadLine());
            }
            e[i]=new Employee();
            e[i].DisplayData();
        }
    }
}
class Employee
{
    public string empName;
    public int salary;

    public Employee(string empName, int salary)
    {
        this.empName = empName; 
        this.salary = salary;   
    }

    public Employee()
    {
    }

    public void DisplayData()
    {
        Console.WriteLine("The name of the Employee is: " + empName);
        Console.WriteLine("The salary of the Employee is: " + salary);
    }
}