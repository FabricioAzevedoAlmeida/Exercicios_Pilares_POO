
namespace ExerciciosPilaresPOO
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(string nome, decimal valor, int cargaHoraria) : base(nome,valor)
        {
            CargaHoraria = cargaHoraria;
        }

         public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Carga Horaria do curso: {CargaHoraria} horas");
            Console.WriteLine();
        }
    }
}