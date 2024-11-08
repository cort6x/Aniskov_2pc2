namespace _2пк2_Аниськов
{
    internal class Program
    {
        static int secretNumber;
        static void Main(string[] args)
        {
            Random random = new Random();
            secretNumber = random.Next(0, 11); // загадываем число от 0 до 10
            Console.WriteLine("Игра: Угадай число! У вас есть 3 попытки.");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите ваше предположение: ");
                int userGuess = int.Parse(Console.ReadLine());
                TryToGuess(userGuess);
                if (TryToGuess(userGuess))
                {
                    break;
                }
            }
        }
        static bool TryToGuess(int x)
        {
            if (x == secretNumber)
            {
                Console.WriteLine("Поздравляем! Вы угадали число.");
                return true;
            }
            else
            {
                Console.WriteLine("Неверно. Попробуйте ещё раз.");
                return false;
            }
        }
    }
}
