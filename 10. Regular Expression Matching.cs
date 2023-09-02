using System.Text.RegularExpressions;

public class Solution {
	public bool IsMatch(string s, string p) {
		p = Regex.Replace(p, @"\*{1,}", @"{0,}");
		p = p.Insert(0, "^");
		p = p.Insert(p.Length, "$");
		return Regex.IsMatch(s, p);
	}
}