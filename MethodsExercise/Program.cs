namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Name: Robert
           // Favorite Color: Blue
           // Favorite Animal: Dog
           // Favorite Band: Any


            Console.WriteLine($"Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Okay {color}. Now what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Good,and what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
