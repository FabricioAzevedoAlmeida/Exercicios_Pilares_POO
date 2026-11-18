
namespace ExerciciosPilaresPOO
{
    public abstract class Equipamento
    {
        public string Modelo { get; set; }
        protected string NumeroSerie;

        public Equipamento(string modelo, string numeroSerie)
        {
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo} | Série: {NumeroSerie}");
        }
    }
}