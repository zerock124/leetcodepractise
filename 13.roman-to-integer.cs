/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        int _val = 0;
        IDictionary<string, int> _symbolList = new Dictionary<string, int>();
        _symbolList.Add("I", 1);
        _symbolList.Add("V", 5);
        _symbolList.Add("X", 10);
        _symbolList.Add("L", 50);
        _symbolList.Add("C", 100);
        _symbolList.Add("D", 500);
        _symbolList.Add("M", 1000);
        _symbolList.Add("IV", 4);
        _symbolList.Add("IX", 9);
        _symbolList.Add("XL", 40);
        _symbolList.Add("XC", 90);
        _symbolList.Add("CD", 400);
        _symbolList.Add("CM", 900);
        for (int i = 0; i < s.Length; i++)
        {
            string _nowKey = s[i].ToString();
            string _newxtKey = string.Empty;
            if (i + 1 != s.Length)
                _newxtKey = s[i + 1].ToString();

            int _combInt = 0;
            _symbolList.TryGetValue(_nowKey + _newxtKey, out _combInt);
            if (_combInt > 0)
            {
                i++;
                _val += _combInt;
            }
            else
            {
                _val += _symbolList[_nowKey];
            }
        }
        return _val;
    }
}
// @lc code=end

