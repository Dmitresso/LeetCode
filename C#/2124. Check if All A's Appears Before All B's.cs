public class Solution {
    public bool CheckString(string s) {
        bool b = false;
        foreach (char c in s) {
            if (c == 'b') b = true;
            if (c == 'a' && b) return false;
        }
        return true;
    }
}