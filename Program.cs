int Main()
{
    int[,] arr = new int[4,4];

    arr = homework.Make(arr,4,4);

    homework.Show(arr,4,4);

    arr = homework.Ordered(arr,4,4);

    homework.Show(arr,4,4);

    homework.Small(arr,4,4);

    return 0;
}

Main();

class homework
{
    // Method for filling up a matrix.
    static public int[,] Make(int[,] arr, int m, int n)
    {
        Random rand = new Random();
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                arr[i,j] = rand.Next(-20,20);
        return arr;
    }
    // Method for showing a matrix.
    static public void Show(int[,] arr, int m, int n)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
                Console.Write($" {arr[i,j] }");
            Console.WriteLine();
        }
    }

    // Method for ordering a matrix.
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
    
    // Method for finding a row with smallest sum.
    static public void Small(int[,] arr, int m, int n)
    {
        int[] sum = new int[m];
        int foo;

        for(int i = 0; i < m; i++)
            sum[i] = 0;
        
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                sum[i] += arr[i,j];

        for(int i = 0; i < m; i++)
            Console.Write($"{sum[i]} ");
        
        int[] num = new int[m];
        num = sum;

        for(int i = 0; i < m; i++)
            for(int j = i; j < m; j++)
                if(num[i] > num[j])
                {
                    foo = num[j];
                    num[j] = num[i];
                    num[i] = foo;
                }

        for(int i = 0; i < m; i++)
            if(num[0] == sum[i])
                Console.WriteLine($"\nThe smallest sum.\nRow {i + 1} has the sum {sum[i]}.");     
    }

}