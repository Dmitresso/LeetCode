public class Solution {
    public int[] BuildArray(int[] nums) {
        int length = nums.Length;
        int[] res = new int[length];
        for (int i = 0; i < length; i++) res[i] = nums[nums[i]];
        return res;
    }
}