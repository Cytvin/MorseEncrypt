namespace MorseEncrypt
{
    public class EncrypterRussian : Encrypter
    {
        private char[] _letters = {'А', 'Б', 'В', 'Г',
        'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М',
        'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х',
        'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю',
        'Я'};

        public EncrypterRussian()
        {
            base.SetAlphabeth(_letters);
        }

        public override string Encrypt(string text)
        {
            return base.Encrypt(text);
        }
    }
}
