namespace program
{
    class Program
    {
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("ENCRYPTION OR DECRYPTION");
            string enc = Console.ReadLine();
            string enc_dec = enc.ToLower();
            string sentence = "";
            if (enc_dec == "encryption")
            {
                Console.WriteLine("Enter the Sentence that needs to be encrypted");
                sentence = Console.ReadLine();
            }

            if (enc_dec == "decryption")
            {
                Console.WriteLine("Enter the Sentence that needs to be decrypted");
                sentence = Console.ReadLine();
            }
            int j = 0;
            char i = sentence[j];
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] atbash = { 'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A', 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };
            List<char> encrypted = new List<char>();
            while (sentence.Length > j)
            {
                i = sentence[j];
                if (alphabet.Contains(i))
                {

                    int index = Array.IndexOf(alphabet, i);
                    encrypted.Add(atbash[index]);

                }
                else
                {
                    encrypted.Add(i);

                }
                j++;



            }
            if (enc_dec == "decryption")
            {   
                string real_enryption = string.Join("", encrypted);
                Console.WriteLine("The decrypted sentence is:\n" + real_enryption);
            }
            if (enc_dec == "encryption")
            {
                string real_enryption = string.Join("", encrypted);
                Console.WriteLine("The encrypted sentence is:\n" + real_enryption);
            }
            Console.ReadLine();
            //Thread.Sleep(360000);






        }
    }
}

