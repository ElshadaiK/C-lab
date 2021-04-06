using System;
using System.Linq;

namespace HelloWorld{
    class ArrayFirstAndLast
    {
        public void arrayFirstAndLast(){
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));
        }

    }
}