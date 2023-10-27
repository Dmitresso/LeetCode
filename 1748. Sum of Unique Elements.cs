public class Solution {
    public int SumOfUnique(int[] nums) => nums.GroupBy(x => x).Where(g => g.Count() == 1).SelectMany(g => g).Sum();
}