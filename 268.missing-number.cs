/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public class Solution {
    public int MissingNumber(int[] nums) {
        int totalSum = 0;
        int successTotalSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            totalSum += nums[i];
            successTotalSum += i + 1;
        }
        return successTotalSum - totalSum;
    }
}
// @lc code=end

