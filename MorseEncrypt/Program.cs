namespace MorseEncrypt
{
    static class Program
    {
        static void Main()
        {
            string text = "Привет";

            EncrypterRussian encrypterRussian = new EncrypterRussian();

            string textEncrypt = encrypterRussian.Encrypt(text);

            Console.WriteLine(textEncrypt);

            Console.WriteLine(encrypterRussian.Decrypt(textEncrypt));
        }
    }
}