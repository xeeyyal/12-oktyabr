using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Linq;

namespace AccesModifiers.Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        //TASK-1
        //Manager manager = new Manager("Xeyal", true, 350);
        //Assistant assistant = new Assistant("Yusif", true, 450);

        //Console.WriteLine("Manager Salary: " + manager.Salary);
        //Console.WriteLine("Assistant Salary: " + assistant.Salary);

        //assistant.GetFeedback(manager);

        //Console.WriteLine("New Manager Salary: " + manager.Salary);

        //TASK-2
        //    Student student = new Student();
        //    student.Name = "";
        //    student.Age = 0;
        //    student.Grade = 130;

        //    Console.WriteLine($"Ad: {student.Name}");
        //    Console.WriteLine($"Yaş: {student.Age}");
        //    Console.WriteLine($"Qiymət: {student.Grade}");
        }


    }
    //TASK-1
    //class Manager:Employee
    //{
    //    public Manager(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary) { }

    //    private void GetPromotion()
    //    {
    //        Salary += 100;
    //        Console.WriteLine($"{Name} : New Salary: {Salary}");
    //    }
    //    public Employee PromoteEmployee(Employee employee)
    //    {
    //        GetPromotion();
    //        return employee;
    //    }
    //}

    //class Assistant:Employee
    //{
    //    public Assistant(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary) { }

    //    public void GetFeedback(Employee employee)
    //    {
    //        if (employee.IsSuccessful)
    //        {
    //            Console.WriteLine($"{Name} : Successful");
    //            Manager manager = employee as Manager;
    //            if (manager != null)
    //            {
    //                manager.PromoteEmployee(employee);
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{Name} : Not Successful");
    //        }
    //    }
    //}
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public bool IsSuccessful { get; set; }
    //    public int Salary { get; set; }

    //    public Employee(string name, bool isSuccessful, int salary)
    //    {
    //        Name = name;
    //        IsSuccessful = isSuccessful;
    //        Salary = salary;
    //    }
    //}

    //TASK-2
    //class Student
    //{
    //    private string _name;
    //    private int _age;
    //    private int _grade;

    //    public string Name
    //    {
    //        get { return _name; }
    //        set
    //        {
    //            while (true)
    //            {
    //                Console.Write("Ad: ");
    //                string input = Console.ReadLine();

    //                if (string.IsNullOrWhiteSpace(input) || !Regex.IsMatch(input, "^[A-Z][a-zA-Z]*$"))
    //                {
    //                    Console.WriteLine("Ad böyük hərflə başlamalıdır, kənarlarında boşluq olmamalıdır, içində rəqəm olmamalıdır.");
    //                }
    //                else
    //                {
    //                    _name = input;
    //                    break;
    //                }
    //            }
    //        }
    //    }
    //    public int Age
    //    {
    //        get { return _age; }
    //        set
    //        {
    //            while (true)
    //            {
    //                Console.Write("Yaş: ");
    //                if (!int.TryParse(Console.ReadLine(), out int input) || input <= 0 || input > 100)
    //                {
    //                    Console.WriteLine("Yaş 0 və ya mənfi ola bilməz və Ust limit olmalidir.");
    //                }
    //                else
    //                {
    //                    _age = input;
    //                    break;
    //                }
    //            }
    //        }
    //    }
    //    public int Grade
    //    {
    //        get { return _grade; }
    //        set
    //        {
    //            while (true)
    //            {
    //                Console.Write("Qiymət: ");
    //                if (!int.TryParse(Console.ReadLine(), out int input) || input < 0 || input > 100)
    //                {
    //                    Console.WriteLine("Qiymət 0 və ya 100-də daxil olmaq və bu araliqda olmalidir.");
    //                }
    //                else
    //                {
    //                    _grade = input;
    //                    break;
    //                }
    //            }
    //        }
    //    }
    //}
}