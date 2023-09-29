namespace Clase17A;

class Program
{
    static void Main(string[] args)
    {
    string a = "algún texto";
    Console.WriteLine("1 - " + a.Length);

    Console.WriteLine("2 - " + a.IndexOf('t'));
    a = a.Insert(0, "Esto es ");
    Console.WriteLine("3 - " + a);

    a = a.Replace("Esto es", "Yo tengo");
    Console.WriteLine("4 - " + a);

    if (a.Contains("algún"))
    Console.WriteLine("5 - Encontrado!!");

    a = a.Remove(8);
    Console.WriteLine("6 - " + a);

    a = a.Substring(2);
    Console.WriteLine("7 - " + a);
    }
}
