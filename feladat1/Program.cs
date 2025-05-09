internal class Program
{
    private static void Main(string[] args)
    {
        String szo = Console.ReadLine();

        for (int i = 0; i <= szo.Length-1; i++)
        {
            Console.Write(szo[i]);
            Console.Write(" ");
        }
    }
}