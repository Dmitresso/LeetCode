public class Solution {
    public int CountPrefixes(string[] words, string s) => words.ToList().Count(w => s.StartsWith(w));
}