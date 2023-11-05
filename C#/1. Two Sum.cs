public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (dict.TryGetValue(complement, out int j) && i != j) return new int[] { i, j };
            dict[nums[i]] = i;
        }
        return null;
    }
}