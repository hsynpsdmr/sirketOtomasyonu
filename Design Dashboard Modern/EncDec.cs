using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern
{
    class EncDec
    {
        public string finalData;
        //public string finalData2;
        public void Encryption(string data)
        {
            byte[] tempDizi = System.Text.ASCIIEncoding.ASCII.GetBytes(data);// şifrelenecek veri byte dizisine çevrilir
            finalData = System.Convert.ToBase64String(tempDizi);//Base64 ile şifrelenir
            //Console.WriteLine(finalData);


        }

        //public void Decryption(string finalData)
        //{
        //    byte[] tempDizi = System.Convert.FromBase64String(finalData);
        //    string finalData2 = System.Text.ASCIIEncoding.ASCII.GetString(tempDizi);
        //    //Console.WriteLine(finalData2);


        //}
    }
}
