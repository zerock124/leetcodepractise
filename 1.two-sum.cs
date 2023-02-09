/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] _outPut = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == target - nums[i])
                {
                    _outPut[0] = i;
                    _outPut[1] = j;
                    return _outPut;
                }
            }
        }
        return null;
    }
}
// @lc code=end

