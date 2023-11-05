public class Solution {
    public string SortSentence(string s) {
        string[] words = s.Split(' ');
        string[] sorted = new string[words.Length];
        foreach (var w in words) sorted[Convert.ToInt32(char.GetNumericValue(w[w.Length - 1]) - 1)] = w.Substring(0, w.Length - 1);
        return string.Join(" ", sorted);
    }
}