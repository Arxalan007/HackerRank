namespace HackerRank;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int min = scores.FirstOrDefault(), max = scores.FirstOrDefault();
        
        int minCount = 0, maxCount = 0;
        
        var records = new List<int>();

        foreach (int score in scores)
        {
            if (score > max)
            {
                max = score;
                maxCount++;
            }

            if (score < min)
            {
                min = score;
                minCount++;
            }
        }
        
        records.Add(maxCount);
        records.Add(minCount);
        
        return records;
    }

}


class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            // TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            // int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Result.breakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}