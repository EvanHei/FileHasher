using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileHasherLibrary;

/// <summary>
/// Implementation of various hashing algorithms.
/// </summary>
public static class Hasher
{
    /// <summary>
    /// Computes the hash of the specified data and the given hash algorithm.
    /// </summary>
    /// <param name="data">The data to hash.</param>
    /// <returns>The computed hash.</returns>
    public static byte[] Hash(byte[] data, Algorithm algorithm)
    {
        switch (algorithm)
        {
            case Algorithm.MD5:
                return MD5.HashData(data);
            case Algorithm.SHA1:
                return SHA1.HashData(data);
            case Algorithm.SHA256:
                return SHA256.HashData(data);
            case Algorithm.SHA384:
                return SHA384.HashData(data);
            case Algorithm.SHA512:
                return SHA512.HashData(data);
            default:
                return new byte[0];
        }
    }
}
