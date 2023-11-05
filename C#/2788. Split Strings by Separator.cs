public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) => new List<string>(words.ToList().SelectMany(s => s.Split(separator)).Where(w => !string.IsNullOrEmpty(w)));
}