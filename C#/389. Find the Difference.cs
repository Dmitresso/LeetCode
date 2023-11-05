public class Solution {
    public char FindTheDifference(string s, string t) => Convert.ToChar(Math.Abs(s.ToList<char>().Sum(c => Convert.ToInt32(c)) - t.ToList<char>().Sum(c => Convert.ToInt32(c))));
}