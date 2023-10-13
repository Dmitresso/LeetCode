public class Solution {
    public int PrefixCount(string[] words, string pref) => words.ToList().Count(w => w.StartsWith(pref));
}