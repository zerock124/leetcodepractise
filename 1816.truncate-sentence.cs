/*
 * @lc app=leetcode id=1816 lang=csharp
 *
 * [1816] Truncate Sentence
 */

// @lc code=start
public class Solution {
    public string TruncateSentence(string s, int k) {
        if (k <= 0)
            return "";
        string[] wordList = s.Split(" ");
        int wordCount = wordList.Count();
        if (k > wordCount)
            return "";

        string output = string.Join(' ', wordList.Take(k).Select(x => x));
        return output;
    }
}
// @lc code=end

