using System.Collections.Generic;
using System.Security.Cryptography;
using Xunit;
using FileHasherLibrary;

namespace FileHasherLibrary.Tests;

public class HasherTests
{
    [Theory]
    [InlineData("Hello World", Algorithm.MD5, "b10a8db164e0754105b7a99be72e3fe5")]
    [InlineData("Hello World", Algorithm.SHA1, "0a4d55a8d778e5022fab701977c5d840bbc486d0")]
    [InlineData("Hello World", Algorithm.SHA256, "a591a6d40bf420404a011733cfb7b190d62c65bf0bcda32b57b277d9ad9f146e")]
    [InlineData("Hello World", Algorithm.SHA384, "99514329186b2f6ae4a1329e7ee6c610a729636335174ac6b740f9028396fcc803d0e93863a7c3d90f86beee782f4f3f")]
    [InlineData("Hello World", Algorithm.SHA512, "2c74fd17edafd80e8447b0d46741ee243b7eb74dd2149a0ab1b9246fb30382f27e853d8585719e0e67cbda0daa8f51671064615d645ae27acb15bfb1447f459b")]
    public void Hash_GivenInputData_ReturnsExpectedHash(string input, Algorithm algorithm, string expectedHash)
    {
        // Arrange
        byte[] data = System.Text.Encoding.UTF8.GetBytes(input);

        // Act
        byte[] result = Hasher.Hash(data, algorithm);

        // Assert
        string actualHash = BitConverter.ToString(result).Replace("-", "").ToLower();
        Assert.Equal(expectedHash, actualHash);
    }

    [Fact]
    public void Hash_GivenUnsupportedAlgorithm_ReturnsEmptyByteArray()
    {
        // Arrange
        byte[] data = System.Text.Encoding.UTF8.GetBytes("Unsupported");

        // Act
        byte[] result = Hasher.Hash(data, (Algorithm)999); // Unsupported Algorithm

        // Assert
        Assert.Empty(result);
    }
}