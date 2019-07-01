namespace E017_MergeSort
{
    public static class Sort
    {

        public static void MergeSort<T>(T[] arr, int begin = 0 , int end = 0)
        {
            if (begin >= end) return;
            var mid = (begin + end) / 2;
            MergeSort(arr, begin, mid);
            MergeSort(arr, mid + 1, end);
            Merge(arr, begin, mid, end);
        }

        private static void Merge<T>(T[] arr, int begin, int mid, int end)
        {
            var n = end - begin + 1;
            var tmp = new T[n];
            var i = begin;
            var j = mid + 1;
            var index = 0;

            while (i <= mid && j <= end)
            {
                var result = System.Collections.Generic.Comparer<T>.Default.Compare(arr[i], arr[j]);
                tmp[index++] =  result == -1 ? arr[i++] : arr[j++];
            }
            
            while (i <= mid)
            {
                tmp[index++] = arr[i++];
            }

            while (j <= end)
            {
                tmp[index++] = arr[j++];
            }

            for (i = begin; i <= end; i++)
            {
                arr[i] = tmp[i - begin];
            }
        }
    }
}