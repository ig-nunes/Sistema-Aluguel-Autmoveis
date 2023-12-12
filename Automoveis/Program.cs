namespace Automoveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Automovel automovel = new Automovel();
            Picape picape = new Picape();

            picape.SetPlaca("ABCD1234");
        }
    }
}
