public class Solution {
    public int ArraySign(int[] nums) => nums.Contains(0) ? 0 : nums.Count(i => i < 0) % 2 == 0 ? 1 : -1;
}