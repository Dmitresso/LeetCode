public class Solution {
    public bool AreNumbersAscending(string str) {
        var list = str.Split(' ').ToList().Where(s => int.TryParse(s, out int i)).Select(s => int.Parse(s)).ToList();
        for (int i = 1; i <= list.Count() - 1; i++) if (list[i] <= list[i - 1]) return false;
        return true;
    }
}