internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Kérem a szót: ");
        String szo = Console.ReadLine();
        for (int i = szo.Length - 1; i >= 0; i--) { 
            Console.Write(szo[i]);
        }
    }
}