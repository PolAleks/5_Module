namespace _5._1._6_EnterAndSortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 6;
            int[] array = GetArrayFromConsole(ref size);

            int[] arrayDesc, arrayAsc;
            
            Console.WriteLine("Исходный массив:");
            ShowArray(array);

            SortArray(array, out arrayDesc, out arrayAsc);
                        
            Console.WriteLine("Сортировка по убыванию:");
            ShowArray(arrayDesc);
                  
            Console.WriteLine("Сортировка по возрастанию:");
            ShowArray(arrayAsc);

            //Console.WriteLine("Исходный массив:");
            //ShowArray(array);
        }
        // Заполнение массива
        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите элемент массива номер {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        // Сортировка массива
        static void SortArray(int[] arr, out int[] sortedDesc, out int[] sortedAsc)
        {   
            sortedDesc = new int[arr.Length];
            Array.Copy(arr, sortedDesc, arr.Length);
            SortArrayDesc(sortedDesc);

            sortedAsc = new int[arr.Length];
            Array.Copy(arr, sortedAsc, arr.Length);                
            SortArrayAsc(sortedAsc);
        }
        // Сортировка массива от большего к меньшему
        static void SortArrayDesc(int[] array)
        {
            int temp;
            for(int i = 0; i < array.Length ; i++) 
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        // Сортировка массива от меньшего к большему
        static void SortArrayAsc(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}