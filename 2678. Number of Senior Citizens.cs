using System.Text.RegularExpressions;

public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        foreach (var s in details) if (Regex.IsMatch(s, @"[FMO]([6][1-9]|[7-9][0-9])\d{2}$")) count++;
        return count;
    }
}