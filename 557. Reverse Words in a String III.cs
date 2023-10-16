public class Solution {
    public string ReverseWords(string str) => string.Join(" ", str.Split(' ').Select(s => new string(s.Reverse().ToArray())).ToArray());
}