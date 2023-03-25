
namespace MorseEncrypt
{
    public class EncrypterEnglish : Encrypter
    {
        private char[] _letters = { 'A', 'B', 'W',
        'G', 'D', 'E', 'V', 'Z', 'I', 'J', 'K', 'L',
        'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'F',
        'H', 'C', '_', '_', 'Q', '_', 'Y', 'X', '_',
        '_', '_'};

        public EncrypterEnglish()
        {
            
        }

        public override string Encrypt(string text)
        {
            return base.Encrypt(text);
        }
    }
}
