public class Solution {
    public string[] FindWords(string[] words) {
        List<string> list = new List<string>();
        HashSet<char> r1 = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' },
                      r2 = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' },
                      r3 = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
        
        foreach (string w in words) {
            if (w.ToLower().All(c => r1.Contains(c)) ||
                w.ToLower().All(c => r2.Contains(c)) ||
                w.ToLower().All(c => r3.Contains(c))) {
                list.Add(w);
            }
        }

        return list.ToArray();
    }
}