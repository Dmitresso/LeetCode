public class Solution {
    public bool IsAcronym(IList<string> words, string s) => s == new string(words.Select(w => w[0]).ToArray());
}