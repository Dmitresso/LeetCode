public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        foreach (var s in details) if (int.Parse(new string(new char[] { s[11], s[12] })) > 60) count++;
        return count;
    }
}