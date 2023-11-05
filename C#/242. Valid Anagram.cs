public class Solution {
    public bool IsAnagram(string s1, string s2) {
        var s3 = s1.ToList();
        var s4 = s2.ToList();
        s3.Sort();
        s4.Sort();
        return Enumerable.SequenceEqual(s3, s4);
    }
}