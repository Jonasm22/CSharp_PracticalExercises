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






}
