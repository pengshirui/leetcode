/// <summary>
/// https://leetcode.com/problems/encode-and-decode-tinyurl/
/// </summary>

using System.Collections.Generic;

namespace LeetCode.Medium
{
    public class EncodeAndDecodeTinyUrl
    {

        private readonly Dictionary<int, string> UrlDictionary = new Dictionary<int, string>();

        // Encodes a URL to a shortened URL
        public string Encode(string longUrl)
        {
            if (string.IsNullOrEmpty(longUrl))
            {
                return string.Empty;
            }

            var hashCode = longUrl.GetHashCode();
            if (!this.UrlDictionary.ContainsKey(hashCode))
            {
                this.UrlDictionary.Add(hashCode, longUrl);
            }
            return hashCode.ToString();
        }

        // Decodes a shortened URL to its original URL.
        public string Decode(string shortUrl)
        {
            if (string.IsNullOrEmpty(shortUrl))
            {
                return string.Empty;
            }

            if (int.TryParse(shortUrl, out int hashCode))
            {
                if (this.UrlDictionary.TryGetValue(hashCode, out string url))
                {
                    return url;
                }
            }

            return string.Empty;
        }
    }
}
