public class Solution {
    public string[] DivideString(string s, int k, char f) {
        List<string> list = new List<string>();
        int length = s.Length;
        for (int i = 0; i < length; i += k) {
            var ss = s.Substring(i, i + k < length ? k : length - i);
            while (ss.Length < k) ss += f;
            list.Add(ss);
        }
        return list.ToArray();
    }
}