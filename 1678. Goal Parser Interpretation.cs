using System.Text.RegularExpressions;

public class Solution {
    Dictionary<string, string> dict = new Dictionary<string, string>() {{"()", "o"}, {"(al)", "al"}};
    public string Interpret(string command) => Regex.Replace(command, string.Join("|", dict.Keys.Select(k => Regex.Escape(k))), s => dict[s.Value]);
}