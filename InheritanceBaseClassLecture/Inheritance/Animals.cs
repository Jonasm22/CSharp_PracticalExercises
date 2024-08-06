using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBaseClassLecture.Inheritance
{
     class Animals
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animals make a generic sound");
        }


    }



    // Base Class (Parent Class or Superclass): 


    // Derived Class(Child Class or Subsclass:
    // The class that inherits the members if the base.
    class Dog : Animals
    {

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking....");

        }

    }
    class Cat : Animals
    {
        public override void MakeSound()
        {

            Console.WriteLine("Cat is meowing");
        }


    }

    class Collie : Dog
    {

        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }


    }




}
