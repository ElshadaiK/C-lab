using System;

namespace Question112
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {5, 6, 1, 5, 6, 9, 10, 17, 5, 6};
            int[] arr2 = {5, 6, 1, 5, 6, 9, 10, 17};
            int[] arr3 = {1, 5, 6, 9, 10, 17, 5, 6};
            int[] arr4 = {1, 5, 9, 10, 17, 5, 6};
            int[] arr5 = {1, 5, 9, 10, 17, 5};

            Console.WriteLine("Sum of the numbers of the said array except those numbers starting with 5 followed by atleast one 6: ");
            Console.WriteLine(helper(arr1));
            Console.WriteLine(helper(arr2));
            Console.WriteLine(helper(arr3));
            Console.WriteLine(helper(arr4));
            Console.WriteLine(helper(arr5));

            static int helper(int[] arr)
            {   
                int sum = 0;
                int count = 0;
                if (arr.Length == 0) return 0;
                for (int i = 0; i < arr.Length - 1; i++) {
                    if (arr[i] == 5 && arr[i + 1] == 6) {
                        count++;
                    }
                    sum += arr[i];
                }
                sum = sum + arr[arr.Length - 1];
                return sum - (count * 11);
            }
        }
    }
}
