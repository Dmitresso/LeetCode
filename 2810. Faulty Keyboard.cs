public class Solution {
    public string FinalString(string str) {
        List<char> list = new List<char>();
        foreach (char c in str) {
            if (c == 'i') list.Reverse();
            else list.Add(c);
        }
        return string.Concat(list);
    }
}