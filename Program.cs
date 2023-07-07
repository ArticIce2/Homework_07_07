// №1


Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble();
        Console.Write($"{array[i, j]} ");
    }
}

// №2


// int[,] arry = {

// { 1, 4, 7, 2 },
// { 5, 9, 2, 3 },
// { 8, 4, 2, 4 }

// };

// Console.Write("Введите индекс строки: ");
// int rowIndex = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите позицию столбца (от 0 до 2): ");
// int column = Convert.ToInt32(Console.ReadLine());

// int rowCount = array.GetLength(0);
// int columnCount = array.GetLength(1);

// if (rowIndex >= 0 && rowIndex < rowCount && column >= 0 && column < columnCount)
// {
// int value = arry[rowIndex, column];
// Console.WriteLine($"Значение элемента: {value}");
// }
// else
// { Console.WriteLine("Указанные позиции выходят за границы массива.");
// }

// №3

// int[,] arry = {
// { 1, 4, 7, 2 },
// { 5, 9, 2, 3 },
// { 8, 4, 2, 4 }
// };

// int rowCount = array.GetLength(0);
// int columnCount = array.GetLength(1);
 
// double[] columnAverages = new double[columnCount];

// for (int column = 0; column < columnCount; column++)
// {
// int sum = 0;

// for (int row = 0; row < rowCount; row++)
// {
// sum += arry[row, column];
// }

// columnAverages[column] = (double)sum / rowCount;
// }

// for (int column = 0; column < columnCount; column++)
// {
// Console.WriteLine($"Столбец {column + 1}: {columnAverages[column]}");
// }






