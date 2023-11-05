public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i].Equals(9)) {
                digits[i] = 0;
            }
            else {
                digits[i]++;
                break;
            }
        }

        if (digits[0].Equals(0)) {
            digits = digits.Concat(new int[] { 0 }).ToArray();
            int tmp = 1;
            for (int i = 0; i < digits.Length - 1; i++) {
                digits[i] = tmp;
                tmp = digits[i + 1];
            }
        }
        return digits;
    }
}