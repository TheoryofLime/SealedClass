using System;

namespace sealedsomething
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
        public virtual void displayData()
        {
            Console.WriteLine("[ ! ] Employee Display Data [ ! ]");
            Console.WriteLine(Id);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }

    }

    sealed class Executive : Employee
    {
        public string Title;
        public int Salary;

        public Executive()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Title = string.Empty;
            Salary = 0;
        }

        public Executive(int id, string firstname, string lastname, string title, int salary)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            Salary = salary;
        }

        public override double Pay()
        {
            double salary;
            Console.WriteLine($"What is Executive {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }

        public override void displayData()
        {
            Console.WriteLine("[ ! ] Executive Display Data [ ! ]");
            Console.WriteLine(Id);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Title);
            Console.WriteLine(Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(0, "employeeFNAME", "employeeLNAME");
            Executive executive = new Executive(1, "execFNAME", "execLNAME", "execTITLE", 4000);
            employee.displayData();
            executive.displayData();
        }
    }
}
