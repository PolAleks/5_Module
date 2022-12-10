namespace _5._2._2_MethodShowColorWithParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}\nВаш возраст: {1}", anketa.name, anketa.age); 

            ShowColor(anketa.name, anketa.age);
        }
        static string ShowColor(string userName, int userAge)
        {
            Console.Write($"{userName} напишите любимый цвет на английском языке с маленькой буквы: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    color = "yellow";
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            Console.WriteLine($"Your color is {color}\n" +
                              $"{userName}, {userAge}");
            return color;
        }
    }
}