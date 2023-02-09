/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        int _outInt = 0;
        string _optPut = string.Empty;
        string _intChar = x.ToString();
        bool _pass = false;
        for (int i = 0; i < _intChar.Length; i++)
        {
            string _chartStr = _intChar[_intChar.Length - 1 - i].ToString();
            if (_chartStr == "-")
                _optPut = _optPut.Insert(0, _chartStr);
            else if (_chartStr == "0" && _pass == false)
                continue;
            else
            {
                _pass = true;
                _optPut += _chartStr;
            }
        }
        int.TryParse(_optPut, out _outInt);
        return _outInt;
    }
}
// @lc code=end

