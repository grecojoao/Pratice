namespace HackerRank.Nelogica
{
    public class Question04
    {
        public static string[] Braces(string[] values)
        {
            var resultStrings = new string[values.Length];
            for (int i = 0; i < resultStrings.Length; i++)
                resultStrings[i] = "YES";

            for (int i = 0; i < values.Length; i++)
                for (int j = 0; j < values[i].Length / 2; j++)
                    if (!VerifyPair(values[i][j].ToString(),
                        values[i][values[i].Length - 1 - j].ToString()))
                    {
                        resultStrings[i] = "NO";
                        break;
                    }

            return resultStrings;
        }

        private static bool VerifyPair(string a, string b)
        {
            if (a == "{" && b == "}")
                return true;
            else if (a == "[" && b == "]")
                return true;
            else if (a == "(" && b == ")")
                return true;

            return false;
        }
    }
}
