﻿using System.Security.Cryptography;
using System.Text;

namespace CosmicCore.Server.Utilities.Cryptography;

internal static class MiHoYoEncryption
{
    public static void Xor(byte[] packet, byte[] key)
    {
        try
        {
            for (var i = 0; i < packet.Length; i++) packet[i] ^= key[i % key.Length];
        }
        catch { }
    }

    public static string GetSessionKey(long id)
    {
        var random = new byte[64];
        var randomGen = new Random();
        randomGen.NextBytes(random);

        var data = id.ToString() + DateTimeOffset.Now.ToUnixTimeMilliseconds() + randomGen;
        return Encoding.UTF8.GetString(SHA512.HashData(Encoding.UTF8.GetBytes(data)));
    }
}
