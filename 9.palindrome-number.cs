/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        string _input = x.ToString();
        string _output = string.Empty;
        for (int i = 1; i <= _input.Length; i++)
        {
            _output += _input[_input.Length - i];
        }
        if (_input == _output)
            return true;
        else
            return false;
    }
}
// @lc code=end

