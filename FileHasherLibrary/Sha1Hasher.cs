using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileHasherLibrary;

/// <summary>
/// Implementation of SHA-1 hashing algorithm.
/// </summary>
public static class Sha1Hasher
{
    /// <summary>
    /// Computes the SHA-1 hash of the specified data.
    /// </summary>
    /// <param name="data">The data to hash.</param>
    /// <returns>The computed SHA-1 hash.</returns>
    public static byte[] Hash(byte[] data)
    {
        return SHA1.HashData(data);
    }
}
