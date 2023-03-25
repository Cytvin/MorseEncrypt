
namespace MorseEncrypt
{
    public class Encrypter
    {
        private char[] _letters;

        private char[] _digits = { '1', '2', '3', '4',
        '5', '6', '7', '8', '9', '0'};

        private string[] _letterCodes = { "*-", "-***", "*--",
        "--*", "-**", "*", "***-", "--**", "**", "*---", "-*-",
        "*-**", "--", "-*", "---", "*--*", "*-*", "***", "-",
        "**-", "**-*", "****", "-*-*", "---*", "----", "--*-",
        "--*--", "-*--", "-**-", "**-**", "**--", "*-*-"};

        private string[] _digitCodes = { "*----", "**---", "***--",
        "****-", "*****", "-****", "--***", "---**", "----*", "-----"};

        public Encrypter()
        {

        }

        public virtual string Encrypt(string text)
        {
            string result = "";

            foreach (char letter in text)
            {
                
            }

            return result;
        }
    }
}
