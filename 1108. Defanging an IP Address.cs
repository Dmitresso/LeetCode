using System.Text.RegularExpressions;

public class Solution {
    public string DefangIPaddr(string address) => Regex.Replace(address, @"\.", "[.]");
}