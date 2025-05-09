internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Kérem a mondatot: ");
        String mondat = Console.ReadLine();
        foreach(char c in mondat)
        {
            if (c == ' ')
            {
                Console.WriteLine();
            }
            else 
            {  
                Console.Write(c); 
            }
        }

        /* egy másik megoldás
        
        String[] szavak = mondat.Split(' ');
        foreach (String s in szavak)
        {
            Console.WriteLine(s);
        }
        */
    }
}