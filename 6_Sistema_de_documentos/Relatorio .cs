
namespace ExerciciosPilaresPOO
{
    class Relatorio : IImprimivel, IExportavel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório");
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando relatório");
        }
    }
}