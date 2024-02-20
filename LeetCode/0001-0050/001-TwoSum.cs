//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.3 MB
// Link: https://leetcode.com/submissions/detail/352344600/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    using System.Collections.Generic;

    public class _001_TwoSum
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> dic = [];

            for (int i = 0; i < nums.Length; i++) {
                if (dic.TryGetValue(nums[i], out int value)) {
                    return [value, i];
                } else {
                    dic[target - nums[i]] = i;
                }
            }

            return [];
        }
    }
}
