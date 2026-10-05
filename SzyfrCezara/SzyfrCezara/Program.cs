using SzyfrCezara;

string text = Console.ReadLine();
int key = 0;
int.TryParse(Console.ReadLine(), out key);
CaesarCipher cipher = new CaesarCipher(text, key);
Console.WriteLine("Nowy tekst: " + cipher.encrypt());

namespace SzyfrCezara 
{
    public class CaesarCipher
    {
        public String text;
        public int key;

        public CaesarCipher(String txt, int k)
        {
            if (txt != null)
                text = txt;
            else
                text = "default";
            key = k;
        }

        public String encrypt()
        {
            char[] letters = text.ToLower().ToCharArray();
            key %= 26;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] != ' ')
                {
                    if (letters[i] + key > 122)
                        letters[i] = (char)(96 + (letters[i] + key - 122));
                    else if (letters[i] + key < 97)
                        letters[i] = (char)(123 - (97 - (letters[i] + key)));
                    else
                        letters[i] = (char)(letters[i] + key);
                }
            };
            text = new String(letters);
            return text;
        }

    }
}
