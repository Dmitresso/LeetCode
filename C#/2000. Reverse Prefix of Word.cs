public class Solution {
    public string ReversePrefix(string word, char ch) {
        if (word.IndexOf(ch) < 0) return word;
        char[] prefix = word.Substring(0, word.IndexOf(ch) + 1).ToCharArray();
        Array.Reverse(prefix);
        return string.Concat(new string(prefix), word.Substring(word.IndexOf(ch) + 1));
    }
}