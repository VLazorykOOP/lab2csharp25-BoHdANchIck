using System;

static void Task1()
{
    Random random = new Random();
    try
    {
        Console.WriteLine("Task_1");

        Console.WriteLine("Enter size of array[]: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(-100, 100);
            Console.WriteLine(arr[i] + " ");
        }

        int amount = 0;
        foreach (int item in arr)
        {
            if (item % 2 != 0)
            {
                amount++;
            }
        }
        Console.WriteLine($"Kilkist neparnih: {amount}");

        Console.WriteLine("Enter size of matrix:");
        n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("Matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(-100, 100);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();

        }

        amount = 0;
        foreach (int item in matrix)
        {
            if (item % 2 != 0)
            {
                amount++;
            }
        }
        Console.WriteLine($"Kilkist neparnih: {amount}");
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message.ToString());
    }

    Console.ReadKey();
    ChooseTask(); 
}


static void Task2()
{
    Random random = new Random();
    try
    {
        Console.WriteLine("Task_2");
        // todo
        Console.WriteLine("Enter size of array[]: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(-100, 100);
            Console.WriteLine(arr[i] + " ");
        }
        int index = 0;
        int temp = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (temp <= arr[i])
            {
                temp = arr[i];
                index = i;
            }
        }
        Console.WriteLine($"Last index of the biggest value: {index}");
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message.ToString());
    }
    Console.ReadKey();
    ChooseTask();
}

static void Task3()
{
    Random random = new Random();
    try
    {
        Console.WriteLine("Task_3");
        
        Console.WriteLine("Enter size of matrix (NxM):");
        Console.Write("Enter rows (N): ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns (M): ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Matrix before swapping:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-100, 100);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }


        if (cols % 2 == 0)
        {
            int mid1 = cols / 2 - 1;
            int mid2 = cols / 2;
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, mid1];
                matrix[i, mid1] = matrix[i, mid2];
                matrix[i, mid2] = temp;
            }
            Console.WriteLine("Swapped two middle columns.");
        }
        else
        {
            int mid = cols / 2;
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, 0];
                matrix[i, 0] = matrix[i, mid];
                matrix[i, mid] = temp;
            }
            Console.WriteLine("Swapped first and middle column.");
        }

        Console.WriteLine("Matrix after swapping:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message.ToString());
    }
    Console.ReadKey();
    ChooseTask();
}

static void Task4()
{
    try
    {
        Console.WriteLine("Task_4");
        // todo
        Console.Write("Enter the number of rows (n): ");
        int n = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the number of elements in row {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = random.Next(-100, 100); 
            }
        }

        Console.WriteLine("\nJagged array:");
        foreach (var row in jaggedArray)
        {
            Console.WriteLine(string.Join(" ", row));
        }

        int[] lastEvenArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            lastEvenArray[i] = FindLastEven(jaggedArray[i]);
        }

        Console.WriteLine("\nArray of last even elements:");
        Console.WriteLine(string.Join(" ", lastEvenArray));

    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message.ToString());
    }
    Console.ReadKey();
    ChooseTask();
}

static int FindLastEven(int[] row)
{
    for (int i = row.Length - 1; i >= 0; i--) 
    {
        if (row[i] % 2 == 0)
        {
            return row[i];
        }
    }
    return -1; 
}

static void ChooseTask()
{
    Console.WriteLine("0 - Task_1");
    Console.WriteLine("1 - Task_2");
    Console.WriteLine("2 - Task_3");
    Console.WriteLine("3 - Task_4\n");

    string _task = Console.ReadLine();
    int task;

    if (int.TryParse(_task, out task) && task >= 0 && task <= 5)
    {
        task = int.Parse(_task);
        switch (task)
        {
            case 0:
                Task1();
                break;
            case 1:
                Task2();
                break;
            case 2:
                Task3();
                break;
            case 3:
                Task4();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }

}

ChooseTask();