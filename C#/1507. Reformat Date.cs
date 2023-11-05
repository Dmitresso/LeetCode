public class Solution {
    public string ReformatDate(string date) {
        Dictionary<string, int> dict = new Dictionary<string, int> { { "Jan", 01 }, { "Feb", 2 }, { "Mar", 3 }, { "Apr", 4 }, { "May", 5 }, { "Jun", 6 }, { "Jul", 7 }, { "Aug", 8 }, { "Sep", 9 }, { "Oct", 10 }, { "Nov", 11 }, { "Dec", 12 } };
        string[] s = date.Split(' ');
        int d = int.Parse(s[0].Substring(0, s[0].Length == 3 ? 1 : 2));
        dict.TryGetValue(s[1], out int m);
        int y = int.Parse(s[2]);
        return new DateTime(y, m, d).ToString("yyyy-MM-dd");
    }
}