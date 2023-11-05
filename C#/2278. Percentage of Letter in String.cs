public class Solution {
    public int PercentageLetter(string s, char c) => (int) Math.Floor(Convert.ToDouble(s.Count(i => i == c)) / Convert.ToDouble(s.Length) * 100);
}