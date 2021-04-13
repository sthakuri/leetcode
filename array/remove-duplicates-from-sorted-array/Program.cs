using System;

namespace remove_duplicates_from_sorted_array
{
    //URL: https://leetcode.com/problems/remove-duplicates-from-sorted-array/

    /*
    
        Given a sorted array nums, remove the duplicates in-place such that 
        each element appears only once and returns the new length.

        Do not allocate extra space for another array, you must do this by modifying 
        the input array in-place with O(1) extra memory.    
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var len = RemoveDuplicates(new int[] {});
            Console.WriteLine(len);
        }
        public static int RemoveDuplicates(int[] nums) 
        {
            int n = nums.Length>0? 1: 0;
            for(int i=1; i< nums.Length; i++)
            {
                if(nums[i] != nums[n-1])
                {
                    nums[n]= nums[i];
                    n++;
                }
            }
            return n;
        }
    }
}
