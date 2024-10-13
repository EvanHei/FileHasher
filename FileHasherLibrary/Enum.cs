using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHasherLibrary;

/// <summary>
/// Specifies hashing algorithms.
/// </summary>
public enum Algorithm
{
    MD5,
    SHA1,
    SHA256,
    SHA384,
    SHA512
}
