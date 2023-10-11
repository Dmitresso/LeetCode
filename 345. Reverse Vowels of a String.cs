public class Solution {
    public string ReverseVowels(string s) {
        List<int> indexes = new List<int>();
        List<char> chars = new List<char>();
        HashSet<char> set = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++) {
            if (set.Contains(s[i])) {
                chars.Add(s[i]);
                indexes.Add(i);
            }
        }

        for (int i = 0; i < indexes.Count; i++) sb[indexes[i]] = chars[chars.Count - 1 - i];
        return sb.ToString();
    }
}