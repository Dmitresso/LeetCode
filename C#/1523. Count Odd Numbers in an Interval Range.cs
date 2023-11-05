public class Solution {
    public int CountOdds(int low, int high) => low % 2 != 0 || high % 2 != 0 ? (high - low) / 2 + 1 : (high - low) / 2;
}