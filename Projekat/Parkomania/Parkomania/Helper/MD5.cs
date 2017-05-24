﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Parkomania.Helper
{
    public static class MD5
    {
        public static string ComputeMD5(string str)
        {
            if (str != null)
            {
                var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
                IBuffer buff = CryptographicBuffer.ConvertStringToBinary(str, BinaryStringEncoding.Utf8);
                var hashed = alg.HashData(buff);
                var res = CryptographicBuffer.EncodeToHexString(hashed);
                return res;
            }
            else
                return str;        
        }
    }
}
