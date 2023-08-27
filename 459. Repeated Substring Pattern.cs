using System.Text.RegularExpressions;

public class Solution {
    public bool RepeatedSubstringPattern(string s) => Regex.IsMatch(s, @"^(.{1,}).{0}\1+$");
}