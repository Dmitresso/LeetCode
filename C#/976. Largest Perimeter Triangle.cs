public class Solution {
    public int LargestPerimeter(int[] nums) {
        int p = 0;
        Array.Sort(nums);
        for (int i = 2; i < nums.Length; i++) {
            var t = new int[] { nums[i - 2], nums[i - 1], nums[i] };
            if (isTriangle(t)) {
                if (isDegenerate(t)) p = 0;
                else {
                    int s = Enumerable.Sum(t);
                    if (s > p) p = s;
                }
            }
        }
        return p;

        bool isTriangle(int[] a) => a[0] + a[1] > a[2];
        bool isDegenerate(int[] a) => a[0] + a[1] <= a[2];
    }
}