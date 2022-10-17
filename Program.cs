int Main()
{
    int m,n;
    string key;
    Console.WriteLine("Enter matrix demensions m x n.\nEnter m");
    key = Console.ReadLine();
    m = System.Int32.Parse(key);
    Console.WriteLine("Enter n.");
    key = Console.ReadLine();
    n = System.Int32.Parse(key);
    int[,] arr = new int[4,4];
    int[,] mat = new int[4,4];

    arr = homework.Make(arr,4,4);
    mat = homework.Make(mat,4,4);
    homework.Show(arr,4,4);
    Console.WriteLine("*************************");
    arr = homework.Ordered(arr,4,4);
    homework.Show(arr,4,4);
    Console.WriteLine("_________________________");
    homework.Small(arr,4,4);
    Console.WriteLine("*************************");
    homework.Show(arr,4,4);
    Console.WriteLine("_________________________");
    homework.Show(mat,4,4);
    Console.WriteLine("_________________________");
    arr = homework.Mulp(arr,mat,4,4);
    homework.Show(arr,4,4);

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
                arr[i,j] = rand.Next(0,5);
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

    // Method for matrixes multiplication.
    static public int[,] Mulp(int[,] arr, int[,] mat, int m, int n)
    {
        int[,] product = new int[m,n];

        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                product[i,j] = arr[i,j] * mat[j,i];

        return product;
    }
}