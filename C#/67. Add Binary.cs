public class Solution {
    public string AddBinary(string a, string b) {
        bool carry = false;
        StringBuilder sb = new StringBuilder();

        if (a.Length > b.Length) b = b.Insert(0, new string('0', Math.Abs(a.Length - b.Length)));
        else if (a.Length < b.Length) a = a.Insert(0, new string('0', Math.Abs(a.Length - b.Length)));

        for (int i = a.Length - 1, j = b.Length - 1; i >= 0 && j >= 0; i--, j--) sb.Insert(0, Sum(a[i], b[j]));
        if (carry) sb.Insert(0, "1");
        return sb.ToString();

        char Sum(char c, char d) {
            if (c == '0') { // 0 ? ?
                if (d == '0') { // 0 0 ?
                    if (carry) { // 0 0 1
                        carry = false;
                        return '1';
                    }
                    else return '0'; // 0 0 0
                }
                else { // 0 1 ?
                    if (carry) { // 0 1 1
                        return '0';
                    }
                    else return '1'; // 0 1 0
                }
            }
            else if (d == '0') { // 1 0 ?
                if (carry) return '0'; // 1 0 1
                else return '1'; // 1 0 0
            }
            else { // 1 1 ?
                if (carry) return '1'; // 1 1 1
                else {
                    carry = true;
                    return '0'; // 1 1 0
                }
            }
        }
    }
}