
namespace ExerciciosPilaresPOO
{
    class Notebook : Equipamento
    {
        public int MemoriaRAM { get; set; }

        public Notebook(string modelo, string numeroSerie, int ram) : base(modelo, numeroSerie)
        {
            MemoriaRAM = ram;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"RAM: {MemoriaRAM} GB\n");
        }
    }
}