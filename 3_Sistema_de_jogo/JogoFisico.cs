
namespace ExerciciosPilaresPOO
{
    public class JogoFisico : Jogo
    {
        public string? TipoDeMidia { get; set; }

        public JogoFisico(string nome, string plataforma, string tipoDeMidia) : base(nome, plataforma)
        {
            TipoDeMidia = tipoDeMidia;
        }

         public override void ExibirInformacoes()
        {
            Console.WriteLine("=== Jogo Físico ===");
            Console.WriteLine($"Nome: {Nome} | Plataforma: {Plataforma} | Mídia: {TipoDeMidia}");
            Console.WriteLine("");
        }
    }
}