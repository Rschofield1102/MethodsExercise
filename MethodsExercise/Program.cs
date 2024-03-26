namespace MethodsExercise
{
    public class Program
    { 
        public static int Sum(int num1,int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return num1 * num2;
        }

        public static int Minus( int num1, int num2, int num3,int num4)
        {
            var answer = num1 - num2 - num3 - num4;
            return answer;
        }
           



        static void Main(string[] args)
        {
            int answer1 = Sum(2, 4);
            Console.WriteLine(answer1);
            int answer2 = Multiply(10, 2);
            Console.WriteLine(answer2);
            int answer3 = Minus(100, 25, 10, 5);
            Console.WriteLine(answer3);



            // Name: Robert
            // Favorite Hobby: Gym
            // Like to do:Travel
            // Favorite country: Tenerfie


            Console.WriteLine($"Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite hobby?");
            var hobby= Console.ReadLine();

            Console.WriteLine($"Okay {hobby}. Now what else do you like to do?");
            var travel= Console.ReadLine();

            Console.WriteLine($"What is your favorite place that you have been to?");
            var country = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}. His favorite hobby is the {hobby} ;" +
                $"He loves to {travel} and the best place he has been to is {country}");
        }
    }
}
