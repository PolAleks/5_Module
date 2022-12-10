namespace _5._2._2_MethodShowColorWithParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = (Console.ReadLine());
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}\nВаш возраст: {1}", anketa.name, anketa.age); ;
        }
    }
}