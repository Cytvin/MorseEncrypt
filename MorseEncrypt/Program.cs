namespace MorseEncrypt
{
    static class Program
    {
        static void Main()
        {
            //EncrypterRussian encrypter = new EncrypterRussian();

            EncrypterEnglish encrypter = new EncrypterEnglish();

            //string text = "Привет";

            string text = "Hello";

            string textEncrypt = encrypter.Encrypt(text);

            Console.WriteLine(textEncrypt);

            Console.WriteLine(encrypter.Decrypt(textEncrypt));
        }
    }
}