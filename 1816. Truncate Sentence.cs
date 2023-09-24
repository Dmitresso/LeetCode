public class Solution {
    public string TruncateSentence(string s, int k) => string.Join(" ", s.Split(' '), 0, k);
}