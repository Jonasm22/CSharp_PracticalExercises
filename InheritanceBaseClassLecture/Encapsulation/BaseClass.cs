using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBaseClassLecture.Encapsulation
{
    class BaseClass
    {
        // Access modifers
        public int publicField;
        protected int protectedField;
        private int privateField;


        public void ShowFields()
        {

            Console.WriteLine($"Public: {publicField}, Protected: {protectedField} , private: {privateField} ");


        }

    }



    class DerivedClass : BaseClass
    {
        public void AccesField()
        {

            publicField = 1;
            protectedField = 2;
            //privateField = 3;

        }


    }
}
