
namespace ExerciciosPilaresPOO
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }

        public decimal Preco { get; set; }

        public ProdutoDigital(string nome, decimal valor)
        {
            Nome = nome;
            Preco = valor;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R${Preco}");
        }
    }

    
}