using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
class EncryptionDecryption
{
	public static string Encrypt(string text)
        {
            int letterInt = 0;
            char singleLetter = ' ';
            string textEncripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;// converting letter to ascii integer and adding +1 to that int
				//Console.WriteLine("ascii integer value : {0}",letterInt);
                singleLetter = (char)letterInt; // converting the ascii int to char letter again
                textEncripted += singleLetter.ToString(); // joining the letter
            }
            return textEncripted;
        }
 
        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char singleLetter = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                singleLetter = (char)letterInt;
                textDecripted += singleLetter.ToString();
            }
            return textDecripted;
        }
    }
 
   public class TestData
    {
       public static void Main()
        {
          
            string newText = EncryptionDecryption.Encrypt("Hello");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = EncryptionDecryption.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);
 
           
        }
    }
/*
output:
Text encripted: Ifmmp
Text Decripted: Hello*/
