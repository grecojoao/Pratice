namespace HackerRank.Ordenation
{
    public class QuickSort
    {
        public static int[] Order(int[] array, int fromIndex, int toIndex)
        {
            var pivotIndex = toIndex;
            var elementIndex = fromIndex;

            while (elementIndex < pivotIndex)
            {
                if (array[elementIndex] > array[pivotIndex])
                {
                    Swap(ref array, pivotIndex, pivotIndex - 1);

                    if (elementIndex + 1 < pivotIndex)
                        Swap(ref array, elementIndex, pivotIndex);

                    pivotIndex--;
                }
                else
                    elementIndex++;
            }

            var leftArrayFromIndex = 0;
            var leftArrayToIndex = pivotIndex - 1;

            var isLeftPivotArrayNotSorted = leftArrayToIndex > 1;

            if (isLeftPivotArrayNotSorted)
                Order(array, leftArrayFromIndex, leftArrayToIndex);

            var rightArrayFromIndex = pivotIndex + 1;
            var rightArrayToIndex = array.Length - 1;

            var isRightPivotArrayNotSorted = rightArrayFromIndex < toIndex;

            if (isRightPivotArrayNotSorted)
                Order(array, rightArrayFromIndex, rightArrayToIndex);
                
            return array;
        }

        private static void Swap(ref int[] array, int a, int b)
        {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}