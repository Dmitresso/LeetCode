public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> set = new HashSet<string>();
        foreach (var email in emails.ToList()) {
            var parts = email.Split('@');
            var index = parts[0].IndexOf('+');
            var e = string.Concat(index == -1 ? parts[0].Replace(".", "") : parts[0].Substring(0, index).Replace(".", ""), "@", parts[1]);
            if (!set.Contains(e)) set.Add(e);
        }
        return set.Count;
    }
}