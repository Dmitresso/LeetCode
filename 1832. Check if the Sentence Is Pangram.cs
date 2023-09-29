public class Solution {
    public bool CheckIfPangram(string s) {
        Dictionary<char, int> d = new Dictionary<char, int>();

        foreach (char c in s) { 
            if (!d.TryGetValue(c, out int code)) d.Add(c, Convert.ToInt32(c));
        }

        return d.Sum(e => e.Value) == 2847; // a-z codes sum
    }
}