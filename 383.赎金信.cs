/*
 * @lc app=leetcode.cn id=383 lang=csharp
 *
 * [383] 赎金信
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;
        int[] array = new int[26];
        foreach (var c in magazine)
        {
            array[c-'a']++;
        }
        foreach (var c in ransomNote)
        {
            array[c-'a']--;
            if (array[c-'a']<0) return false;
        }
        return true;
    }
}
// @lc code=end

