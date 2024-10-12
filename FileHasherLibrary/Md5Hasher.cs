using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileHasherLibrary;

/// <summary>
/// Implementation of MD5 hashing algorithm.
/// </summary>
public static class Md5Hasher
{
    /// <summary>
    /// Computes the MD5 hash of the specified data.
    /// </summary>
    /// <param name="data">The data to hash.</param>
    /// <returns>The computed MD5 hash.</returns>
    public static byte[] Hash(byte[] data)
    {
        return MD5.HashData(data);
    }
}
