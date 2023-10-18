public class Solution {
    public int MaxNumberOfBalloons(string s) {
        Dictionary<char, int> d = new Dictionary<char, int>() { { 'b', 0 }, { 'a', 0 }, { 'l', 0 }, { 'o', 0 }, { 'n', 0 } };
        foreach (char c in s) if (d.TryGetValue(c, out _)) d[c]++;
        return Math.Min(Enumerable.Min(new int[] { d['a'], d['b'], d['n'] }), Enumerable.Min(new int[] { d['l'], d['o'] }) / 2);
    }
}