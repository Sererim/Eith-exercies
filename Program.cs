int Main()
{
    int[,] arr = new int[2,2];

    arr = homework.Make(arr,2,2);

    homework.Show(arr,2,2);

    return 0;
}

Main();

class homework
{
    // Method for filling up the matrix.
    static public int[,] Make(int[,] arr, int m, int n)
    {
        Random rand = new Random();
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                arr[i,j] = rand.Next(-20,20);
        return arr;
    }
    // Method for showing the matrix.
    static public void Show(int[,] arr, int m, int n)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
                Console.Write($" {arr[i,j] }");
            Console.WriteLine();
        }
    }
}