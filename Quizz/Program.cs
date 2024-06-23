public class Quizz
{

    public static void Main(string[] args)
    {

        GameQuizz();

        
    }

    public static void GameQuizz()
    {

        string question1 = "What is the capital of Germany?:";
        string answer1 = "Berlin";
        string question2 = "How is 3+3:";
        string answer2 = "6";
        string question3 = "which OS is from microsoft";
        string answer3 = "Windows";


        int score = 0;

        Console.WriteLine(question1);
        string userAnswer1 = Console.ReadLine();

        if(userAnswer1.Trim().ToLower() == answer1.ToLower())
        {
            Console.WriteLine("Correct.");
            score = +1;

        } else
        {
            Console.WriteLine("Wrong the correct answer is: " + answer1);
        }



        Console.WriteLine(question2);
        string userAnswer2 = Console.ReadLine();

        if (userAnswer2.Trim().ToLower() == answer2)
        {
            Console.WriteLine("Correct.");
            score +=1;

        }
        else
        {
            Console.WriteLine("Wrong the correct answer is: " + answer2);
        }



        Console.WriteLine(question3);
        string userAnswer3 = Console.ReadLine();

        if (userAnswer3.Trim().ToLower() == answer3)
        {
            Console.WriteLine("Correct.");
            score +=1;

        }
        else
        {
            Console.WriteLine("Wrong the correct answer is: " + answer3);
        }

        Console.WriteLine($"Quiz completed! your final score is:  {score} /3");

        if(score == 3)
        {
            Console.WriteLine("Exllent! You got all the answer rigth! " );
        }else if( score > 0)
        {
            Console.WriteLine("Good Job, but keep learning");
        }
        else
        {
            Console.WriteLine("Try again,you fail");
        }









    }



}