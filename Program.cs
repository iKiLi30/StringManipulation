namespace StringManipulation
{
    internal class Program
    {
        void LengthString()
        {
            string myString = "A string";
            char[] myChars = myString.ToCharArray();
            foreach (char c in myChars)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"\nIn a myString is {myString.Length} symbol");
            Console.ReadLine();
        }

        void SeparateS()
        {
            string myString = "This is the test";
            char[] separator = { 's' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine(word);
            }
        }
        void RevertString()
        {
            Console.WriteLine("Write a string ");
            // Write a console application that accepts a string from the user and outputs a string with the characters in reverse order
            string? incoming = Console.ReadLine();
            char[] incomingArray = incoming.ToCharArray();
            Array.Reverse(incomingArray);
            string revertIncoming = new string(incomingArray);
            Console.WriteLine(revertIncoming);
            Console.ReadLine();
        }
        void IncomingReplase()
        {
            Console.WriteLine("Write a string with 'no'");
            // Whrite a console application that accepts a string and replaces all occurrences of the string no with yes.
            string? incoming = Console.ReadLine();
            incoming = incoming.Replace("no", "yes");
            Console.WriteLine(incoming);
            Console.ReadLine();
        }
        void ReplaceQuotes()
        {
            Console.WriteLine("Write a few words separated by spaces");
           // Write a console application that places quotes around each word in a string
            string? incoming = Console.ReadLine();
            incoming = "\"" + incoming.Replace(" ", "\" \"") + "\"";
            Console.WriteLine(incoming);
        }
            
        static void Main(string[] args)
        {
            var program = new Program();
            program.LengthString();
            program.SeparateS();
            program.RevertString();
            program.IncomingReplase();
            program.ReplaceQuotes();
        }

        
    }
}
