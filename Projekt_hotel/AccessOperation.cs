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

// Utwórz tablicę bajtów z danych źródłowych.

//Metoda ComputeHash metody HashAlgorithm oblicza skrót. 
//Pobiera tablicę bajtów lub strumień jako dane wejściowe i zwraca skrót w postaci tablicy bajtów o długości 256 bitów

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(EP));
            byte[] Result = md5.Hash;

            StringBuilder str = new StringBuilder();

            for(int i = 0; i < Result.Length; i ++)
            {
// argument „X2” jest „ciągiem formatującym”, który mówi metodzie ToString (), w jaki sposób powinna sformatować ciąg.
// W tym przypadku „X2” wskazuje, że ciąg powinien być sformatowany w formacie szesnastkowym.
                str.Append(Result[i].ToString("x2"));
            }
            return str.ToString();
        }
    }
}
