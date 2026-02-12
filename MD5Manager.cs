using System.Security.Cryptography;

namespace WavChecker
{
    public  static class MD5Manager
    {
        public static string GetMD5(string path)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(path);
            byte[] hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
