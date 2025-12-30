namespace HackerRank;

class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    #region 1st Solution
    
    // public static string Kangaroo(int x1, int v1, int x2, int v2)
    // {
    //     string yes = "YES";
    //     string no = "NO";
    //     
    //     if (x2 > x1 && v2 > v1)
    //         return no;
    //
    //     int kangOnePosition = x1;
    //     int kangTwoPosition = x2;
    //     
    //     while (kangOnePosition <= 10000)
    //     {
    //         kangOnePosition += v1;
    //         kangTwoPosition += v2;
    //         
    //         if (kangOnePosition == kangTwoPosition)
    //             return yes;
    //         
    //     }
    //     
    //     return no;
    // }

    #endregion

    #region Optimized

    public static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 == v2)
            return x1 == x2 ? "YES" : "NO";

        int diffPosition = x2 - x1;
        int diffVelocity = v1 - v2;

        if (diffVelocity == 0 || diffPosition * diffVelocity < 0)
            return "NO";

        return diffPosition % diffVelocity == 0 ? "YES" : "NO";
    }

    #endregion

}

class Program
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        while (true)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Result.Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }
        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}