namespace _5._1._4_MethodShowColor
{
    internal class Program
    {
        //Считывание с клавиатуры
        //static string GetDataFromConsole()
        //{
        //    return Console.ReadLine();
        //}

        static string GetDataFromConsole() => Console.ReadLine();
        static string ShowColor()
        {
            Console.Write("Напишите любимый цвет на английском языке с маленькой буквы: ");
            string color = Console.ReadLine();

            switch(color) 
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"Your color is {color}");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"Your color is {color}");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"Your color is {color}");
                    break;
                default:
                    color = "yellow";
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"Your color is {color}");
                    break;
            }
            return color;
        }
        static void Main(string[] args)
        {
            string[] favColor = new string[3];
            // Заполнение массива
            for (int i = 0; i < favColor.Length; i++) 
            {
                favColor[i] = ShowColor();
            }
            // Вывод на массива на экран
            foreach (var item in favColor) 
            { 
                Console.WriteLine($"Your color is {item}");
            }
        }
    }
}