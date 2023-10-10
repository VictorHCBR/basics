Console.WriteLine("Which program do you want to run?\n" +
    "1. Main Diagonal and Negatives\n" +
    "2. Occurence and Position\n");
int kind = int.Parse(Console.ReadLine());

if (kind == 1)
{
    Console.Write("Tell the rank of the matrix: ");
    int size = int.Parse(Console.ReadLine());

    int[,] matrix = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        string[] values = Console.ReadLine().Split(' ');
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = int.Parse(values[j]);
        }
    }

    int negatives = 0;

    Console.WriteLine("\nNumbers in main diagonal: ");
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == j)
                Console.Write($"{matrix[i, j]} ");

            if (matrix[i, j] < 0)
                negatives++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"\nNumber of negative numbers: {negatives}.");

}

else if (kind == 2)
{
    Console.Write("Inform the number of rows: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Inform the number of columns: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        string[] input = Console.ReadLine().Split(" ");
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = int.Parse(input[j]);
        }
    }

    Console.Write("Inform the number you want to verify: ");
    int number = int.Parse(Console.ReadLine());
    int occurrence = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] == number)
            {
                occurrence++;
                Console.WriteLine($"Position:\nRow: {i + 1}, Column: {j + 1}");
                Console.WriteLine($"Occurrence #{occurrence}:");
                if (i - 1 >= 0)
                    Console.WriteLine($"Up: {matrix[i - 1, j]}.");

                if (i + 1 <= rows - 1)
                    Console.WriteLine($"Right: {matrix[i, j + 1]}.");

                if (i + 1 <= columns - 1)
                    Console.WriteLine($"Down: {matrix[i + 1, j]}.");

                if (j - 1 >= 0)
                    Console.WriteLine($"Left: {matrix[i, j - 1]}.");
            }
        }
        Console.WriteLine("-------------------------");
    }
}

else
{
    Console.WriteLine("Invalid Input, stopping the application.");
}