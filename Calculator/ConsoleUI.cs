namespace Calculator
{
    internal class ConsoleUI : View
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public string ReadLine()
        {
            string line = Console.ReadLine()!;
            return line;
        }
    }
}
