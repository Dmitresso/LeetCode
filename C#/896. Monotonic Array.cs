public class Solution {
    public bool IsMonotonic(int[] nums) {
        if (nums.Length.Equals(1)) return true;
        
		bool inc = false, dec = false;
        
		for (int i = 1; i < nums.Length; i++) {
            if (nums[i] >= nums[i - 1]) inc = true;
            else {
                inc = false;
                break;
            }
        }
		
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] <= nums[i - 1]) dec = true;
            else {
                dec = false;
                break;
            }
        }

        return inc || dec;
    }
}