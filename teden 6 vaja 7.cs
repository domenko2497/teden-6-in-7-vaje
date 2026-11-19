using System;



namespace Zaposleni

{
    class Employee

    {

        public string Name { get; set; }

        public string FirstName { get; set; }

        public double Salary { get; set; }



        public Employee(string name, string firstName, double salary)

        {

            Name = name;

            FirstName = firstName;

            Salary = salary;

        }



        public virtual void Work()

        {

            Console.WriteLine(FirstName + " " + Name + " dela.");

        }



        public void Pause()

        {

            Console.WriteLine(FirstName + " " + Name + " je na odmoru.");

        }

    }






    // Izpeljani razred za šefa

    class Manager : Employee

    {

        public string CompanyCar { get; set; }



        public Manager(string name, string firstName, double salary, string companyCar)

            : base(name, firstName, salary)

        {

            CompanyCar = companyCar;

        }



        public void Lead()

        {

            Console.WriteLine(FirstName + " " + Name +

                              " vodi podjetje in uporablja avto " + CompanyCar + ".");

        }

    }



    // Izpeljani razred za pripravnika

    class Intern : Employee

    {

        public int WorkingHours { get; set; }

        public int SchoolHours { get; set; }



        public Intern(string name, string firstName, double salary,

                      int workingHours, int schoolHours)

            : base(name, firstName, salary)

        {

            WorkingHours = workingHours;

            SchoolHours = schoolHours;

        }



        public void Learn()

        {

            Console.WriteLine(FirstName + " " + Name + " se uči.");

        }



        public override void Work()

        {

            Console.WriteLine(FirstName + " " + Name +

                              " dela " + WorkingHours + " ur.");

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            Employee zaposleni = new Employee("Novak", "Miha", 1800);

            Manager sef = new Manager("Kovač", "Marko", 2500, "Volkswagen");

            Intern pripravnik = new Intern("Horvat", "Luka", 900, 6, 4);



            zaposleni.Work();

            zaposleni.Pause();



            sef.Lead();



            pripravnik.Work();

            pripravnik.Learn();



            Console.ReadLine();

        }

    }

}