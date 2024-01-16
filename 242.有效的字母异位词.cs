/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] record = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            record[s[i]-'a']++;
        }
        for (int i = 0; i < t.Length; i++)
        {
            record[t[i]-'a']--;
        }
        foreach (var item in record)
        {
            if(item!= 0) return false;
        }
        return true;
    }
}
// @lc code=end

