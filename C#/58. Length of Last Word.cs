using System.Text.RegularExpressions;

public class Solution {
    public int LengthOfLastWord(string s) => s.Trim(' ').Split(' ').Last().Length;
}