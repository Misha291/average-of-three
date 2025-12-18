public static void Main()
{
	Console.WriteLine(MiddleOfThree(2, 5, 4));
	Console.WriteLine(MiddleOfThree(3, 1, 2));
	Console.WriteLine(MiddleOfThree(3, 5, 9));
	Console.WriteLine(MiddleOfThree("B", "Z", "A"));
	Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
}



public static object MiddleOfThree(object a, object b, object c)
{
    // Кладём три значения в массив
    object[] arr = { a, b, c };
    
    // Сортируем массив "пузырьком", как в примере
    for (int i = arr.Length - 1; i > 0; i--)
        for (int j = 1; j <= i; j++)
        {
            var left = (IComparable)arr[j - 1];
            if (left.CompareTo(arr[j]) > 0) // если левый > правого — меняем
            {
                object temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
            }
        }
    
    // Возвращаем средний элемент (индекс 1)
    return arr[1];
}
