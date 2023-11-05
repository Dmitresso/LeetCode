public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int count = 0;
        bool isBroken = false;
        foreach (string word in text.Split(' ')) {
            foreach (char c in brokenLetters) {
                if (word.Contains(c)) {
                    isBroken = true;
                    break;
                }
            }

            if (!isBroken) count++;
            isBroken = false;
        }
        return count;
    }
}