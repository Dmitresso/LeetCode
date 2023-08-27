public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        foreach(var arr in accounts) {
            int sum = 0;
            foreach (int i in arr) sum += i;
            if (sum > max) max = sum;
        }
        return max;
    }
}