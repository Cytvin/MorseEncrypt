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

            text = text.ToUpper();

            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    result += _letterCodes[Array.IndexOf(_letters, letter)] + " ";
                }
                else if (char.IsDigit(letter))
                {
                    result += _digitCodes[Array.IndexOf(_digits, letter)] + " ";
                }
            }

            result = result.TrimEnd();

            return result;
        }

        public virtual string Decrypt(string text)
        {
            string result = "";

            foreach (string charCode in text.Split(' '))
            {
                result += _letters[Array.IndexOf(_letterCodes, charCode)] + " ";
            }

            result = result.TrimEnd();

            return result;
        }

        public void SetAlphabeth(char[] letters)
        {
            _letters = letters;
        }
    }
}
