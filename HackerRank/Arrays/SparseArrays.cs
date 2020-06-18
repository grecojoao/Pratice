namespace HackerRank.Arrays
{
    public class SparseArrays
    {
        public static int[] MatchingStrings(string[] strings, string[] queries)
        {
            var result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
                for (int j = 0; j < strings.Length; j++)
                    if (queries[i] == strings[j])
                        result[i]++;

            return result;
        }
    }
}
