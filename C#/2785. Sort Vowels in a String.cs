public class Solution {
    public string SortVowels(string s) {
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
        chars.Sort();

        for (int i = 0; i < indexes.Count; i++) sb[indexes[i]] = chars[i];
        return sb.ToString();
    }
}