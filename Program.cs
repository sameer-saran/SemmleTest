using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Testpassword";
            MD5CryptoServiceProvider md5hash = new MD5CryptoServiceProvider();
            byte[] hashArray = md5hash.ComputeHash(Encoding.ASCII.GetBytes(password));
            Console.WriteLine("password is " + password);
        }
    }
}
