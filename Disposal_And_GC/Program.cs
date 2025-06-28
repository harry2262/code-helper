using System.Text.Json;

public class Template


{

    public int[] b;
    public Template()
    {
        b = new int[1000000000];
        Console.WriteLine(GetType());
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Template l = new();
        DateTime d = DateTime.Now;
        Console.WriteLine(GC.GetTotalMemory(true) / 1000.0);
        Console.WriteLine(d);
        // while (true)
        // {

        //     for (int i = 0; i < 9999999; i++)
        //     {
        //         l.b[i] = i * 2 + 5;
        //         Console.WriteLine(l.b[i]);
        // }
        // } ;

        // Console.WriteLine("Hello, World!");
    }
}