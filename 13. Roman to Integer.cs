using System.Text.RegularExpressions;

public class Solution {
    IDictionary<string, int> map = new Dictionary<string, int>() {
        { "CM", 900 },
        { "CD", 400 },
        { "XC", 90 },
        { "XL", 40 },
        { "IX", 9 },
        { "IV", 4 },
        { "M", 1000 },
        { "D", 500 },
        { "C", 100 },
        { "L", 50 },
        { "X", 10 },
        { "V", 5 },
        { "I", 1 }
    };

    public int RomanToInt(string s) {
        var list = new List<int>();
        foreach (Match m in Regex.Matches(s, "CM|CD|XC|XL|IV|IX|M|D|C|L|X|V|I")) {
            _ = map.TryGetValue(m.Value, out int x);
            list.Add(x);
        }
        return list.Sum();
    }
}