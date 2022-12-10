namespace _5_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            User.Dishes = new string[5];

            Console.Write("Введите имя пользователя: ");
            User.Name = Console.ReadLine();
            for (int i = 1; i <= User.Dishes.Length; i++)
            {
                Console.WriteLine($"Введите {i} любимое блюдо: ");
                User.Dishes[i] = Console.ReadLine();
            }

        }
    }
}