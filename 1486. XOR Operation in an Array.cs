public class Solution {
    public int XorOperation(int n, int s) => Enumerable.Range(0, n).Select(x => s + 2 * x).Aggregate((x, y) => x ^ y);
}