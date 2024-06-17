using System.Xml.Serialization;

public class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome to my algorithm! press enter to start");
        Console.ReadLine();
    }

    static int number1;
    static void question2()
    {
        Console.WriteLine("write a number to use");
        number1 = Convert.ToInt32(Console.ReadLine());
    }

    static int number2;

    static void question3()
    {
        Console.WriteLine("write another number to use");
        number2 = Convert.ToInt32(Console.ReadLine());
    }

    static int reach;

    static void Reach()
    {
        Console.WriteLine("write a number to reach");
        reach = Convert.ToInt32(Console.ReadLine());

    }

    static int number3;

    static void operationAdd()
    {
        number3 = number1 + number2;
        number1 = number2;
        number2 = number3;
    }

    static void EndAdd()
    {


        while (number3 < reach)
        {
            operationAdd();

            Console.WriteLine(number3);



            if (number3 >= reach)
            {
                Console.WriteLine("we've got it");
                break;
            }
            Console.ReadKey();

        }
    }

    static string? answer;

    static void Add()
    {
        try
        {

            question2();
            question3();
            Reach();
            EndAdd();


        }
        catch (FormatException)
        {
            Console.WriteLine("Please use the correct format! Press enter to continue");
            Console.ReadLine();
            Add();
        }
        catch (Exception)
        {
            Console.WriteLine("Something went wrong, please try again! Press enter to continue");
            Console.ReadLine();
            Add();
        }

    }

    static void Trying()
    {
        Add();
    }

    static void resetgame()
    {
        reach = 0;
        number1 = 0;
        number2 = 0;
        number3 = 0;
    }

    static void playagain()
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Want to play again? Y/N");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    resetgame();
                    Trying();
                }
                else if (answer == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please answer the question correctly! Press enter to continue");
                    Console.ReadLine();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Something went wrong, please try again! Press enter to continue");
            Console.ReadLine();
            playagain();
        }
    }

    private static void Main()
    {
        Welcome();
        Add();
        playagain();
    }
}