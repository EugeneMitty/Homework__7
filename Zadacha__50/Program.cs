Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число стодбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
if (row < m && column < n) Console.WriteLine("Элемент массива с такими позициями существует: " + array[row, column]);
else Console.WriteLine("Элемент массива с такими позициями не существует");