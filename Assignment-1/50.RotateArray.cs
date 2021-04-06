using System;
using System.Linq;

namespace HelloWorld{
    class RotateArray
    {
        public void rotateArray(){
            int[] nums = {1, 2, 8};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
                for (var i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Length - 1] = temp;
                Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
        }

    }
}