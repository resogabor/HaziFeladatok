internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Kérem a szót: ");
        String szo = Console.ReadLine();  
        foreach(char c in szo)
        {
            Console.WriteLine((int)c);
        }
    }
}