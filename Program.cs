namespace DemidenkoProject;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 7, 3, 1, 8, 6, 9, 4 };
        int temp;

        Console.WriteLine("Исходный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        // Сортировка методом пузырька
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nОтсортированный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.ReadLine();
    }
}
