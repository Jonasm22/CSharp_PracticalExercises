using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBaseClassLecture.ConstuctorInheritance
{
    public class Person
    {

        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Adreess { get; private set; }

        //  Base class constructor
        public Person( string name, int age)
        {
            Name = name;    
            Age = age;
            Console.WriteLine("Person Constructor called.");
        }
    
    
    
       public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name} , Age: {Age}");

        }
    

        /// <summary> Makes our Object Older </summary>
        /// <param name="years"> The parameter that indicates the amount the objett should age</param>
        /// <returns> Returns the new age aging/becoming older</returns>
        public int BecomeOlder(int years)
        {

            return Age + years;
        }
    
    
    
    }

    public class Employee : Person
    {
        public string Jobtitle { get; private set; }
        public int EmployeeID { get; private set; }

        public Employee(string name , int age, string jobtitle, int employeeID)
            : base(name, age) 
        {
            Jobtitle = jobtitle;
            EmployeeID = employeeID;
           Console.WriteLine("Employee constructor called");
        }


        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();

            Console.WriteLine($"Job Title:  {Jobtitle}  Employee : {EmployeeID}");
        }


    }


    public class Manager : Employee
    {

        public int TeamSize { get; private set; }

        // Always check the constructor
        public Manager(string name, int age, string jobtitle, 
            int employeeID , int teamSize) 
            : base(name, age, jobtitle, employeeID)
        {

            TeamSize = teamSize;

        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size {TeamSize}. ");
            
        }


    }




}
