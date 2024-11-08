namespace _2пк2_Аниськов
{
    internal class Program
    {
        static int secretNumber;
        static void Main(string[] args)
        {
            Random random = new Random();
            secretNumber = random.Next(0, 11); // загадываем число от 0 до 10
            Console.WriteLine("Game: Guess the number! You have 3 attempts.");

            
        }
        static bool TryToGuess(int x)
        {
            if (x == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the number.");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong. Try again.");
                return false;
            }
        }
    }
}
