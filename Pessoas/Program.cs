namespace Pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cliente!");
            Funcionario funcionario = new Funcionario();

            DateTime dataAdmissao = DateTime.Now;

            funcionario.SetDataAdmissao(dataAdmissao);

            Console.WriteLine(funcionario.GetDataAdmissao());

        }
    }
}
