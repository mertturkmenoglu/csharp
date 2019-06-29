namespace E016_QuickSort
{
    public class Sort
    {
        public static void QuickSort(int[] arr, int begin, int end)
        {
            if (begin < end)
            {
                int pIndex = Partition(arr, begin, end);
                QuickSort(arr, begin, pIndex - 1);
                QuickSort(arr, pIndex + 1, end);
            }
        }

        private static int Partition(int[] arr, int begin, int end)
        {
            int temp;
            int pivot = arr[end];
            var i = begin - 1;
            for (int j = begin; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            i++;
            temp = arr[i];
            arr[i] = arr[end];
            arr[end] = temp;

            return i;
        }
    }
}