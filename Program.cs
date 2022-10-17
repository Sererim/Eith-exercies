int Main()
{
    int[,] arr = new int[4,4];

    arr = homework.Make(arr,4,4);

    homework.Show(arr,4,4);

    arr = homework.Ordered(arr,4,4);

    homework.Show(arr,4,4);

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

    static public int[,] Ordered(int[,] arr, int m, int n)
    {
        int foo = 0;

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                for(int k = j; k < n; k++)
                {
                    if(arr[i,j] < arr[i,k])
                    {
                        foo = arr[i,k];
                        arr[i,k] = arr[i,j];
                        arr[i,j] = foo;
                    }
                }
            }
        }

        return arr;
    }

}