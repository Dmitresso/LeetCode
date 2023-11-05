public class Solution {
    public string RestoreString(string s, int[] indices) {
        int i = 0;
        int length = s.Length;
        char[] chars = new char[length];
        
        while (i < length) {
            chars[indices[i]] = s[i];
            i++;
        }
        return new string(chars);
    }
}