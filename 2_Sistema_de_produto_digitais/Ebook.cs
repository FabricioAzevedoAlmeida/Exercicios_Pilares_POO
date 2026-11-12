
namespace ExerciciosPilaresPOO
{
    public class Ebook : ProdutoDigital
    {
       public int QuantidadePaginas { get; set; } 

       public Ebook(string nome, decimal valor, int quantPaginas) : base(nome,valor)
        {
            QuantidadePaginas = quantPaginas;
        }

         public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de paginas: {QuantidadePaginas}");
            Console.WriteLine();
        }
    }
}