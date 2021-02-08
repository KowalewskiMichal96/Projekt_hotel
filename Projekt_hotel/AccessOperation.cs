using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projekt_hotel
{
    class AccessOperation
    {
        public static string EncryptPassword(string EP)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            // convert the input string to a byte array and calculate the hash
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(EP));
            byte[] Result = md5.Hash;

            StringBuilder str = new StringBuilder();


            // loop all  byte of hashed data
            // format each one as a hexadecimal string
            for(int i = 0; i < Result.Length; i ++)
            {

                // add to the end of string hashed byte
                str.Append(Result[i].ToString("x2"));
            }


            return str.ToString();
        }
    }
}
