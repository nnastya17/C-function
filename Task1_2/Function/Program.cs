using System;

namespace Function
{
    class Program
    {
        public static Boolean IsSorted(int[] arr , Boolean SortOrder){
            Boolean sorted = true;
            if (SortOrder == true) {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        sorted = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        sorted = false;
                        break;
                    }
                }
            }
            return sorted;
        }

        static void Transform(int[] arr, Boolean SortOrder)
        {
            Boolean res = IsSorted(arr, SortOrder);
            if (res) {
                for (int i = 0; i < arr.Length; i++) {
                    arr[i] = arr[i] + i;
                }
            }
            Console.Write("Полученный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количетсво елементов массива: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите елементы массива: ");
            int[] array = new int[length];
            for (int i = 0; i < length; ++i)
                array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Проверить на сортировку по возрастанию - 1, по убыванию - 0.");
            int o = int.Parse(Console.ReadLine());
            Boolean order = true;
            if (o == 0){
                order = false;
            }
            Boolean result = IsSorted(array, order);
            if (result == false) {
                Console.WriteLine("Массив не отсортирован.");
            }
            else {
                Console.WriteLine("Массив отсортирован.");
            }

            Transform(array, order);
        }
    }
}