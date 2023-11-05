public class Solution {
    public double Average(int[] s) {
        int min = s.Min(), max = s.Max();
        return s.Where(i => i != min && i != max).Average();
    }
}