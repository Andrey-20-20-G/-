using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алфавит;

namespace КМЗИ_Лабы._4_лаба
{
    internal class MyRSA
    {
        public void GetAnswer()
        {
            var keySize = 1000;
            var rsaKeyGen = new RSACryptoServiceProvider(keySize);
            Console.WriteLine("Введите сообщение");
            string mess = Console.ReadLine();
                    
                   
                                var cipherText = RSA_Endoce(mess, rsaKeyGen.ExportParameters(false));

                                
                                Console.WriteLine("Зашифрованное сообщение: {0}", cipherText);
                             
                      
                                var plainText = RSA_Dedoce(cipherText, rsaKeyGen.ExportParameters(true));

                                Console.WriteLine("Расшифрованное сообщение: {0}", plainText);          
        }


        private string RSA_Endoce(string data, RSAParameters key)
        {
            using(var rsa = new RSACryptoServiceProvider()) 
            {
                rsa.ImportParameters(key);
                var byteData = Encoding.UTF8.GetBytes(data);
                var encryptData = rsa.Encrypt(byteData, true);
                return Convert.ToBase64String(encryptData);
            }
        }

        private string RSA_Dedoce(string cipherText, RSAParameters key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                var cipherByteData = Convert.FromBase64String(cipherText);
                rsa.ImportParameters(key);
                var byteData = Encoding.UTF8.GetBytes(cipherText);
                var encryptData = rsa.Decrypt(cipherByteData, true);
                return Encoding.UTF8.GetString(encryptData);
            } 
        }

        
    }
}
