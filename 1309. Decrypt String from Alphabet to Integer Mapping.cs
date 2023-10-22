public class Solution {
    public string FreqAlphabets(string str) {
        StringBuilder s = new StringBuilder();
        var sb = str.ToCharArray();
        for (int i = sb.Length - 1; i >= 0; i--) {
            if (sb[i] == '#') {
                s.Insert(0, Convert.ToChar(int.Parse(new string(new char[] { sb[i - 2], sb[i - 1] })) + 96));
                i -= 2;
            }
            else s.Insert(0, Convert.ToChar(int.Parse(new string(new char[] { sb[i] })) + 96));
        }

        return s.ToString();
    }
}