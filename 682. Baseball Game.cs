public class Solution {
    public int CalPoints(string[] operations) {
        var res = new List<int>();
        for (int i = 0; i < operations.Length; i++) {
            switch (operations[i]) {
                case "C":
                    res.RemoveAt(res.Count - 1);
                    break;
                case "D":
                    res.Add(res[res.Count - 1] * 2);
                    break;
                case "+":
                    res.Add(res[res.Count - 2] + res[res.Count - 1]);
                    break;
                default:
                    res.Add(Convert.ToInt32(operations[i]));
                    break;
            }
        }
        return res.Sum();
    }
}