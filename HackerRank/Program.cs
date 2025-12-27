namespace HackerRank;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            int grade = grades[i];
            if (grade >= 38)
            {
                int nextMultipleOf5 = (grade / 5 + 1) * 5;
                if (nextMultipleOf5 - grade < 3)
                {
                    grades[i] = nextMultipleOf5;
                }
            }
        }
        return grades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(@"~/config.txt"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));

        // textWriter.Flush();
        // textWriter.Close();
    }
}
