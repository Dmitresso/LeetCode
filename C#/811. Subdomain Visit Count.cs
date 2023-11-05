public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        IList<string> list = new List<string>();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        foreach (string d in cpdomains) {
            int spaceIndex = d.IndexOf(' ');
            int count = int.Parse(d.Substring(0, spaceIndex));
            string[] domains = d.Substring(spaceIndex + 1).Split('.');
            string dot = string.Empty, domain = string.Empty;
            for (int i = domains.Length - 1; i >= 0; i--) {
                domain = domains[i] + dot + domain;
                
                if (dict.TryGetValue(domain, out int value))
                    dict[domain] = value + count;
                else
                    dict.Add(domain, count);
                dot = ".";
            } 
        }

        foreach (KeyValuePair<string, int> entry in dict) list.Add(entry.Value + " " + entry.Key);
        return list;
    }
}