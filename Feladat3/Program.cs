internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Kérem a szót: ");
        String szo = Console.ReadLine();

        foreach(char c in szo)
        {
            if((szo.IndexOf(c) % 2) != 0)
            {
                Console.WriteLine(c);
            }
        }
    }
}