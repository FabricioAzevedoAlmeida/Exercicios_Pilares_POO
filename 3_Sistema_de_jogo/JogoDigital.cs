
namespace ExerciciosPilaresPOO
{
    public class JogoDigital : Jogo
    {
        public string? TamanhoGB { get; set; }

        public JogoDigital(string nome, string plataforma, string tamanhoGB) : base(nome, plataforma)
        {
            TamanhoGB = tamanhoGB;
        }

         public override void ExibirInformacoes()
        {
            Console.WriteLine("=== Jogo Digital ===");
            Console.WriteLine($"Nome: {Nome} | Plataforma: {Plataforma} | Tamanho: {TamanhoGB} GB");
            Console.WriteLine();
        }
    }
}