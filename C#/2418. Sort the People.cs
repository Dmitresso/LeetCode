public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int, string> d = new Dictionary<int, string>();
        for (int i = 0; i < names.Length; i++) d.Add(heights[i], names[i]);
        return d.ToList().OrderByDescending(p => p.Key).Select(p => p.Value).ToArray();
    }
}