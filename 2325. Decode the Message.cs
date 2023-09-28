public class Solution {
    public string DecodeMessage(string key, string message) {
        Dictionary<char, char> dict = new Dictionary<char, char>() { { ' ', ' ' } };
        
        for (int i = 0, j = 97; i < key.Length; i++) { // a-z codes 97-122
            if (!dict.TryGetValue(key[i], out char _)) {
                dict.Add(key[i], Convert.ToChar(j));
                j++;
            }
        }

        string res = "";
        foreach (char c in message) if (dict.TryGetValue(c, out char value)) res += value;

        return res;
    }
}