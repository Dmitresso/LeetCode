        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string encode(string longUrl) {
            string str;
            var paq = new Uri(longUrl).PathAndQuery;
            
            if (paq.Length <= 1) return longUrl;
            else str = paq.Split('/').Last();

            var bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
            var hash = string.Join("", bytes.Select(b => b.ToString()));
            var base64 = Convert.ToBase64String(bytes).Replace('/', '_');
            dictionary.Add(hash, str);
            return longUrl.Replace(str, base64);
        }

        public string decode(string shortUrl) {
            string base64;
            var paq = new Uri(shortUrl).PathAndQuery;

            if (paq.Length <= 1) return shortUrl;
            else base64 = paq.Split('/').Last();

            var bytes = Convert.FromBase64String(base64.Replace('_', '/'));
            var hash = string.Join("", bytes.Select(b => b.ToString()));
            dictionary.TryGetValue(hash, out string s);
            return shortUrl.Replace(base64, s);
        }