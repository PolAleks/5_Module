using System.Reflection.Metadata;

namespace _5._6_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = EnterUser();
            Print(user);
        }
        static (string firstName, string lastName, int age, string[] petsName, string[] favColor) EnterUser()
        {
            (string firstName, string lastName, int age, string[] petsName, string[] favColor) User;

            QuestionStr("Введите имя: ", out User.firstName); // Имя
            
            QuestionStr("Введите фамилию: ",out User.lastName); // Фамилия
            
            QuestionInt("Ваш возраст: ", out User.age); // Возраст
            // Питомцы
            {
                string enterData;
                QuestionStr("У вас есть питомец? ДА/НЕТ: ", out enterData);

                bool isYes = (enterData == "ДА") || (enterData == "да") || (enterData == "Да") || (enterData == "lf");
                if (isYes)
                {
                    int qtyPets;
                    QuestionInt("Введите количество питомцев: ", out qtyPets);
                    User.petsName = FillPetsName(qtyPets);
                }
                else
                {
                    User.petsName = null;
                }
            }
            // Любимые цвета
            {
                int qtyColor;
                QuestionInt("Cколько у Вас любимых цветов? ", out qtyColor);
                User.favColor = FillFavColor(qtyColor);
            }

            return User;
        }
        static void Print((string firstName, string lastName, int age, string[] petsName, string[] favColor) User)
        {
            Console.WriteLine($"Ваше имя: {User.firstName}");
            Console.WriteLine($"Ваша фамилия: {User.lastName}");
            Console.WriteLine($"Вам {User.age} лет");
            if(User.petsName != null) {
                Console.WriteLine("Клички ваших питомцев:");
                foreach(var pet in User.petsName) {
                    Console.WriteLine(pet);
                }
            }
            Console.WriteLine("Ваши любимые цвета:");
            foreach(var color in User.favColor)
            {
                Console.WriteLine(color);
            }
        }
        static string[] FillPetsName(int num)
        {
            string[] namesPets = new string[num];

            for (int i = 0; i < namesPets.Length; i++)
            {
                QuestionStr($"Напишите кличку {i + 1} питомца: ", out namesPets[i]);
            }
            return namesPets;
        }
        static string[] FillFavColor(int num)
        {
            string[] favColor = new string[num];

            for (int i = 0; i < favColor.Length; i++)
            {
                QuestionStr($"Назовите {i + 1} любимый цвет: ", out favColor[i]);
            }
            return favColor;
        }

        static void QuestionStr(string question, out string answer)
        {
            string enterData;
            do
            {
                Console.Write(question);
                enterData = Console.ReadLine();
            } while (String.IsNullOrEmpty(enterData));

            answer = enterData;
        }
        static void QuestionInt(string question, out int answer)
        {
            string enterData;
            bool isInt;
            do
            {
                Console.Write(question);
                enterData = Console.ReadLine();
                isInt = int.TryParse(enterData, out answer);
            } while (!isInt);
            if (answer < 1) {
                QuestionInt("Введите значение отличное от нуля: ", out answer);
            }
        }
    }
}