internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Kérem a mondatot: ");
        String mondat = Console.ReadLine();
        String[] szavak = mondat.Split(' ');
        // ez a szép megoldás
        foreach (String s in szavak)
        {

            Console.WriteLine(char.ToUpper(s[0]) + s.Substring(1));
        }
        
        //for (int i = 0; i < szavak.Length; i++)
        //{

        //}
    }
}