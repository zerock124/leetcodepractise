/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        string _outPut = "";

        //如果沒有資料 或是 第一筆的長度為0
        if (strs == null || strs[1].Length == 0)
            return _outPut;

        //逐筆比對
        string _strFirst = strs[0];
        string[] _strList = strs.Skip(1).ToArray();
        for (int i = 0; i < _strFirst.Length; i++)
        {
            if (_strList.All(x => x.Substring(0, x.Length > i + 1 ? i + 1 : x.Length) == _outPut + _strFirst[i]) == true)
                _outPut = _outPut + _strFirst[i];
            else
                break;
        }
        return _outPut;
    }
}
// @lc code=end

