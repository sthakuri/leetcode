using System;

namespace remove_element
{
    //URL: https://leetcode.com/problems/remove-element/
    /*
    Given an array nums and a value val, remove all instances of that value in-place 
    and return the new length.

    Do not allocate extra space for another array, 
    you must do this by modifying the input array in-place with O(1) extra memory.

    The order of elements can be changed. It doesn't matter what you leave beyond the new length.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var len = RemoveElement(new int[]{0,1,2,2,3,0,4,2}, 2);
            Console.WriteLine(len);
        }

        public static int RemoveElement(int[] nums, int val) 
        {
            int n = 0;
            for(int i=0; i< nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[n] = nums[i];
                    n++;
                }
            }
            return n;
        }
    }
}
