namespace HackerRank;

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;

        for (int x = a.Max(); x <= b.Min(); x++)
        {
            bool valid = true;

            foreach (int item in a)
            {
                var check = x % item;
                if (check != 0)
                {
                    valid = false;
                    break;
                }
            }

            foreach (int item in b)
            {
                var check = item % x;
                if (check != 0)
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                count++;
        }

        return count;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        while (true)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);

            // textWriter.WriteLine(total);

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}
