using System.Security.Cryptography;
using System.Text;

namespace WebCrawler
{
    public static class Helper
    {
        public static string CreateSHA512(string strData)
        {
            var message = Encoding.UTF8.GetBytes(strData);
            var hashValue = SHA512.HashData(message);
            return hashValue.Aggregate("", (current, x) => current + $"{x:x2}");
        }
    }
}
