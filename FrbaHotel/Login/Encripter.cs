using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FrbaHotel.Login.View
{
   public static class Encripter
    {
      public static string GetHash(SHA256 hash, string input)
       {

           // Convert the input string to a byte array and compute the hash.
           byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

           // Create a new Stringbuilder to collect the bytes
           // and create a string.
           StringBuilder sBuilder = new StringBuilder();

           // Loop through each byte of the hashed data 
           // and format each one as a hexadecimal string.
           for (int i = 0; i < data.Length; i++)
           {
               sBuilder.Append(data[i].ToString("x2"));
           }

           // Return the hexadecimal string.
           return sBuilder.ToString();
       }
        //public static byte[] GenerateSHA256String(string inputString)
        //{
        //    byte[] data = Encoding.GetEncoding(1252).GetBytes(inputString);
        //    var sha = new SHA256Managed();
        //    byte[] hash = sha.ComputeHash(data);
        //    return hash;
        //}

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
