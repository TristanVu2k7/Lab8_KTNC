namespace MyArrayLib
{
    public class ArrayUtils
    {
        public static int Max(int[] arr)
        {
            if (arr == null || arr.Length ==0) throw new System.ArgumentException("Array cannot be null or empty");
            int max = arr[0];
            foreach (var v in arr) if (v > max) max = v;
            return max;
        }
        public static int Min(int[] arr)
        {
            if (arr == null || arr.Length == 0) throw new ArgumentException("Array is empty or null");
            int min = arr[0];
            foreach (var v in arr) if (v < min) min = v;
            return min;
        }
    }
}
