using ConstructorStaticEmployee.entities;

namespace ConstructorStaticEmployee
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee luffy = new Employee("Luffy", 1200f);
            System.Console.WriteLine(luffy.ToString());
            Employee zoro = new Employee("Zoro", 1000f);
            System.Console.WriteLine(zoro.ToString());
            Employee nami = new Employee("Nami", 800f);
            System.Console.WriteLine(nami.ToString());
            System.Console.WriteLine(Employee.numberEmployees);
        }
        
        
    }
}