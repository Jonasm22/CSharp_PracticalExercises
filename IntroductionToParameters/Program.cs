/*
//A method that has the parameter myString of Type String
//Method declaration


//Parameter 
void WriteSomethingSpecific(string myString)
{

    Console.WriteLine("You passed this argument to me:  " + myString);
    Console.ReadKey();


}

string username = "frank"; 
//argument
//calling the method using an Argument calles "myUSERname"
WriteSomethingSpecific(username);
*/

using System.Collections.Concurrent;

int AdTwoValues(int value1, int value2)
{

    int result = value1 + value2;

    Console.WriteLine("result: " + result);
    return result;
}

Console.WriteLine("Add two numbers: " );

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());


AdTwoValues(num1, num2);


