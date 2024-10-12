using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileHasherLibrary;

/// <summary>
/// Implementation of SHA-512 hashing algorithm.
/// </summary>
public static class Sha512Hasher
{
    /// <summary>
    /// Computes the SHA-512 hash of the specified data.
    /// </summary>
    /// <param name="data">The data to hash.</param>
    /// <returns>The computed SHA-512 hash.</returns>
    public static byte[] Hash(byte[] data)
    {
        return SHA512.HashData(data);
    }
}
