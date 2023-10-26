public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (string word in words) {
            var a = word.ToCharArray();
            Array.Reverse(a);
            var s = new string(a);
            if (s == word) return s;
        }
        return "";
    }
}