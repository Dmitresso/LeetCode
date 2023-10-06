public class Solution {
    public IList<int> MajorityElement(int[] n) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < n.Length; i++) {
            if (d.TryGetValue(n[i], out int j)) d[n[i]]++;
            else d.Add(n[i], 1);
        }

        return d.Where(p => p.Value > n.Length / 3).Select(x => x.Key).ToList();
    }
}