using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КМЗИ_Лабы._3_лаба
{
    internal class GetAnswer
    {
        public void GetMyAnswer()
        {
            //передаем в конструктор класса буквы русского алфавита
            var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");//"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
            Console.WriteLine("Введите текст: ");
            var inputText = Console.ReadLine().ToUpper();
            Console.WriteLine("Введите ключ: ");
            var password = Console.ReadLine().ToUpper();
            var encryptedText = cipher.Encrypt(inputText, password);
            Console.WriteLine("Выберите действие над сообщением: 1 - зашифровать, 2 - расшифровать");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(inputText, password));
                        break;
                    }
            }
        }
    }
}
