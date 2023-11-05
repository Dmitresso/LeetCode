public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int i = 0;
        foreach (string s in operations) _ = s.Contains('+') ? i++ : i--;
        return i;
    }
}