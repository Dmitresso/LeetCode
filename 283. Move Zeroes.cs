public class Solution {
    public void MoveZeroes(int[] nums) {           
        for (int i = 0, j = 0; i < nums.Length; i++) {
            if (!nums[i].Equals(0)) {
                int tmp = nums[j];
                nums[j] = nums[i];
                nums[i] = tmp;
                j++;
            }
        }
    }
}