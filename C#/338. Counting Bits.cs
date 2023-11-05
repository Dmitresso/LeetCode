public class Solution {
    public int[] CountBits(int n) {
        List<int> res = new List<int>(n);
        for (int i = 0; i <= n; i++) res.Add(Convert.ToString(i, 2).Count(x => x == '1'));
        return res.ToArray();
    }
}