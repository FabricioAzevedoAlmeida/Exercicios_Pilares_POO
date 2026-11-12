
namespace ExerciciosPilaresPOO
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public Carro(string marca, string modelo, int quantidadePortas) : base(marca, modelo)
        {
            QuantidadePortas = quantidadePortas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de Portas: {QuantidadePortas}");
            Console.WriteLine();
        }
    }
}