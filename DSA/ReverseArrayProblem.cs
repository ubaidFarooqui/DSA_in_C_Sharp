using System;

namespace DSA
{
    public class ReverseArrayProblem
    {
        // no need for extra memory (in-place algorithm)
        // O(N/2) = O(N) linear run time complexity
        public int[] Solve(int[] nums)
        {
            if (nums is null)
            {
                throw new ArgumentNullException(nameof(nums));
            }

            int lowIndex = 0;
            int highIndex = nums.Length - 1;

            while (highIndex > lowIndex)
            {
                Swap(nums, lowIndex, highIndex);
                lowIndex++;
                highIndex--;
            }
            
            return nums;
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }
    }
}
