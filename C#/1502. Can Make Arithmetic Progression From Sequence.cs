public class Solution {
    public bool CanMakeArithmeticProgression(int[] a) {
        Array.Sort(a);
        for (int i = 1; i < a.Length; i++) {
            if (Math.Abs(a[i] - a[i - 1]) != Math.Abs(a[1] - a[0])) return false;
        }
        return true;
    }
}