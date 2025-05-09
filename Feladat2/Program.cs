internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Tabu betű: ");
        int tb = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        Console.Write("A szó: ");
        String szo = Console.ReadLine();

        foreach(char c in szo)
        {
            if ((int)c != tb)
            {
                Console.Write(c);
            }
        }
    }
}