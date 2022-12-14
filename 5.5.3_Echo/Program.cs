namespace _5._5._3_Echo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите что-то: ");
            var str = Console.ReadLine();

            Console.Write("Укажите глубину эха: ");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }

        // Рекурсивный метод Эхо
        static void Echo(string saiWord, int deep)
        {
            var modifer = saiWord;

            if (modifer.Length > 2) { 
                modifer = modifer.Remove(0, 2);
            }

            bool isConsoleColore = deep > 0 & deep < 16;
            if(isConsoleColore) { 
                Console.BackgroundColor = (ConsoleColor)deep; 
            }
            
            Console.WriteLine($"...{modifer}");

            if (deep > 1)
            {
                Echo(modifer, deep - 1);
            }
        }
    }
}