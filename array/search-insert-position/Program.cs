using System;

namespace search_insert_position
{
    //URL: https://leetcode.com/problems/search-insert-position/
    /*
    Given a sorted array of distinct integers and a target value, return the index if the target is found. 
    If not, return the index where it would be if it were inserted in order.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var i = SearchInsert_Solution2(new int[]{1},2);
            Console.WriteLine(i);
        }

        public static int SearchInsert_Solution1(int[] nums, int target) 
        {
            int i=0;
            for(; i< nums.Length; i++)
            {
                if(nums[i] >= target)
                {
                    return i;
                }
            }
            return i;
        }

        // Divide into half and perform search on half
        public static int SearchInsert_Solution2(int[] nums, int target) 
        {
            int len = nums.Length/2 + (nums.Length%2==0? 0: 1);
            int i=0;
            if(nums.Length>1 && nums[len]<target)
            {
                i= len-1;
                len= nums.Length;
            }
            for(; i< len; i++)
            {
                if(nums[i] >= target)
                {
                    return i;
                }
            }
            return i;
        }
    }
}
