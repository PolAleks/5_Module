namespace _5._1._6_EnterAndSortArray
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите элемент массива номер {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void ShowArray(int[] array, bool isSort = false)
        {
            var temp = array;
            if (isSort)
            {
                temp = SortArray(array);
            }
            foreach (var item in temp) 
            {
                Console.WriteLine(item);    
            }
        }
        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole();

            /*int[] sortedarray = SortArray(array)*/;

            ShowArray(array, true);
        }
    }
}