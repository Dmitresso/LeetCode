public class Solution {
    public int StrStr(string s1, string s2) => s1.Contains(s2) ? s1.IndexOf(s2) : -1;
}