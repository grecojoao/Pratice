namespace HackerRank.Sorting
{
    public class FraudulentActivityNotifications
    {
        public static int ActivityNotifications(int[] expenditure, int d)
        {
            var result = 0;

            for (int i = 0; i < expenditure.Length - d; i++)
            {
                var expenditureDays = new int[d];
                for (int j = 0; j < d; j++)
                {
                    expenditureDays[j] = expenditure[j + i];
                }
                var median = Median(expenditureDays);

                if (expenditure[i + d] >= median * 2)
                    result++;
            }

            return result;
        }

        // Deve ser melhorado o desempenho para n >= 10^5
        private static int Median(int[] expenditure)
        {
            var expenditureOrding = Order(expenditure);
            //var expenditureOrding = QuickSort.Order(expenditure, 0, expenditure.Length-1);

            if (expenditure.Length % 2 != 0)
                return expenditure[(int)(((expenditure.Length / 2d) + 0.5d) - 1)];
            else
                return expenditure[(int)((expenditure.Length / 2d) - 1)] + expenditure[(int)(expenditure.Length / 2)] / 2;
        }

        private static int[] Order(int[] expenditure)
        {
            for (int i = 0; i < expenditure.Length; i++)
                for (int j = i; j < expenditure.Length - 1; j++)
                    if (expenditure[i] > expenditure[j])
                        Swap(ref expenditure, i, j);

            return expenditure;
        }

        private static void Swap(ref int[] expenditure, int i, int j)
        {
            var temp = expenditure[i];
            expenditure[i] = expenditure[j];
            expenditure[j] = temp;
        }
    }
}
