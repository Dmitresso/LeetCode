public class Solution {
    public string FrequencySort(string s) {
        string res = "";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var c in s) if (!dict.TryGetValue(c, out int value)) dict.Add(c, s.Count(i => i == c));
        foreach (var p in dict.OrderByDescending(c => c.Value)) res += new string(p.Key, p.Value);
        return res;
    }
}